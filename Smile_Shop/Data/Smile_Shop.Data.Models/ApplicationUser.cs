namespace Smile_Shop.Data.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Threading.Tasks;
    using Entities;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Security.Claims;
    using Microsoft.AspNet.Identity;

    public class ApplicationUser : IdentityUser, IDeletableEntity, IAuditInfo
    {
        public string Name { get; set; }

        public string PasswordResetToken { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public DateTime CreatedOn { get; set; }

        [NotMapped]
        public bool PreserveCreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            // Add custom user claims here
            return userIdentity;
        }
    }
}