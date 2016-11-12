﻿namespace Smile_Shop.Application.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public string Message { get; set; }
    }
} 