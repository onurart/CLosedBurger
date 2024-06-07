using ClosedBurger.Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClosedBurger.Client.Components.AdminPanel
{
    public class AdminProduct :  ViewComponent
    {
        private readonly CloseBurgerDbContext _db;
        public AdminProduct()
        {
            _db = new CloseBurgerDbContext();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var product = await _db.Product.Include(p => p.Category).ToListAsync();

            return View(product);
        }
    }
}
