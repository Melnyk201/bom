#pragma checksum "D:\4kurs\Нова папка\OrderFoodTeam\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77a5f85ff4397bf03f738f494a07c7639dd30590"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\4kurs\Нова папка\OrderFoodTeam\Views\_ViewImports.cshtml"
using OrderFoodTeam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\4kurs\Нова папка\OrderFoodTeam\Views\_ViewImports.cshtml"
using OrderFoodTeam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77a5f85ff4397bf03f738f494a07c7639dd30590", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb05090d53db47de51fa75fb567f9eedca215c72", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderFoodTeam.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\4kurs\Нова папка\OrderFoodTeam\Views\Home\Index.cshtml"
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\4kurs\Нова папка\OrderFoodTeam\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""probootstrap-section probootstrap-bg-white"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 text-center probootstrap-animate"">
                <div class=""probootstrap-heading dark"">
                    <h1 class=""primary-heading"">Discover</h1>
                    <h3 class=""secondary-heading"">Our Store</h3>
                    <span class=""seperator"">* * *</span>
                </div>
                <p>Voluptatibus quaerat laboriosam fugit non Ut consequatur animi est molestiae enim a voluptate totam natus modi debitis dicta impedit voluptatum quod sapiente illo saepe explicabo quisquam perferendis labore et illum suscipit</p>
                <p><a href=""#"" class=""probootstrap-custom-link"">About Us</a></p>
            </div>
            <div class=""col-md-6 col-md-push-1 probootstrap-animate"">
                <p><img src=""/img/pablo-merchan-montes-Orz90t6o0e4-unsplash.jpg"" alt=""Free Bootstrap Template by ProBootstrap.com"" class=""img-res");
            WriteLiteral(@"ponsive""></p>
            </div>
        </div>
        <!-- END row -->
    </div>
</section>

<

<section class=""probootstrap-section-bg overlay"" style=""background-image: url(/img/hero_bg_4.jpg);"" data-stellar-background-ratio=""0.5"" data-section=""menu"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 text-center probootstrap-animate"">
                <div class=""probootstrap-heading"">
                    <h2 class=""primary-heading"">Discover</h2>
                    <h3 class=""secondary-heading"">Our Menu</h3>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""probootstrap-section probootstrap-bg-white"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""menus row"">
");
#nullable restore
#line 50 "D:\4kurs\Нова папка\OrderFoodTeam\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"col-md-6\">\r\n                            <figure class=\"image\"><img");
            BeginWriteAttribute("src", " src=\"", 2195, "\"", 2221, 2);
            WriteAttributeValue("", 2201, "/img/", 2201, 5, true);
#nullable restore
#line 53 "D:\4kurs\Нова папка\OrderFoodTeam\Views\Home\Index.cshtml"
WriteAttributeValue("", 2206, item.Image.Url, 2206, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Free Bootstrap Template by ProBootstrap.com\"></figure>\r\n                            <div class=\"text\">\r\n                                <span class=\"price\">");
#nullable restore
#line 55 "D:\4kurs\Нова папка\OrderFoodTeam\Views\Home\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <h3>");
#nullable restore
#line 56 "D:\4kurs\Нова папка\OrderFoodTeam\Views\Home\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>");
#nullable restore
#line 57 "D:\4kurs\Нова папка\OrderFoodTeam\Views\Home\Index.cshtml"
                              Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 60 "D:\4kurs\Нова папка\OrderFoodTeam\Views\Home\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderFoodTeam.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
