using static System.Net.Mime.MediaTypeNames;

namespace Smile_Shop.Data.Services.Implementations
{
    using System.Linq;
    using Contracts;
    using System;
    using Common;
    using Models;
    using AutoMapper;

    public class UserService : IUserService
    {
        private IDeletableRepository<ApplicationUser> users;

        public UserService(IDeletableRepository<ApplicationUser> u)
        {
            this.users = u;
        }

        public UserVM Add(UserVM vm)
        {
            var model = Mapper.Map<ApplicationUser>(vm);
            model.Id = Guid.NewGuid().ToString();
            model.PasswordResetToken = Guid.NewGuid().ToString();
            model.Name = vm.Email;

            this.users.Add(model);
            this.users.SaveChanges();

            return Mapper.Map<UserVM>(model);
        }

        public void Delete(UserVM vm)
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

        public UserVM Get(string email)
        {
            return Mapper.Map<UserVM>(this.users.FirstOrDefault(s => s.Email == email));
        }

        public UserVM GetById(string id)
        {
            return Mapper.Map<UserVM>(this.users.FirstOrDefault(s => s.Id == id));
        }

        public IQueryable<UserVM> GetAll()
        {
            return this.users.Where(u => !u.IsSystemAdministrator).ProjectTo<UserVM>();
        }

        public void Update(UserVM vm)
        {
            var model = this.users.FirstOrDefault(u => u.Id == vm.Id);
            model.UserName = vm.Email;
            this.users.Update(Mapper.Map(vm, model));
            this.users.SaveChanges();
        }
    }
}
