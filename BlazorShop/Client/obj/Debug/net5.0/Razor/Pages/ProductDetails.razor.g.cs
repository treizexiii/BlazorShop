#pragma checksum "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5a3bdd71f08b1dcae4e03569c43bea320803344"
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
using BlazorShop.Client.Services.StatsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\_Imports.razor"
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
            __builder.AddAttribute(1, "class", "viewscount");
            __builder.AddAttribute(2, "b-lzryr83p8h");
            __builder.AddMarkupContent(3, "<i class=\"oi oi-eye\" b-lzryr83p8h></i> ");
            __builder.AddContent(4, 
#nullable restore
#line 8 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                               product.Views.ToString("0##")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "media mb-3");
            __builder.AddAttribute(8, "b-lzryr83p8h");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "media-img-big-wrapper mr-2");
            __builder.AddAttribute(11, "b-lzryr83p8h");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "class", "media-img-big");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 12 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                         product.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "alt", 
#nullable restore
#line 12 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                              product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "b-lzryr83p8h");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "media-body");
            __builder.AddAttribute(20, "b-lzryr83p8h");
            __builder.OpenElement(21, "h2");
            __builder.AddAttribute(22, "class", "mb-0");
            __builder.AddAttribute(23, "b-lzryr83p8h");
            __builder.AddContent(24, 
#nullable restore
#line 15 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                          product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "p");
            __builder.AddAttribute(27, "b-lzryr83p8h");
            __builder.AddContent(28, 
#nullable restore
#line 16 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
            product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 18 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
         if (product.Variants != null && product.Variants.Count > 1)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "form-group");
            __builder.AddAttribute(31, "b-lzryr83p8h");
            __builder.OpenElement(32, "select");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                    currentEditionId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentEditionId = __value, currentEditionId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(36, "b-lzryr83p8h");
#nullable restore
#line 22 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                     foreach (var variant in product.Variants)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "option");
            __builder.AddAttribute(38, "value", 
#nullable restore
#line 24 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                        variant.EditionId

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "b-lzryr83p8h");
            __builder.AddContent(40, 
#nullable restore
#line 24 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                            variant.Edition.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 25 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.AddMarkupContent(42, "<a href=\"E:\\Developpement\\projet C#\\BlazorShop\\BlazorShop\\Client\\Program.cs\" b-lzryr83p8h>E:\\Developpement\\projet C#\\BlazorShop\\BlazorShop\\Client\\Program.cs</a>");
#nullable restore
#line 29 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
         if (GetSelectedVariant() != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
             if (GetSelectedVariant().OriginalPrice > GetSelectedVariant().Price)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "h6");
            __builder.AddAttribute(44, "class", "text-muted orignial-price");
            __builder.AddAttribute(45, "b-lzryr83p8h");
            __builder.AddContent(46, "$");
            __builder.AddContent(47, 
#nullable restore
#line 35 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                        GetSelectedVariant().OriginalPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 36 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "h4");
            __builder.AddAttribute(49, "class", "price");
            __builder.AddAttribute(50, "b-lzryr83p8h");
            __builder.AddContent(51, "$");
            __builder.AddContent(52, 
#nullable restore
#line 37 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                GetSelectedVariant().Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 38 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "class", "btn btn-primary");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                  AddToCart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "b-lzryr83p8h");
            __builder.AddMarkupContent(57, "<i class=\"oi oi-cart\" b-lzryr83p8h></i>&nbsp;&nbsp;&nbsp;Add to Cart");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "E:\Developpement\projet C#\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
       
    [Parameter]
    public int Id { get; set; }
    private Product product = new Product();
    private int currentEditionId = 1;

    protected override async Task OnInitializedAsync()
    {
        product = await ProductService.GetProduct(Id);
        if (product.Variants.Count > 0)
        {
            currentEditionId = product.Variants[0].EditionId;
        }
    }

    private ProductVariant GetSelectedVariant()
    {
        var variant = product.Variants.FirstOrDefault(v => v.EditionId == currentEditionId);
        return variant;
    }

    private async Task AddToCart()
    {
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
