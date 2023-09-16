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
