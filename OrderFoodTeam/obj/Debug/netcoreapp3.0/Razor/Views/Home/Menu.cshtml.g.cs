#pragma checksum "C:\Users\Olha Melnyk\Desktop\OrderFoodTeam\OrderFoodTeam\Views\Home\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3045576a0129f53354af0a5572de6e9df0f5c43d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Menu), @"mvc.1.0.view", @"/Views/Home/Menu.cshtml")]
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
#line 1 "C:\Users\Olha Melnyk\Desktop\OrderFoodTeam\OrderFoodTeam\Views\_ViewImports.cshtml"
using OrderFoodTeam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Olha Melnyk\Desktop\OrderFoodTeam\OrderFoodTeam\Views\_ViewImports.cshtml"
using OrderFoodTeam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3045576a0129f53354af0a5572de6e9df0f5c43d", @"/Views/Home/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb05090d53db47de51fa75fb567f9eedca215c72", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrderFoodTeam.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Olha Melnyk\Desktop\OrderFoodTeam\OrderFoodTeam\Views\Home\Menu.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Menu";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"menu\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <h2>");
#nullable restore
#line 10 "C:\Users\Olha Melnyk\Desktop\OrderFoodTeam\OrderFoodTeam\Views\Home\Menu.cshtml"
               Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <hr>\r\n                <div class=\"itemMenu\">\r\n");
#nullable restore
#line 13 "C:\Users\Olha Melnyk\Desktop\OrderFoodTeam\OrderFoodTeam\Views\Home\Menu.cshtml"
                     foreach (var item in Model)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""row"">
                            <div class=""col-md-4"">
                               
                            </div>
                            <div class=""col-md-8 boxProduct"">
                                <h5>");
#nullable restore
#line 21 "C:\Users\Olha Melnyk\Desktop\OrderFoodTeam\OrderFoodTeam\Views\Home\Menu.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 23 "C:\Users\Olha Melnyk\Desktop\OrderFoodTeam\OrderFoodTeam\Views\Home\Menu.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p class=\"price\">Price : <span>");
#nullable restore
#line 25 "C:\Users\Olha Melnyk\Desktop\OrderFoodTeam\OrderFoodTeam\Views\Home\Menu.cshtml"
                                                          Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 28 "C:\Users\Olha Melnyk\Desktop\OrderFoodTeam\OrderFoodTeam\Views\Home\Menu.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <nav aria-label=""Page navigation example"">
                    <ul class=""pagination"">
                        <li class=""page-item"">
                            <a class=""page-link"" href=""#"" aria-label=""Previous"">
                                <span aria-hidden=""true"">&laquo;</span>
                                <span class=""sr-only"">Previous</span>
                            </a>
                        </li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                        <li class=""page-item"">
                            <a class=""page-link"" href=""#"" aria-label=""Next"">
                                <span aria-hidden=""true"">&raquo;</span>
                                <span class=""sr-only"">Next</span>
                          ");
            WriteLiteral("  </a>\r\n                        </li>\r\n                    </ul>\r\n                </nav>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrderFoodTeam.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
