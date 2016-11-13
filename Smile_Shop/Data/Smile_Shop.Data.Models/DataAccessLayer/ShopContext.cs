using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Configuration;

namespace Smile_Shop.Data.Models.DataAccessLayer
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("ShopContext")
        {
            //string connnectionString = ConfigurationManager.ConnectionStrings["Server=localhost;Database=myDataBase;User Id=myUsername;Password = myPassword; "].ConnectionString;
            ////MySql server - Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
            //// MS Sql server - Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserType> UserTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
