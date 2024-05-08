using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosedBurger.Domain.Dtos
{
    public class ProductListDto
    {
        public string? Id { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? IsActive { get; set; }
    }
}
