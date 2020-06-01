using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Product()
        {
        }

        public Product(int id, 
                       string name, 
                       double price, 
                       string color, 
                       string description, 
                       int categoryId, 
                       Category category)
        {
            Id = id;
            Name = name;
            Price = price;
            Color = color;
            Description = description;
            CategoryId = categoryId;
            Category = category;
        }
    }
}
