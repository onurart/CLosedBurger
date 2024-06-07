using Microsoft.AspNetCore.Mvc.Rendering;

namespace ClosedBurger.Client.Areas.Admin.Models.ViewModel
{
    public class ProductViewModel
    {
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? PhotoPath { get; set; }
        public bool? IsActive { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
    }
}
