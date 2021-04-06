using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BlazorShop.Shared;
using System.Threading.Tasks;
using BlazorShop.Server.Services.CategoryService;

namespace BlazorShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories() {
            return Ok(await _categoryService.GetCategories());
        }
    }
}