#pragma checksum "C:\Users\Edward\source\05.Git\Final Project 2\MetroAssetSystem\MAS.Client\Views\ProcurementEmployee\Assets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f6a59afce9957565b466982fa6ccb2ebdcae442"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProcurementEmployee_Assets), @"mvc.1.0.view", @"/Views/ProcurementEmployee/Assets.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f6a59afce9957565b466982fa6ccb2ebdcae442", @"/Views/ProcurementEmployee/Assets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58438fb03bc46bda326dff31745fed6749c862ce", @"/Views/_ViewImports.cshtml")]
    public class Views_ProcurementEmployee_Assets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Metro_Asset_System.Models.Request>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("commentForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Edward\source\05.Git\Final Project 2\MetroAssetSystem\MAS.Client\Views\ProcurementEmployee\Assets.cshtml"
  
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
        <a class=""nav-link"" href=""/procurementemployee/category"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-book""></i></div>
            Category
        </a>
        <a class=""nav-link"" href=""/procurementemployee/invoice"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-book""></i></div>
            Invoice
        </a>
    </div>
");
            }
            );
            WriteLiteral(@"
<a href=""javascript:void(0)"" class=""btn bg-transparent text-success"" data-toggle=""modal"" data-target=""#addModal""><i class=""fas fa-plus""></i></a>

<div class=""modal fade"" id=""addModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""addModalLabel"">Add Department</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f6a59afce9957565b466982fa6ccb2ebdcae4426963", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""form-group"" hidden>
                            <label for=""id"" class=""col-form-label"">Id</label>
                            <input type=""text"" class=""form-control"" id=""id"" name=""id"">
                        </div>
                        <div class=""form-group col-sm-12"">
                            <label for=""message-text"" class=""col-form-label"">Name</label>
                            <input type=""text"" class=""form-control"" id=""name"" name=""name"" required>
                        </div>
                        <div class=""form-group col-sm-12"">
                            <label for=""message-text"" class=""col-form-label"">Category</label>
                            <input type=""text"" class=""form-control"" id=""categoryId"" name=""categoryId"" required>
                        </div>
                        <div class=""form-group col-sm-6"">
                            <label for=""message-text"" class=""col-form-label"">Low Pin");
                WriteLiteral(@"alty</label>
                            <input type=""text"" class=""form-control"" id=""lowPinalty"" name=""lowPinalty"" required>
                        </div>
                        <div class=""form-group col-sm-6"">
                            <label for=""message-text"" class=""col-form-label"">High Pinalty</label>
                            <input type=""text"" class=""form-control"" id=""highPinalty"" name=""highPinalty"" required>
                        </div>
                        <div class=""form-group col-sm-6"">
                            <label for=""message-text"" class=""col-form-label"">Middle Pinalty</label>
                            <input type=""text"" class=""form-control"" id=""middlePinalty"" name=""middlePinalty"" required>
                        </div>
                        <div class=""form-group col-sm-6"">
                            <label for=""message-text"" class=""col-form-label"">Lost Pinalty</label>
                            <input type=""text"" class=""form-control"" id=""lostPinalty"" name=""");
                WriteLiteral("lostPinalty\" required>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" id=""buttonsubmit"" onclick=""SubmitAsset();"">Submit</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""updateModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""editModalLabel"">Edit Asset</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f6a59afce9957565b466982fa6ccb2ebdcae44211464", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""form-group"" hidden>
                            <label for=""id"" class=""col-form-label"">Id</label>
                            <input type=""text"" class=""form-control"" id=""idUpdate"" name=""idUpdate"">
                        </div>
                        <div class=""form-group col-sm-12"">
                            <label for=""message-text"" class=""col-form-label"">Name</label>
                            <input type=""text"" class=""form-control"" id=""nameUpdate"" name=""nameUpdate"" required>
                        </div>
                        <div class=""form-group col-sm-6"">
                            <label for=""message-text"" class=""col-form-label"">Loan Status</label>
                            <select id=""loanStatus"" name=""loanStatus"" class=""form-control"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f6a59afce9957565b466982fa6ccb2ebdcae44212649", async() => {
                    WriteLiteral("Available");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f6a59afce9957565b466982fa6ccb2ebdcae44213908", async() => {
                    WriteLiteral("Unavailable");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                        <div class=""form-group col-sm-6"">
                            <label for=""message-text"" class=""col-form-label"">Asset Status</label>
                            <select id=""assetStatus"" name=""assetStatus"" class=""form-control"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f6a59afce9957565b466982fa6ccb2ebdcae44215504", async() => {
                    WriteLiteral("Fine");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f6a59afce9957565b466982fa6ccb2ebdcae44216758", async() => {
                    WriteLiteral("Problem");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f6a59afce9957565b466982fa6ccb2ebdcae44218015", async() => {
                    WriteLiteral("Lost");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                        <div class=""form-group col-sm-6"">
                            <label for=""message-text"" class=""col-form-label"">Low Pinalty</label>
                            <input type=""text"" class=""form-control"" id=""lowPinaltyUpdate"" name=""lowPinaltyUpdate"" required>
                        </div>
                        <div class=""form-group col-sm-6"">
                            <label for=""message-text"" class=""col-form-label"">High Pinalty</label>
                            <input type=""text"" class=""form-control"" id=""highPinaltyUpdate"" name=""highPinaltyUpdate"" required>
                        </div>
                        <div class=""form-group col-sm-6"">
                            <label for=""message-text"" class=""col-form-label"">Middle Pinalty</label>
                            <input type=""text"" class=""form-control"" id=""middlePinaltyUpdate"" name=""middlePinaltyUpdate"" required>
                        </div");
                WriteLiteral(@">
                        <div class=""form-group col-sm-6"">
                            <label for=""message-text"" class=""col-form-label"">Lost Pinalty</label>
                            <input type=""text"" class=""form-control"" id=""lostPinaltyUpdate"" name=""lostPinaltyUpdate"" required>
                        </div>

                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" id=""buttonsubmit"" onclick=""Update();"">Update</button>
            </div>
        </div>
    </div>
</div>


<div class=""container-fluid mt-5"">
    <table id=""mytables"" class=""table table-striped table-bordered"" style=""width:100%"">
        <thead>
            <tr>
                <th>No.</th>
                <th>ID</th>
                <th>Name</th>
                <th>Asset Status</th>
                <th>Loan Status</th>
                <th>Input Date</th>
                <th>Low Pinalty</th>
                <th>Medium Pinalty</th>
                <th>High Pinalty</th>
                <th>Lost Pinalty</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody></tbody>
        <tfoot>
            <tr>
                <th>No.</th>
                <th>ID</th>
                <th>Name</th>
                <th>Asset Status</th>
     ");
            WriteLiteral(@"           <th>Loan Status</th>
                <th>Input Date</th>
                <th>Low Pinalty</th>
                <th>Medium Pinalty</th>
                <th>High Pinalty</th>
                <th>Lost Pinalty</th>
                <th>Action</th>
            </tr>
        </tfoot>
    </table>
</div>

<div class=""row"">
</div>
<div class=""row"">
    <div class=""col-xl-9 col-lg-7"">
        <div class=""card shadow mb-4"">
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    
        $(document).ready(function () {
            table = $(""#mytables"").DataTable({
                ""ajax"": {
                    ""url"": ""https://localhost:44329/api/Asset"",
                    ""datatype"": ""json"",
                    ""dataSrc"": ""data""
                },
                ""columnDefs"": [
                    {
                        ""targets"": [1],
                        ""visible"": false
                    },
                    {
                        ""targets"": [0, 2],
                        ""searchable"": true
                    },
                    {
                        ""targets"": [10],
                        ""searchable"": false,
                        ""orderable"": false
                    }
                ],
                ""columns"": [
                    {
                        ""data"": null,
                        ""render"": function (data, type, row, meta) {
                            return meta.row + meta.settings._iDisplayStart + ");
                WriteLiteral(@"1;
                        }
                    },
                    {
                        ""data"": ""id""
                    },
                    {
                        ""data"": ""name""
                    },
                    {
                        ""data"": ""assetStatus"",
                        ""render"" : function(assetStatus){
                            if (assetStatus == 0) {
                                return ""Fine"";
                            } else if (assetStatus == 1) {
                                return ""Problem"";
                            } else {
                                return ""Lost"";
                            }
                        }
                    },
                    {
                        ""data"": ""loanStatus"",
                        ""render"" : function(loanStatus){
                            if (loanStatus == 0) {
                                return ""Available"";
                            } else {
                ");
                WriteLiteral(@"                return ""Unavailable"";
                            } 
                        }
                    },
                    {
                        ""data"": ""inputDate""
                    },
                    {
                        ""data"": ""pinalty.lowPinalty""
                    },
                    {
                        ""data"": ""pinalty.middlePinalty""
                    },
                    {
                        ""data"": ""pinalty.highPinalty""
                    },
                    {
                        ""data"": ""pinalty.lostPinalty""
                    },
                    {
                        ""render"": function (data, type, row, meta) {
                            return '<a href=""javascript:void(0)"" class=""far fa-edit table-action text-dark"" data-toggle=""tooltip"" data-placement=""top"" title=""Edit"" onclick=""return GetAsset(' + row['id'] + ')""></a>' +
                                '<a href=""javascript:void(0)"" class=""fa fa-trash table-act");
                WriteLiteral(@"ion text-danger"" data-toggle=""tooltip"" data-placement=""top"" title=""Delete"" onclick=""return Delete(' + row['id'] + ')""></a>'
                        }
                    }
                ]
            });
        });


        function SubmitAsset() {
            debugger;
            console.log(""ok"");
            var Asset = new Object();
            Asset.name = $('#name').val();
            Asset.categoryId = $('#categoryId').val();
            Asset.lowPinalty = $('#lowPinalty').val();
            Asset.middlePinalty = $('#middlePinalty').val();
            Asset.highPinalty = $('#highPinalty').val();
            Asset.lostPinalty = $('#lostPinalty').val();
                $.ajax({
                    url: '/ProcurementEmployee/SubmitAsset',
                    type: ""POST"",
                    data: Asset
                }).done((result) => {
                    if (result == 200) {
                        swal('Success', 'Add Asset Success', 'success');
                       ");
                WriteLiteral(@" $('#addModal').modal('hide');
                        $(""#name"").val(null);
                        $(""#categoryId"").val(null);
                        $(""#lowPinalty"").val(null);
                        $(""#middlePinalty"").val(null);
                        $(""#highPinalty"").val(null);
                        $(""#lostPinalty"").val(null);
                        table.ajax.reload();
                    }
                    else {
                        swal('Error', 'Something Went Wrong', 'error');
                    }
                }).fail((error) => {
                    console.log(error)
                });
        }


        function GetAsset(id) {
            debugger;
                $.ajax({
                url: '/ProcurementEmployee/Get',
                data: { id: id }
            }).done((result) => {
                console.log(result);
                var obj = JSON.parse(result);
                $(""#updateModal"").modal(""show"");
                $(""#idUpdate"").v");
                WriteLiteral(@"al(obj.data.id);
                $(""#nameUpdate"").val(obj.data.name);
                $(""#assetStatus"").val(obj.data.assetStatus);
                $(""#loanStatus"").val(obj.data.loanStatus);
                $(""#lowPinaltyUpdate"").val(obj.data.pinalty.lowPinalty);
                $(""#middlePinaltyUpdate"").val(obj.data.pinalty.middlePinalty);
                $(""#highPinaltyUpdate"").val(obj.data.pinalty.highPinalty);
                $(""#lostPinaltyUpdate"").val(obj.data.pinalty.lostPinalty);
            }).fail((error) => {
                console.log(error);
            });
        }

        function Update() {
            debugger;
            var Asset = new Object();
            Asset.id = $(""#idUpdate"").val();
            Asset.name = $(""#nameUpdate"").val();
            Asset.assetStatus = $(""#assetStatus"").val();
            Asset.loanStatus = $(""#loanStatus"").val();

            Asset.lowPinalty = $(""#lowPinaltyUpdate"").val();
            Asset.middlePinalty = $(""#middlePinaltyUpdate""");
                WriteLiteral(@").val();
            Asset.highPinalty = $(""#highPinaltyUpdate"").val();
            Asset.lostPinalty = $(""#lostPinaltyUpdate"").val();
                
            $('#updateModal').hide();
            $.ajax({
                url: ""/ProcurementEmployee/Update"",
                type: ""put"",
                data: Asset
            }).done((result) => {
                if (result == 200) {
                    swal({
                        title: ""Success!"",
                        text: ""Data added"",
                        icon: ""success"",
                        button: ""Ok"",
                    });
                    $('#updateModal').modal('hide');
                    table.ajax.reload();
                } else if (result == 400) {
                    swal(""failed to add data"", {
                        icon: ""warning"",
                    });
                } else {
                    swal(""failed to add data"", {
                        icon: ""warning"",
                    });");
                WriteLiteral(@"
                }
            }).fail((error) => {
                console.log(error);
            });
        }


        function Delete(id) {
            swal({
                title: ""Are you sure?"",
                text: ""Once deleted, you will not be able to recover this imaginary file!"",
                icon: ""warning"",
                buttons: true,
                danger: true
            }).then((willDelete) => {
                if (willDelete) {
                    $.ajax({
                        type: 'DELETE',
                        url: '/ProcurementEmployee/DeleteAsset',
                        data: { id: id }
                    }).done((result) => {
                        if (result == 200) {
                            swal(""Item has been deleted!"", {
                                icon: ""success""
                            });
                            table.ajax.reload();
                        } else {
                            swal(""Data failed to ");
                WriteLiteral(@"deleted!"", {
                                icon: ""warning""
                            });
                        }
                    }).fail((error) => {
                        console.log(error);
                    });
                } else {
                    swal(""Delete aborted!"", {
                        icon: ""warning""
                    });
                }
            });
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Metro_Asset_System.Models.Request>> Html { get; private set; }
    }
}
#pragma warning restore 1591
