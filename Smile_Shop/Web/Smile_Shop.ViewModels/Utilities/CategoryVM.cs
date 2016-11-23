using Smile_Shop.Lozalization.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smile_Shop.ViewModels.Utilities
{
    public class CategoryVm
    {
        [Display(Name = "Assignment", ResourceType = typeof(Resources))]
        public int Id { get; set; }

        [Display(Name = "CategoryName", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "CategoryNameRequired", ErrorMessageResourceType = typeof(Resources))]
        [StringLength(100, MinimumLength = 3, ErrorMessageResourceName = "InvalidCategoryNameLength", ErrorMessageResourceType = typeof(Resources))]
        public string Name { get; set; }
    }
}
