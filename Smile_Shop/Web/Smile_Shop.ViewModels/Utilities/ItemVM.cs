using System;
using Smile_Shop.Data.Models;
using System.ComponentModel.DataAnnotations;
using Smile_Shop.Lozalization.Resources;

namespace Smile_Shop.ViewModels.Utilities
{
    public class ItemVM
    {
        [Display(Name = "Assignment", ResourceType = typeof(Resources))]
        public int Id { get; set; }

        [Display(Name = "Category", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "CategoryNameRequired", ErrorMessageResourceType = typeof(Resources))]
        [StringLength(30, MinimumLength = 1, ErrorMessageResourceName = "InvalidCategoryNameLength", ErrorMessageResourceType = typeof(Resources))]
        public Category Category { get; set; }

        [Display(Name = "Owner", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "OwnerRequired", ErrorMessageResourceType = typeof(Resources))]
        [StringLength(30, MinimumLength = 3, ErrorMessageResourceName = "InvalidOwnerNameLength", ErrorMessageResourceType = typeof(Resources))]
        public Data.Models.User Owner { get; set; }

        [Display(Name = "ItemName", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "ItemNameRequired", ErrorMessageResourceType = typeof(Resources))]
        [StringLength(100, MinimumLength = 3, ErrorMessageResourceName = "InvalidItemNameLength", ErrorMessageResourceType = typeof(Resources))]
        public string Name { get; set; }

        [Display(Name = "Price", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "PriceRequired", ErrorMessageResourceType = typeof(Resources))]
        [Range(0, double.MaxValue, ErrorMessageResourceName = "InvalidPrice", ErrorMessageResourceType = typeof(Resources))]
        public decimal Price { get; set; }

        [Display(Name = "Quantity", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "QuantityNameRequired", ErrorMessageResourceType = typeof(Resources))]
        [Range(0, int.MaxValue, ErrorMessageResourceName = "InvalidQuantity", ErrorMessageResourceType = typeof(Resources))]
        public int Quantity { get; set; }

        [Display(Name = "Description", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "DescriptionRequired", ErrorMessageResourceType = typeof(Resources))]
        [StringLength(10000, MinimumLength = 1, ErrorMessageResourceName = "InvalidDescriptionLength", ErrorMessageResourceType = typeof(Resources))]
        public string Description { get; set; }

        [Display(Name = "PictureLocation", ResourceType = typeof(Resources))]
        [StringLength(2083, ErrorMessageResourceName = "InvalidUrlLength", ErrorMessageResourceType = typeof(Resources))]
        public string PictureLocation { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
