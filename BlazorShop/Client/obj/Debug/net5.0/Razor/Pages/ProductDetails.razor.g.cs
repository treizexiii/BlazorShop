#pragma checksum "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8923ad86d2dba0b248aa5335be41fd90c8306eb2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorShop.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{id:int}")]
    public partial class ProductDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "media");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "media-img-big-wrapper mr-2");
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "class", "media-img-big");
            __builder.AddAttribute(6, "src", 
#nullable restore
#line 9 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                         product.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "alt", 
#nullable restore
#line 9 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                              product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "media-body");
            __builder.OpenElement(11, "h2");
            __builder.AddAttribute(12, "class", "mb-0");
            __builder.AddContent(13, 
#nullable restore
#line 12 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                          product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "p");
            __builder.AddContent(16, 
#nullable restore
#line 13 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
            product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
         if (product.Variants != null && product.Variants.Count > 1)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-group");
            __builder.OpenElement(19, "select");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                    currentEditionId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentEditionId = __value, currentEditionId));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 19 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                     foreach (var variant in product.Variants)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", 
#nullable restore
#line 21 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                        variant.EditionId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, 
#nullable restore
#line 21 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                            variant.Edition.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 22 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
         if (GetSelectedVariant() != null) 
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
             if (GetSelectedVariant().OriginalPrice > GetSelectedVariant().Price) 
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "h6");
            __builder.AddAttribute(27, "class", "text-muted orignial-price");
            __builder.AddContent(28, "$");
            __builder.AddContent(29, 
#nullable restore
#line 31 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                        GetSelectedVariant().OriginalPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 32 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "h4");
            __builder.AddAttribute(31, "class", "price");
            __builder.AddContent(32, "$");
            __builder.AddContent(33, 
#nullable restore
#line 33 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                GetSelectedVariant().Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 34 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-primary");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                  AddToCart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "<i class=\"oi oi-cart\"></i>&nbsp;&nbsp;&nbsp;Add to Cart");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
       
    [Parameter]
    public int Id { get; set; }
    private Product product = new Product();
    private int currentEditionId = 1;

    protected override async Task OnInitializedAsync()
    {
        product = await ProductService.GetProduct(Id);
        if (product.Variants.Count > 0) {
            currentEditionId = product.Variants[0].EditionId;
        }
    }

    private ProductVariant GetSelectedVariant() {
        var variant = product.Variants.FirstOrDefault(v => v.EditionId == currentEditionId);
        return variant;
    }

    private async Task AddToCart() {
        await CartService.AddToCart(GetSelectedVariant());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
