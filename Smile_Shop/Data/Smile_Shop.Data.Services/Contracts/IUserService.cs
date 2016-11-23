namespace Smile_Shop.Data.Services.Contracts
{
    using System.Linq;
    using ViewModels.User;

    public interface IUserService
    {
        IQueryable<UserVm> GetAll();

        UserVm Add(UserVm vm);

        void Update(UserVm vm);

        void Delete(UserVm vm);

        string GeneratePasswordResetToken(string email);

        UserVm Get(string email);

        UserVm GetById(string Id);

        bool Exists(string email);

        bool Exists(string id, string email);
    }
}
