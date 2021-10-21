#pragma checksum "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "807a02c3d4eb178623f969ecc0618607f755a671"
// <auto-generated/>
#pragma warning disable 1591
namespace SportsStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\Products.razor"
using SportsStore.Repository;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Products : OwningComponentBase<SportsStore.Repository.IStoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "<thead><tr><th>ID</th><th>Name</th>\r\n        <th>Category</th><th>Price</th><td></td></tr></thead>\r\n    ");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 14 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\Products.razor"
         if (ProductData?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\Products.razor"
             foreach (Product p in ProductData)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 19 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\Products.razor"
                         p.ProductID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                    ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 20 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\Products.razor"
                         p.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 21 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\Products.razor"
                         p.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 22 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\Products.razor"
                         p.Price.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(18);
            __builder.AddAttribute(19, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(20, "href", 
#nullable restore
#line 24 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\Products.razor"
                                                                    GetDetailsUrl(p.ProductID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(22, "Details");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 25 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\Products.razor"
                                                                       GetEditUrl(p.ProductID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(28, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\Products.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\Products.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "<tr><td colspan=\"5\" class=\"text-center\">No products</td></tr>");
#nullable restore
#line 35 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\Products.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "href", "/admin/products/create");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(35, "Create");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Admin\Products.razor"
 
    public IStoreRepository Repository => Service;
    public IEnumerable<Product> ProductData { get; set; }

    protected async override Task OnInitializedAsync()
    {
        ProductData = await Repository.Products.ToListAsync();
    }

    public string GetDetailsUrl(long id) => $"/admin/products/details/{id}";
    public string GetEditUrl(long id) => $"/admin/products/edit/{id}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591