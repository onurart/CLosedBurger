using ClosedBurger.Client.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
namespace ClosedBurger.Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly CloseBurgerDbContext _context;

        public ProductsController(CloseBurgerDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var closeBurgerDbContext = _context.Product.Include(p => p.Category);
            return View(await closeBurgerDbContext.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductName,ProductCode,Description,Price,CategoryId,IsActive")] Product product, IFormFile PhotoPath)
        {
            if (ModelState.IsValid)
            {
                if (PhotoPath != null && PhotoPath.Length > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(PhotoPath.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", fileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await PhotoPath.CopyToAsync(fileStream);
                    }

                    product.PhotoPath = "/uploads/" + fileName;
                }

                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name", product.CategoryId);
            return View(product);
        }
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var product = await _context.Product.FindAsync(id);
			if (product == null)
			{
				return NotFound();
			}
			ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name", product.CategoryId);
			return View(product);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("ProductName,ProductCode,Description,Price,CategoryId,IsActive,Id")] Product product, IFormFile PhotoPath)
		{
			if (id != product.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					if (PhotoPath != null && PhotoPath.Length > 0)
					{
						// Generate unique file name
						var fileName = Guid.NewGuid().ToString() + Path.GetExtension(PhotoPath.FileName);
						var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", fileName);

						// Save the file
						using (var fileStream = new FileStream(filePath, FileMode.Create))
						{
							await PhotoPath.CopyToAsync(fileStream);
						}

						// Update the PhotoPath
						product.PhotoPath = "/uploads/" + fileName;
					}

					_context.Update(product);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!ProductExists(product.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name", product.CategoryId);
			return View(product);
		}

	
		public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product != null)
            {
                _context.Product.Remove(product);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }
    }
}
