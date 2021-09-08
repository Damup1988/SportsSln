#pragma checksum "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c74c396b6e7522e3941ae05cbc029841f5d631ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SportsStore.Pages.Pages_Cart), @"mvc.1.0.razor-page", @"/Pages/Cart.cshtml")]
namespace SportsStore.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\_ViewImports.cshtml"
using SportsStore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c74c396b6e7522e3941ae05cbc029841f5d631ee", @"/Pages/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31ecb8b3b07237d3f996af6b2f6d118b9531b493", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Your cart</h2>
<table class=""table table-bordered table-striped"">
    <thead>
    <tr>
        <th>Quantity</th>
        <th>Item</th>
        <th class=""text-right"">Price</th>
        <th class=""text-right"">Subtotal</th>
    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 15 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Cart.cshtml"
     foreach (var line in Model.Cart.Lines)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"text-center\">");
#nullable restore
#line 18 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Cart.cshtml"
                               Write(line.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-left\">");
#nullable restore
#line 19 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Cart.cshtml"
                             Write(line.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-right\">");
#nullable restore
#line 20 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Cart.cshtml"
                              Write(line.Product.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-right\">\r\n                ");
#nullable restore
#line 22 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Cart.cshtml"
            Write((line.Quantity * line.Product.Price).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Cart.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n            <td class=\"text-right\">\r\n                ");
#nullable restore
#line 31 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Cart.cshtml"
           Write(Model.Cart.ComputeTotalValue().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n<div class=\"text-center\">\r\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1023, "\"", 1046, 1);
#nullable restore
#line 38 "D:\_ONEDRIVE\OneDrive\_Coding\_Projects\Freeman\SportsSln\SportsStore\Pages\Cart.cshtml"
WriteAttributeValue("", 1030, Model.ReturnUrl, 1030, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue shopping</a>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CartModel>)PageContext?.ViewData;
        public CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
