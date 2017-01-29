namespace Smile_Shop.Data.Models
{
    using System;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Entities;
    using System.Data.Entity;
    using System.Linq;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", false)
        {
        }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Item> Items { get; set; }

        public IDbSet<NLogEntry> NLogEntries { get; set; }

        // IDbSet<User> Users ovverrides something from Asp.net libraries => name is User
        public IDbSet<ApplicationUser> User { get; set; }

        public IDbSet<UserType> UserTypes { get; set; }



        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges();
        }

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in this.ChangeTracker.Entries()
                    .Where(e => e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    if (!entity.PreserveCreatedOn)
                    {
                        entity.CreatedOn = DateTime.Now;
                    }
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }
    }
}
