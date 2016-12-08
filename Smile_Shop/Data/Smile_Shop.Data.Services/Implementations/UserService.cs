namespace Smile_Shop.Data.Services.Implementations
{
    using System.Linq;
    using Contracts;
    using System;
    using Common;
    using Models;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using ViewModels.User;

    public class UserService : IUserService
    {
        private IDeletableRepository<ApplicationUser> users;

        public UserService(IDeletableRepository<ApplicationUser> u)
        {
            this.users = u;
        }

        public UserViewModel Add(UserViewModel vm)
        {
            var model = Mapper.Map<ApplicationUser>(vm);
            model.Id = Guid.NewGuid().ToString();
            model.PasswordResetToken = Guid.NewGuid().ToString();
            model.Name = vm.Email;

            this.users.Add(model);
            this.users.SaveChanges();

            return Mapper.Map<UserViewModel>(model);
        }

        public void Delete(UserViewModel vm)
        {
            var user = this.users.FirstOrDefault(u => u.Id == vm.Id);
            this.users.Update(user);
            this.users.SaveChanges();
        }

        public bool Exists(string email)
        {
            return this.users.Any(s => s.UserName == email);
        }

        public bool Exists(string id, string email)
        {
            return this.users.Any(s => s.Id != id && s.Email == email);
        }

        public string GeneratePasswordResetToken(string email)
        {
            var user = this.users.FirstOrDefault(s => s.Email == email);

            user.PasswordHash = null;
            user.PasswordResetToken = Guid.NewGuid().ToString();

            this.users.Update(user);
            this.users.SaveChanges();

            return user.PasswordResetToken;
        }

        public UserViewModel Get(string email)
        {
            return Mapper.Map<UserViewModel>(this.users.FirstOrDefault(s => s.Email == email));
        }

        public UserViewModel GetById(string id)
        {
            return Mapper.Map<UserViewModel>(this.users.FirstOrDefault(s => s.Id == id));
        }

        public IQueryable<UserViewModel> GetAll()
        {
            return this.users.Where(u => !u.IsSystemAdministrator).ProjectTo<UserViewModel>();
        }

        public void Update(UserViewModel vm)
        {
            var model = this.users.FirstOrDefault(u => u.Id == vm.Id);
            model.UserName = vm.Email;
            this.users.Update(Mapper.Map(vm, model));
            this.users.SaveChanges();
        }
    }
}
