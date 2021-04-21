using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using BlazorShop.Shared;

namespace BlazorShop.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(CartItem item);
        Task<List<CartItem>> GetCartItems();
        Task DeleteItem(CartItem item);
        Task EmptyCard();
    }
}