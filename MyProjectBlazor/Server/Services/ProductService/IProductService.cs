﻿using MyProjectBlazor.Shared;

namespace MyProjectBlazor.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();

        Task<ServiceResponse<Product>> GetProductByIdAsync(int productId);
    }
}
