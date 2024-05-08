using ClosedBurger.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosedBurger.Domain.CompanyEntities
{
    public class Product : Entity
    {


        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public string? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
