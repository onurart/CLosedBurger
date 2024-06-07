using System.ComponentModel.DataAnnotations.Schema;

namespace ClosedBurger.Client.Models
{
    public class Product : Entity
    {
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int CategoryId { get; set; }
        public string? PhotoPath { get; set; }
        public Category? Category { get; set; }
    }
}
