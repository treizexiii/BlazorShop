using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShop.Shared;
using BlazorShop.Server.Services.CategoryService;
using BlazorShop.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _context;

        public ProductService(ICategoryService categoryService, DataContext context)
        {
            _context = context;
            _categoryService = categoryService;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _context.Products.Where(p => p.CategoryId == category.Id).ToListAsync();
        }
    }
}
