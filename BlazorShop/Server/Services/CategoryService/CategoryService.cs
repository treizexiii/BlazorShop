using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShop.Shared;
using BlazorShop.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByUrl(string categoryurl)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Url.ToLower().Equals(categoryurl.ToLower()));
        }
    }
}