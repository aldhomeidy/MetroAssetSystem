#pragma checksum "C:\RepoGithub\MCC\FINALPROJECT\PROJECT\MetroAssetSystem\MAS.Client\Views\Requester\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d3bded7c2d881f721b34535d898d7b5e1cea894"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Requester_Index), @"mvc.1.0.view", @"/Views/Requester/Index.cshtml")]
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
#line 1 "C:\RepoGithub\MCC\FINALPROJECT\PROJECT\MetroAssetSystem\MAS.Client\Views\_ViewImports.cshtml"
using MAS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\RepoGithub\MCC\FINALPROJECT\PROJECT\MetroAssetSystem\MAS.Client\Views\_ViewImports.cshtml"
using MAS.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d3bded7c2d881f721b34535d898d7b5e1cea894", @"/Views/Requester/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58438fb03bc46bda326dff31745fed6749c862ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Requester_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\RepoGithub\MCC\FINALPROJECT\PROJECT\MetroAssetSystem\MAS.Client\Views\Requester\Index.cshtml"
  
    Layout = "~/Views/Template/DashboardBase.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Menu", async() => {
                WriteLiteral(@"
    <div class=""nav"">
        <div class=""sb-sidenav-menu-heading"">Employee</div>
        <a class=""nav-link"" href=""https://localhost:44342/employee"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-home""></i></div>
            Dashboard
        </a>
        <a class=""nav-link"" href=""https://localhost:44342/employee/request"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-book""></i></div>
            Request
        </a>
        <a class=""nav-link"" href=""https://localhost:44342/employee/invoice"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-file-invoice""></i></div>
            Invoice
        </a>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
