using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class CategoryViewModel
    {
        public Category Category { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
