using System.Threading.Tasks;
using System.Collections.Generic;
using BlazorShop.Shared;

namespace BlazorShop.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories {get; set;}
        Task LoadCategories();
    }
}