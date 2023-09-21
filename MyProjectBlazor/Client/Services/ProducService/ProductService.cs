using MyProjectBlazor.Shared;
using System.Net.Http.Json;

namespace MyProjectBlazor.Client.Services.ProducService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public async Task<ServiceResponse<Product>> GetProductById(int productId)
        {
            try
            {
                var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


        public async Task GetProducts()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            if (result is not null && result.Data is not null) Products = result.Data;
        }
    }
}
