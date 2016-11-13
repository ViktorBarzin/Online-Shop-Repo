using System;

namespace Smile_Shop.Data.Models
{
    public class Item
    {
        public int Id { get; set; }

        public Category Category { get; set; }

        public User Owner { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        public string PictureLocation { get; set; }

        public DateTime DateAdded { get; set; }
        
    }
}
