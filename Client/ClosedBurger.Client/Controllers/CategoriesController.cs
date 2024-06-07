using ClosedBurger.Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClosedBurger.Client.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly CloseBurgerDbContext _context;

        public CategoriesController(CloseBurgerDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Category.ToListAsync());
        }public async Task<IActionResult> ProductsByCategory(int id)
        {
            var product = await _context.Product.Where(p=>p.CategoryId==id).ToListAsync();
            var category =await _context.Category.FirstOrDefaultAsync(c=>c.Id==id);
            if (category==null)
            {
                return NotFound();
            }
            var viewModel = new CategoryProductViewModel
            {
                Category = category,
                Products = product
            };
            return View(viewModel);
        }


    }
}
