using ClosedBurger.Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClosedBurger.Client.Components.AdminPanel
{
    public class AdminCategory : ViewComponent
    {private readonly CloseBurgerDbContext _context;

        public AdminCategory(CloseBurgerDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var homeCategory = await _context.Category.ToListAsync();
            return View(homeCategory);

        }
    }
}
