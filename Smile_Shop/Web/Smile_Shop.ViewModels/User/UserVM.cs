namespace Smile_Shop.ViewModels.User
{
    using AutoMapper;
    using Data.Models;
    using Smile_Shop.Lozalization.Resources;
    using Smile_Shop.ViewModels.Infrastructure;
    using System;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNet.Identity.EntityFramework;

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
<<<<<<< HEAD:Smile_Shop/Smile_Shop.ViewModels/User/UserVM.cs
=======
        [StringLength(30, MinimumLength = 3, ErrorMessageResourceName = "InvalidNameLength", ErrorMessageResourceType = typeof(Resources))]
>>>>>>> 56a656cc3c32e7587329023033aea3e11d1a73a3:Smile_Shop/Web/Smile_Shop.ViewModels/User/UserVM.cs
        public string FirstName { get; set; }

        [Display(Name = "LastName", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "NameRequired", ErrorMessageResourceType = typeof(Resources))]
        [StringLength(30, MinimumLength = 3, ErrorMessageResourceName = "InvalidNameLength", ErrorMessageResourceType = typeof(Resources))]
        public string LastName { get; set; }


        [Display(Name = "Email", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "EmailRequired", ErrorMessageResourceType = typeof(Resources))]
        [DataType(DataType.EmailAddress, ErrorMessageResourceName = "InvalidLoginEmail", ErrorMessageResourceType = typeof(Resources))]
        public string Email { get; set; }

        public string PasswordResetToken { get; set; }

        [Display(Name = "PhoneNumber", ResourceType = typeof(Resources))]
        public string PhoneNumber { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime LastLoginDate { get; set; }

        [Display(Name = "City", ResourceType =typeof(Resources))]
        public string City { get; set; }

    }
}
