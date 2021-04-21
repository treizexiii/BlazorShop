using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Blazored.Toast.Services;
using BlazorShop.Client.Services.ProductService;
using BlazorShop.Shared;

namespace BlazorShop.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly IProductService _productService;

        public event Action OnChange;

        public CartService(ILocalStorageService localStorage, IToastService toastService, IProductService productService)
        {
            _localStorage = localStorage;
            _toastService = toastService;
            _productService = productService;
        }

        public async Task AddToCart(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            var sameItem = cart
                .Find(c => c.ProductId == item.ProductId && c.EditionId == item.EditionId);
            if (sameItem == null)
            {
                cart.Add(item);
            }
            else
            {
                sameItem.Quantity += item.Quantity;
            }

            await _localStorage.SetItemAsync("cart", cart);

            var product = await _productService.GetProduct(item.ProductId);
            _toastService.ShowSuccess(product.Title, "Added to cart :");

            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");

            if (cart == null)
            {
                return new List<CartItem>();
            }

            return cart;
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");

            if (cart == null)
            {
                return;
            }

            var cartItem = cart.Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);
            cart.Remove(cartItem);

            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        public async Task EmptyCard()
        {
            await _localStorage.RemoveItemAsync("cart");
            OnChange.Invoke();
        }
    }
}
