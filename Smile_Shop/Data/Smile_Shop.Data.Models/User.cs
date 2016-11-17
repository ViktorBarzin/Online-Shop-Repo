using System;
using System.ComponentModel.DataAnnotations;

namespace Smile_Shop.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime LastLoginDate { get; set; }

        public UserType UserType { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }
    }
}
