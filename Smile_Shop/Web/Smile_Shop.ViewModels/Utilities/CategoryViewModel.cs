namespace Smile_Shop.ViewModels.Utilities
{
    using Data.Models;
    using Lozalization.Resources;
    using Infrastructure;
    using System.ComponentModel.DataAnnotations;

    public class CategoryViewModel : IMapFrom<Category>
    {
        [Display(Name = "Assignment", ResourceType = typeof(Resources))]
        public int Id { get; set; }

        [Display(Name = "CategoryName", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "CategoryNameRequired", ErrorMessageResourceType = typeof(Resources))]
        [StringLength(100, MinimumLength = 3, ErrorMessageResourceName = "InvalidCategoryNameLength", ErrorMessageResourceType = typeof(Resources))]
        public string Name { get; set; }
    }
}
