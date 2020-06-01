using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public Category()
        {
        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddProduct(Product product) => Products.Add(product);
        
        public void RemoveProduct(Product product) => Products.Remove(product);
    }
}
