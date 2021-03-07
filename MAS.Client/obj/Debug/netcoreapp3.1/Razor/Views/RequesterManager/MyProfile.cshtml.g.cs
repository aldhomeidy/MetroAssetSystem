#pragma checksum "C:\RepoGithub\MCC\FINALPROJECT\PROJECT\MetroAssetSystem\MAS.Client\Views\RequesterManager\MyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b39e70ebcf80c7867bcf4c75c322638261d3e34d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RequesterManager_MyProfile), @"mvc.1.0.view", @"/Views/RequesterManager/MyProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b39e70ebcf80c7867bcf4c75c322638261d3e34d", @"/Views/RequesterManager/MyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58438fb03bc46bda326dff31745fed6749c862ce", @"/Views/_ViewImports.cshtml")]
    public class Views_RequesterManager_MyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\RepoGithub\MCC\FINALPROJECT\PROJECT\MetroAssetSystem\MAS.Client\Views\RequesterManager\MyProfile.cshtml"
  
    Layout = "~/Views/Template/DashboardBase.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Menu", async() => {
                WriteLiteral(@"
    <div class=""nav"">
        <div class=""sb-sidenav-menu-heading"">Manager</div>
        <a class=""nav-link"" href=""https://localhost:44342/employee"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-home""></i></div>
            Dashboard
        </a>
        <a class=""nav-link"" href=""https://localhost:44342/manager/subordinate"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-users""></i></div>
            My Subordinate
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
<div class=""card mb-3"">
    <div class=""card-header bg-dark text-light"">
        <i class=""far fa-user-circle""></i> My Profile
    </div>
    <div class=""card-body"">
        <div class=""card-block mb-3"">
            <h6 class=""border-bottom border-secondary pb-2""><b>Employee's Data</b></h6>
            <div class=""row"">
                <div class=""col-sm-6"">
                    <p class=""m-b-10 f-w-600"">NIK</p>
                    <h6 class=""text-muted f-w-400"">719361</h6>
                </div>
                <div class=""col-sm-6"">
                    <p class=""m-b-10 f-w-600"">Department</p>
                    <h6 class=""text-muted f-w-400"">ADD 1</h6>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-sm-6"">
                    <p class=""m-b-10 f-w-600"">Manager</p>
                    <h6 class=""text-muted f-w-400"">Naufal Aji Wibowo</h6>
                </div>
            </div>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b39e70ebcf80c7867bcf4c75c322638261d3e34d5426", async() => {
                WriteLiteral(@"
            <h6 class=""border-bottom border-secondary pb-2""><b>Personal Data</b></h6>
            <div class=""row mb-2"">
                <div class=""form-group col"">
                    <label for=""firstName"">First Name</label>
                    <input type=""text"" class=""form-control"" placeholder=""First name"" id=""firstName""
                           name=""firstName"" autocomplete=""off"">
                </div>
                <div class=""form-group col"">
                    <label for=""lastName"">Last Name</label>
                    <input type=""text"" class=""form-control"" placeholder=""Last name"" id=""lastName""
                           name=""lastName"" autocomplete=""off"">
                </div>
            </div>
            <div class=""row mb-2"">
                <div class=""form-group col"">
                    <label for=""username"">Username</label>
                    <input type=""text"" class=""form-control"" placeholder=""Username"" id=""username""
                           name=""username"" aut");
                WriteLiteral(@"ocomplete=""off"">
                </div>
                <div class=""form-group col"">
                    <label for=""email"">Email</label>
                    <input type=""email"" class=""form-control"" placeholder=""Email"" id=""email""
                           name=""email"" autocomplete=""off"">
                </div>
            </div>
            <div class=""row mb-2"">
                <div class=""form-group col"">
                    <label for=""birthday"">Birthday</label>
                    <input type=""text"" class=""form-control"" placeholder=""Birthday"" id=""birthday""
                           name=""birthday"" autocomplete=""off"">
                </div>
                <div class=""form-group col"">
                    <label for=""phone"">Phone Number</label>
                    <div class=""input-group"">
                        <span class=""input-group-text"">08</span>
                        <input type=""text"" class=""form-control"" placeholder=""Phone Number""
                               id=""phone"" na");
                WriteLiteral(@"me=""phone"" autocomplete=""off"">
                    </div>
                </div>
            </div>
            <fieldset class=""form-group row err-custom"">
                <legend class=""col-form-label col-sm-2 float-sm-left pt-0"">Gender</legend>
                <div class=""col-sm-10"">
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""gender"" id=""gender1""
                               value=""0"">
                        <label class=""form-check-label"" for=""gender1"">
                            Male
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""radio"" name=""gender"" id=""gender2""
                               value=""1"">
                        <label class=""form-check-label"" for=""gender2"">
                            Female
                        </label>
                    </div>
                </d");
                WriteLiteral("iv>\r\n            </fieldset>\r\n            <button class=\"btn btn-dark float-right\"><i class=\"far fa-save\"></i> Save</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<div class=""row mb-5"">
    <div class=""col-lg-5 col-md-6"">
        <div class=""card"">
            <div class=""card-header bg-dark text-light"">
                <i class=""fas fa-key""></i> Change Password
            </div>
            <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b39e70ebcf80c7867bcf4c75c322638261d3e34d10436", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""currentPassword"">Current Password</label>
                        <input type=""password"" class=""form-control"" id=""currentPassword""
                               name=""currentPassword"" placeholder=""Input your current password"">
                    </div>
                    <div class=""form-group"">
                        <label for=""newPassword"">New Password</label>
                        <input type=""password"" class=""form-control"" id=""newPassword""
                               placeholder=""Input your new password"">
                    </div>
                    <div class=""form-group"">
                        <label for=""confirmPassword"">Confirm Password</label>
                        <input type=""password"" class=""form-control"" id=""confirmPassword""
                               placeholder=""Retype your new password"">
                    </div>
                    <button type=""submit"" class=""btn btn-dark w-");
                WriteLiteral("100\">Save</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
