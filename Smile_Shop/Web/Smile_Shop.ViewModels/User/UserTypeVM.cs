using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smile_Shop.ViewModels.Infrastructure;
using Smile_Shop.Data.Models;
using System.ComponentModel.DataAnnotations;
using Smile_Shop.Lozalization.Resources;

namespace Smile_Shop.ViewModels.User
{
    public class UserTypeVm : IMapFrom<UserType>
    {
        [Display(Name = "Assignment", ResourceType = typeof(Resources))]
        public int Id { get; set; }

        [Display(Name = "TypeName", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "TypeNameRequired", ErrorMessageResourceType = typeof(Resources))]
        [StringLength(100, MinimumLength = 3, ErrorMessageResourceName = "InvalidTypeNameLength", ErrorMessageResourceType = typeof(Resources))]
        public string Type { get; set; }
    }
}
