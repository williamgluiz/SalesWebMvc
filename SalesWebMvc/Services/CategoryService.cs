using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class CategoryService
    {
        private readonly SalesWebMvcContext _context;

        public CategoryService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Category> FindAll()
        {
            return _context.Category.ToList();
        }
    }
}
