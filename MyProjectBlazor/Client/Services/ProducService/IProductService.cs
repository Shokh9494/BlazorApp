﻿using MyProjectBlazor.Shared;

namespace MyProjectBlazor.Client.Services.ProducService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        Task GetProducts();

    }
}
