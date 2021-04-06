using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorShop.Shared;

namespace BlazorShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _htpp;
        public event Action OnChange;

        public List<Product> Products { get; set; } = new List<Product>();

        public ProductService(HttpClient http)
        {
            _htpp = http;
        }

        public async Task LoadProducts(string categoryUrl = null)
        {
            if (categoryUrl == null)
            {
                Products = await _htpp.GetFromJsonAsync<List<Product>>($"api/Product/");
            }
            else
            {
                Products = await _htpp.GetFromJsonAsync<List<Product>>($"api/Product/Category/{categoryUrl}");
            }
            OnChange.Invoke();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _htpp.GetFromJsonAsync<Product>($"api/Product/{id}");
        }
    }
}