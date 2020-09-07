using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace TeaMaki.Ui.Components.Menu
{
    public interface IProductService
    {
        Task<ProductResponse[]> GetProducts();
    }

    public class ProductService : IProductService
    {
        private HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task<ProductResponse[]> GetProducts()
        {
            return await _http.GetFromJsonAsync<ProductResponse[]>("sample-data/products.json");
        }
    }
}