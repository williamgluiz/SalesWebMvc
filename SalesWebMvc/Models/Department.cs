using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
        public ICollection<Category> Categories { get; set; } = new List<Category>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller) => Sellers.Add(seller);

        public void AddCategory(Category category) => Categories.Add(category);

        public double TotalSales(DateTime initial, DateTime final) => Sellers.Sum(seller => seller.TotalSales(initial, final));
    }
}
