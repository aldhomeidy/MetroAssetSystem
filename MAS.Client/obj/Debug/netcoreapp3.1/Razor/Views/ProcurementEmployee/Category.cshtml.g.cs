#pragma checksum "C:\Users\Edward\source\05.Git\Final Project 2\MetroAssetSystem\MAS.Client\Views\ProcurementEmployee\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00d41d206626e633150271f9b9f4ab6c68ee6e50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProcurementEmployee_Category), @"mvc.1.0.view", @"/Views/ProcurementEmployee/Category.cshtml")]
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
#line 1 "C:\Users\Edward\source\05.Git\Final Project 2\MetroAssetSystem\MAS.Client\Views\_ViewImports.cshtml"
using MAS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Edward\source\05.Git\Final Project 2\MetroAssetSystem\MAS.Client\Views\_ViewImports.cshtml"
using MAS.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00d41d206626e633150271f9b9f4ab6c68ee6e50", @"/Views/ProcurementEmployee/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58438fb03bc46bda326dff31745fed6749c862ce", @"/Views/_ViewImports.cshtml")]
    public class Views_ProcurementEmployee_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Metro_Asset_System.Models.Request>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Edward\source\05.Git\Final Project 2\MetroAssetSystem\MAS.Client\Views\ProcurementEmployee\Category.cshtml"
  
    Layout = "~/Views/Template/DashboardBase.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Menu", async() => {
                WriteLiteral(@"
    <div class=""nav"">
        <div class=""sb-sidenav-menu-heading"">Procurement Employee</div>
        <a class=""nav-link"" href=""/procurementemployee"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-home""></i></div>
            Dashboard
        </a>
        <a class=""nav-link"" href=""/procurementemployee/assets"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-book""></i></div>
            Assets
        </a>
        <a class=""nav-link"" href=""/procurementemployee/department"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-book""></i></div>
            Department
        </a>
        <a class=""nav-link"" href=""/procurementemployee/request"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-book""></i></div>
            Request
        </a>
        <a class=""nav-link"" href=""/procurementemployee/invoice"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-book""></i></div>
            Invoice
        </a>
    </div>
");
            }
            );
            WriteLiteral("\r\n<div class=\"row\">\r\n");
            WriteLiteral("</div>\r\n<div class=\"row\">\r\n    <div class=\"col-xl-9 col-lg-7\">\r\n        <div class=\"card shadow mb-4\">\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    \r\n    \r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Metro_Asset_System.Models.Request>> Html { get; private set; }
    }
}
#pragma warning restore 1591
