using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smile_Shop.Data.Models;

namespace Smile_Shop.ViewModels.Utilities
{
    public class ItemVM
    {
        public int Id { get; set; }

        public Category Category { get; set; }

        public Smile_Shop.Data.Models.User Owner { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        public string PictureLocation { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
