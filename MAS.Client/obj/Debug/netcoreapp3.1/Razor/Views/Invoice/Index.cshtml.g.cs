#pragma checksum "C:\Users\Edward\source\05.Git\Final Project 2\MetroAssetSystem\MAS.Client\Views\Invoice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "839a8766cdce1f46c3996853d413a841a868e466"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Index), @"mvc.1.0.view", @"/Views/Invoice/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"839a8766cdce1f46c3996853d413a841a868e466", @"/Views/Invoice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58438fb03bc46bda326dff31745fed6749c862ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("commentForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<a href=""javascript:void(0)"" class=""btn bg-transparent text-success"" data-toggle=""modal"" data-target=""#addModal"" onclick=""Add();""><i class=""fas fa-plus""></i></a>

<div class=""container-fluid mt-5"">
    <table id=""mytables"" class=""table table-striped table-bordered"" style=""width:100%"">
        <thead>
            <tr>
                <th>No.</th>
                <th>ID</th>
                <th>Status</th>
                <th>Invoice Date</th>
                <th>Request ID</th>
                <th>Employee ID</th>
            </tr>
        </thead>
        <tbody></tbody>
        <tfoot>
            <tr>
                <th>No.</th>
                <th>ID</th>
                <th>Status</th>
                <th>Invoice Date</th>
                <th>Request ID</th>
                <th>Employee ID</th>
            </tr>
        </tfoot>
    </table>
</div>

<div class=""modal fade"" id=""addModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addModalLabel"" aria-hidden=""true"">
    <div c");
            WriteLiteral(@"lass=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""addModalLabel"">Add Role</h5>
                <h5 class=""modal-title"" id=""editModalLabel"">Edit Role</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "839a8766cdce1f46c3996853d413a841a868e4665268", async() => {
                WriteLiteral(@"
                    <div class=""form-group"" hidden>
                        <label for=""id"" class=""col-form-label"">Id</label>
                        <input type=""text"" class=""form-control"" id=""id"" name=""id"">
                    </div>
                    <div class=""form-group"">
                        <label for=""message-text"" class=""col-form-label"">Name</label>
                        <input type=""text"" class=""form-control"" id=""name"" name=""name"" required>
                    </div>
                    <div class=""form-check agree"">
                        <input type=""checkbox"" for=""agreement"" class=""form-check-input"" id=""agreement"" name=""agreement"">
                        <label class=""form-check-label"" for=""agreement"">I agree for terms and conditions</label>
                    </div>
");
                WriteLiteral("                ");
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
                <button type=""button"" class=""btn btn-primary"" id=""buttonsubmit"">Submit</button>
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"" id=""Update"" onclick=""Update();"">Update</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        $(""#buttonsubmit"").click(function (e) {
            e.preventDefault();
            if ($(""#commentForm"").valid())
            {
                Submit();
            }
            else {

            }
        });


        $(document).ready(function () {
            $(""#commentForm"").validate({
                rules: {
                    name: {
                        required: true,
                        maxlength: 20
                    },
                    agreement: ""required""
                },
                messages: {
                    name: {
                        required: ""Please enter a role"",
                        maxlength: ""Max 20 characters""
                    },
                    agreement: ""You must check the agreement""
                }, errorPlacement: function (error, element) {
                    if (element.is("":checkbox"")) {
                        error.appendTo(element.parents("".agree""));
                    }");
                WriteLiteral(@" else {
                        error.insertAfter(element);
                    }
                }
            });
            table = $(""#mytables"").DataTable({
                ""ajax"": {
                    ""url"": ""https://localhost:44329/api/invoice"",
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
                        ""targets"": [3],
                        ""searchable"": false,
                        ""orderable"": false
                    }
                ],
                ""columns"": [
                    {
                        ""data"": null,
                        ""render"": function (data, type, row, meta) {
    ");
                WriteLiteral(@"                        return meta.row + meta.settings._iDisplayStart + 1;
                        }
                    },
                    {
                        ""data"": null,
                        ""render"": function (data, type, row) {
                            return row['id'];
                        },
                    },
                    {
                        ""data"": null,
                        ""render"": function (data, type, row) {
                            return row['name'];
                        },
                    },
                    {
                        ""render"": function (data, type, row, meta) {
                            return '<a href=""javascript:void(0)"" class=""far fa-edit table-action text-dark"" data-toggle=""tooltip"" data-placement=""top"" title=""Edit"" onclick=""return Get(' + row['id'] + ')""></a> ' +
                                '<a href=""javascript:void(0)"" class=""fa fa-trash table-action text-danger"" data-toggle=""tooltip"" data-pla");
                WriteLiteral(@"cement=""top"" title=""Delete"" onclick=""return Delete(' + row['id'] + ')""></a>'
                        }
                    }
                ]
            });
        });

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
                        url: '/role/Delete',
                        data: { id: id }
                    }).done((result) => {
                        if (result == 200) {
                            swal(""Item has been deleted!"", {
                                icon: ""success""
                            });
                            table.ajax.reload();
                        } else {
              ");
                WriteLiteral(@"              swal(""Data failed to deleted!"", {
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

        function Create() {
            var role = new Object();
            role.name = $(""#name"").val();
            $.ajax({
                url: ""/role/Create"",
                type: ""post"",
                data: role
            }).done((result) => {
                if (result == 200) {
                    table.ajax.reload();
                    swal({
                        title: ""Success!"",
                        text: ""Data added"",
                        icon: ""success"",
                        button: ""Ok"",
                    });");
                WriteLiteral(@"
                    $('#addModal').modal('hide');
                    ClearScreen();
                } else if (result == 400) {
                    swal(""failed to add data"", {
                        icon: ""warning"",
                    });
                    ClearScreen();
                } else {
                    swal(""failed to add data"", {
                        icon: ""warning"",
                    });
                    ClearScreen();
                }
            }).fail((error) => {
                console.log(error);
            });
        }

        function Get(id) {
            debugger;
            $('#buttonsubmit').hide();
            $('#Update').show();
            $('#Create').hide();
            $('#addModalLabel').hide();
            $('#editModalLabel').show();
                $.ajax({
                url: '/role/Get',
                data: { id: id }
            }).done((result) => {
                console.log(result);
                var obj = JSO");
                WriteLiteral(@"N.parse(result);
                $(""#addModal"").modal(""show"");
                $(""#id"").val(obj.data.id);
                $(""#name"").val(obj.data.name);
            }).fail((error) => {
                console.log(error);
            });
        }

        function Submit() {
            var id = $(""#id"").val();
            var name = $(""#name"").val();

            if (id == """" || id == "" "") {
                console.log(""post accesed"");
                Create();
            } else {
                console.log(""put accesed"");
                Update();
            }
        }

        function Update() {
            var role = new Object();
            role.id = $(""#id"").val();
            role.name = $(""#name"").val();
            $.ajax({
                url: ""/role/Update"",
                type: ""put"",
                data: role
            }).done((result) => {
                if (result == 200) {
                    table.ajax.reload();
                    swal({
        ");
                WriteLiteral(@"                title: ""Success!"",
                        text: ""Data added"",
                        icon: ""success"",
                        button: ""Ok"",
                    });
                } else if (result == 400) {
                    ClearScreen();
                    swal(""failed to add data"", {
                        icon: ""warning"",
                    });
                } else {
                    ClearScreen();
                    swal(""failed to add data"", {
                        icon: ""warning"",
                    });
                }
            }).fail((error) => {
                console.log(error);
            });
        }

        function Add() {
            $(""#name"").val(null);
            $(""#id"").val(null);
            $('#buttonsubmit').show();
            $('#addModalLabel').show();
            $('#Update').hide();
            $('#editModalLabel').hide();
        }
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
