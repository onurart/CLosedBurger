using Client.Core.Service.Interface;
using Client.Core.Service.Model.Product.GetProductList;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Core.Service.Repositories
{
    public class ProductService : IProductServices
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        public async Task<List<GetAllProductListQueryResponse>> GetListProductses(string actor)

        {
            var httpClient = _httpClientFactory.CreateClient();
            var apiSettings = _configuration.GetSection("ApiSettings");
            var baseUrl = apiSettings["BaseUrl"]; // BaseUrl'i alın
            var apiUrl = $"{baseUrl}/Product/GetAllProduct/{actor}";
            var resultList = new List<GetAllProductListQueryResponse>();
            var response = await httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                var jsonContent = await response.Content.ReadAsStringAsync();
                var responseProduct = Newtonsoft.Json.JsonConvert.DeserializeObject<GetAllProductListQueryResponse>(jsonContent);
                var result = new GetAllProductListQueryResponse(responseProduct.Data);
                resultList.Add(result);
            }
            return resultList;
        }
    }
}
