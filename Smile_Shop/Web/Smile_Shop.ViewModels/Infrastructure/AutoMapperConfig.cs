namespace Smile_Shop.ViewModels.Infrastructure
{
    using AutoMapper;

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;

    public static class AutoMapperConfig
    {
        public static MapperConfiguration Configuration { get; private set; }

        public static void Execute()
        {
            Configuration = new MapperConfiguration(
                cfg =>
                {
                    var types = Assembly.GetExecutingAssembly().GetExportedTypes();
                    LoadStandardMappings(types, cfg);
                    LoadCustomMappings(types, cfg);
                });
        }

        private static void LoadStandardMappings(IEnumerable<Type> types, IMapperConfiguration mapperConfiguration)
        {
            var maps = (from t in types
                        from i in t.GetInterfaces()
                        where i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>) &&
                              !t.IsAbstract &&
                              !t.IsInterface
                        select new
                        {
                            Source = i.GetGenericArguments()[0],
                            Destination = t
                        }).ToArray();

            foreach (var map in maps)
            {
                mapperConfiguration.CreateMap(map.Source, map.Destination);
            }

            foreach (var map in maps)
            {
                mapperConfiguration.CreateMap(map.Destination, map.Source);
            }
        }

        private static void LoadCustomMappings(IEnumerable<Type> types, IMapperConfiguration mapperConfiguration)
        {
            var maps = (from t in types
                        from i in t.GetInterfaces()
                        where typeof(IHaveCustomMappings).IsAssignableFrom(t) &&
                              !t.IsAbstract &&
                              !t.IsInterface
                        select (IHaveCustomMappings)Activator.CreateInstance(t)).ToArray();

            foreach (var map in maps)
            {
                map.CreateMappings(mapperConfiguration);
            }
        }
    }
}