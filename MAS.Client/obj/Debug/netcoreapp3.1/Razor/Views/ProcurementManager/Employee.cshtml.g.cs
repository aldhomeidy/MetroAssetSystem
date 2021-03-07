#pragma checksum "C:\RepoGithub\MCC\FINALPROJECT\PROJECT\MetroAssetSystem\MAS.Client\Views\ProcurementManager\Employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c7ec688de6093ca5bf37a0f23434e8c96ff1778"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProcurementManager_Employee), @"mvc.1.0.view", @"/Views/ProcurementManager/Employee.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c7ec688de6093ca5bf37a0f23434e8c96ff1778", @"/Views/ProcurementManager/Employee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58438fb03bc46bda326dff31745fed6749c862ce", @"/Views/_ViewImports.cshtml")]
    public class Views_ProcurementManager_Employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\RepoGithub\MCC\FINALPROJECT\PROJECT\MetroAssetSystem\MAS.Client\Views\ProcurementManager\Employee.cshtml"
  
    Layout = "~/Views/Template/DashboardBase.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/vendor/datatables/css/dataTables.bootstrap4.min.css\">\r\n");
            }
            );
            DefineSection("Menu", async() => {
                WriteLiteral(@"
    <div class=""nav"">
        <div class=""sb-sidenav-menu-heading"">Manager</div>
        <a class=""nav-link"" href=""https://localhost:44342/employee"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-home""></i></div>
            Dashboard
        </a>
        <a class=""nav-link"" href=""https://localhost:44342/manager/employee"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-users""></i></div>
            Employee
        </a>
        <a class=""nav-link"" href=""https://localhost:44342/manager/approval"">
            <div class=""sb-nav-link-icon""><i class=""far fa-edit""></i></div>
            Manage Request
        </a>
    </div>
");
            }
            );
            WriteLiteral(@"
<div class=""table-responsive mt-4"">
    <table class=""table table-bordered"" id=""myTable"" width=""100%"" cellspacing=""0"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Email</th>
                <th>Phone</th>
                <th>Total Requests</th>
            </tr>
        </thead>
        <tfoot>
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Email</th>
                <th>Phone</th>
                <th>Total Requests</th>
            </tr>
        </tfoot>
        <tbody>
        </tbody>
    </table>
</div>


");
            DefineSection("ScriptsLink", async() => {
                WriteLiteral("\r\n    <script src=\"/vendor/datatables/js/jquery.dataTables.min.js\"></script>\r\n    <script src=\"/vendor/datatables/js/dataTables.bootstrap4.min.js\"></script>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("ScriptsDocReady", async() => {
                WriteLiteral(@"    
   table = $('#myTable').DataTable({
            ""ajax"": {
                ""url"": ""https://localhost:44329/api/employee/data/requester"",
                ""datatype"": ""json"",
                ""dataSrc"": ""data""
            },
            ""columnDefs"": [
                {
                    ""targets"": [1,4],
                    ""searchable"": true,
                    ""orderable"": true,
                },
                {
                    ""targets"": [0,2,3],
                    ""searchable"": false,
                    ""orderable"": false
                }
            ],
            ""columns"": [
                {
                    ""data"": 'nik',
                    ""render"": function (data, type, row, meta) {
                        return '<a href=""https://localhost:44342/manager/details/'+data+'"">'+data+'</a>';
                    }
                },
                {                  
                    ""render"": function (data, type, row, meta) {
                       re");
                WriteLiteral(@"turn row.firstName + "" "" + row.lastName;
                    }
                },
                {
                    ""data"": 'email'                   
                },               
                {
                    ""data"": 'phone',
                },
                {
                    ""data"": 'request.length'         
                }
            ]
        });    
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
