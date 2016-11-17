namespace Smile_Shop.ViewModels.Manage
{
    using Lozalization.Resources;
    using System.ComponentModel.DataAnnotations;

    public class SetPasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "NewPassword", ResourceType = typeof(Resources))]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(Resources))]
        [Compare("NewPassword", ErrorMessageResourceName = "PasswordsDontMatch", ErrorMessageResourceType = typeof(Resources))]
        public string ConfirmPassword { get; set; }
    }
}
