using System.Net;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShop.Server.Services.ProductService;
using BlazorShop.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts() {
            return Ok(await _productService.GetAllProducts());
        }

        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductByCategory(string categoryUrl) {
            return Ok(await _productService.GetProductsByCategory(categoryUrl));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id) {
            return Ok(await _productService.GetProduct(id));
        }
    }
}