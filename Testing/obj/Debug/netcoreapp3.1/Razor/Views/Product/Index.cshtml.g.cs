#pragma checksum "C:\Users\maure\Desktop\ASPNET\Testing\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "124d26625614eb630b420dfbd3230e1c3144f61f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\maure\Desktop\ASPNET\Testing\Views\_ViewImports.cshtml"
using Lash;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maure\Desktop\ASPNET\Testing\Views\_ViewImports.cshtml"
using Lash.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"124d26625614eb630b420dfbd3230e1c3144f61f", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd579a388b7c329d441485a39458fcd71a74bac6", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Products</h2>

<div style=""display: block"">
    <a href=""/Product/InsertProduct/"">Create a New Product</a>
</div>

<table class=""table"">
    <tr>
        <th>ID</th>
        <th>Name</th>
        <th>Price</th>
        <th>Category ID</th>
        <th>On Sale</th>
        <th>Stock Level</th>
    </tr>
    
");
#nullable restore
#line 19 "C:\Users\maure\Desktop\ASPNET\Testing\Views\Product\Index.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <tr>\r\n         <td><a");
            BeginWriteAttribute("href", " href=", 430, "", 475, 2);
            WriteAttributeValue("", 436, "/Product/ViewProduct/", 436, 21, true);
#nullable restore
#line 22 "C:\Users\maure\Desktop\ASPNET\Testing\Views\Product\Index.cshtml"
WriteAttributeValue("", 457, product.ProductID, 457, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "C:\Users\maure\Desktop\ASPNET\Testing\Views\Product\Index.cshtml"
                                                        Write(product.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n         <td>");
#nullable restore
#line 23 "C:\Users\maure\Desktop\ASPNET\Testing\Views\Product\Index.cshtml"
        Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 24 "C:\Users\maure\Desktop\ASPNET\Testing\Views\Product\Index.cshtml"
        Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 25 "C:\Users\maure\Desktop\ASPNET\Testing\Views\Product\Index.cshtml"
        Write(product.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 26 "C:\Users\maure\Desktop\ASPNET\Testing\Views\Product\Index.cshtml"
        Write(product.OnSale);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 27 "C:\Users\maure\Desktop\ASPNET\Testing\Views\Product\Index.cshtml"
        Write(product.StockLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n     </tr>\r\n");
#nullable restore
#line 29 "C:\Users\maure\Desktop\ASPNET\Testing\Views\Product\Index.cshtml"
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
