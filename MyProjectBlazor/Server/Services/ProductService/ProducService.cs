using Microsoft.EntityFrameworkCore;
using MyProjectBlazor.Server.Data;
using MyProjectBlazor.Shared;

namespace MyProjectBlazor.Server.Services.ProductService
{
    public class ProducService : IProductService
    {
        private readonly DataContext _context;

        public ProducService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Product>> GetProductByIdAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products.FindAsync(productId);
            if(product == null)
            {
                response.Success= false;
                response.Message = "Sorry , but this product doesnt exist.";
            }
            else
            {
                response.Data = product;
            }
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>()
            {
                Data = await _context.Products.ToListAsync()
            };

            return response;
        }
    }
}
