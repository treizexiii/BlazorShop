using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShop.Shared;

namespace BlazorShop.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategoryByUrl(string categoryurl);
    }
}