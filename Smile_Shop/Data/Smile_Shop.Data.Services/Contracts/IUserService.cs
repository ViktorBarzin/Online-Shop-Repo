namespace Smile_Shop.Data.Services.Contracts
{
    using System.Linq;
    using ViewModels.User;

    public interface IUserService
    {
        IQueryable<UserVM> GetAll();

        UserVM Add(UserVM vm);

        void Update(UserVM vm);

        void Delete(UserVM vm);

        string GeneratePasswordResetToken(string email);

        UserVM Get(string email);

        UserVM GetById(string Id);

        bool Exists(string email);

        bool Exists(string id, string email);
    }
}
