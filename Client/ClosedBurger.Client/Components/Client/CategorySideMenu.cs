using ClosedBurger.Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClosedBurger.Client.Components.Client
{
    public class CategorySideMenu : ViewComponent
    {
        private readonly CloseBurgerDbContext _context;

        public CategorySideMenu(CloseBurgerDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.Category.ToListAsync());


        }
    }
}
