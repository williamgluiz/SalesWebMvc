using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly CategoryService _categoryService;
        private readonly DepartmentService _departmentService;

        public CategoriesController(CategoryService categoryService, DepartmentService departmentService)
        {
            _categoryService = categoryService;
            _departmentService = departmentService;
        }

        public async Task<IActionResult> Index()
        {
            var categoriesList = await _categoryService.FindAllAsync();
            return View(categoriesList);
        }

        public async Task<IActionResult> Create()
        {
            var departmentsList = await _departmentService.FindAllAsync();
            var viewModel = new CategoryViewModel { Departments = departmentsList };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                var departmentsList = await _departmentService.FindAllAsync();
                var viewModel = new CategoryViewModel { Category = category, Departments = departmentsList };

                return View(viewModel);
            }
            await _categoryService.InsertAsync(category);

            return RedirectToAction(nameof(Index));
        }
    }
}