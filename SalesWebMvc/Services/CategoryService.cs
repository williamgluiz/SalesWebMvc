using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class CategoryService
    {
        private readonly SalesWebMvcContext _context;

        public CategoryService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> FindAllAsync()
        {
            return await _context.Category.ToListAsync();
        }

        public async Task InsertAsync(Category category)
        {
            _context.Category.Add(category);
            await _context.SaveChangesAsync(); 
        }

        public async Task<Category> FindByIdAsync(int id)
        {
            return await _context.Category
                                 .Include(dept => dept.Department)
                                 .FirstOrDefaultAsync(catg => catg.Id == id);
        }
    }
}
