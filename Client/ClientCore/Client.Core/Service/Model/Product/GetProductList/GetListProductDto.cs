using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Core.Service.Model.Product.GetProductList
{
    public class GetListProductDto : Entity
    {

        public string Id { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
    }
}
