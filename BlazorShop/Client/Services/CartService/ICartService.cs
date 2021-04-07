using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using BlazorShop.Shared;

namespace BlazorShop.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(ProductVariant productVariant);
        Task<List<CartItem>> GetCartItems();
        Task DeleteItem(CartItem item);
    }
}