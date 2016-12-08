namespace Smile_Shop.Data.Services.Contracts
{
    using Common;
    using System.Linq;
    using ViewModels.User;

    public interface IUserService : IService
    {
        IQueryable<UserViewModel> GetAll();

        UserViewModel Add(UserViewModel vm);

        void Update(UserViewModel vm);

        void Delete(UserViewModel vm);

        string GeneratePasswordResetToken(string email);

        UserViewModel Get(string email);

        UserViewModel GetById(string Id);

        bool Exists(string email);

        bool Exists(string id, string email);
    }
}
