using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShop.Shared;

namespace BlazorShop.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action OnChange;
        List<Product> Products {get; set;}
        Task LoadProducts(string categoryUrl = null);
        Task<Product> GetProduct(int id);
    }
}