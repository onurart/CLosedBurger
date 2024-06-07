using Client.Core.Service.Model.Product.GetProductList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Core.Service.Interface
{
    public interface IProductServices
    {
        Task<List<GetAllProductListQueryResponse>> GetListProductses(string actor);
    }
}
