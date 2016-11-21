namespace Smile_Shop.ViewModels.User
{
    using AutoMapper;
    using Smile_Shop.Data.Models;
    using Smile_Shop.Lozalization.Resources;
    using Smile_Shop.ViewModels.Infrastructure;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UserVM : IMapFrom<ApplicationUser>
    {
        public UserVM()
        {
        }

        public UserVM(ApplicationUser user)
        {
            Mapper.Map(user, this);
        }

        [Display(Name = "Assignment", ResourceType = typeof(Resources))]
        public string Id { get; set; }

        [Display(Name = "FirstName", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "NameRequired", ErrorMessageResourceType = typeof(Resources))]
        public string FirstName { get; set; }

        [Display(Name = "LastName", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "NameRequired", ErrorMessageResourceType = typeof(Resources))]
        public string LastName { get; set; }


        [Display(Name = "Email", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "EmailRequired", ErrorMessageResourceType = typeof(Resources))]
        [DataType(DataType.EmailAddress, ErrorMessageResourceName = "InvalidLoginEmail", ErrorMessageResourceType = typeof(Resources))]
        public string Email { get; set; }

        public string PasswordResetToken { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime LastLoginDate { get; set; }

        public string City { get; set; }

    }
}
