#pragma checksum "C:\RepoGithub\MCC\FINALPROJECT\PROJECT\MetroAssetSystem\MAS.Client\Views\ProcurementEmployee\Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9df58fcb8119df3d109687bfea055f19c1180498"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProcurementEmployee_Invoice), @"mvc.1.0.view", @"/Views/ProcurementEmployee/Invoice.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9df58fcb8119df3d109687bfea055f19c1180498", @"/Views/ProcurementEmployee/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58438fb03bc46bda326dff31745fed6749c862ce", @"/Views/_ViewImports.cshtml")]
    public class Views_ProcurementEmployee_Invoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("invoiceForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\RepoGithub\MCC\FINALPROJECT\PROJECT\MetroAssetSystem\MAS.Client\Views\ProcurementEmployee\Invoice.cshtml"
  
    Layout = "~/Views/Template/DashboardBase.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/vendor/datatables/css/dataTables.bootstrap4.min.css\">\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Menu", async() => {
                WriteLiteral(@"
    <div class=""nav"">
        <div class=""sb-sidenav-menu-heading"">Manager</div>
        <a class=""nav-link"" href=""https://localhost:44342/employee"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-home""></i></div>
            Dashboard
        </a>
        <a class=""nav-link"" href=""https://localhost:44342/master/asset"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-database""></i></div>
            Asset
        </a>
        <a class=""nav-link"" href=""https://localhost:44342/master/employee"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-users-cog""></i></div>
            Requester
        </a>
        <a class=""nav-link"" href=""https://localhost:44342/master/request"">
            <div class=""sb-nav-link-icon""><i class=""far fa-newspaper""></i></div>
            Request
        </a>
        <a class=""nav-link"" href=""https://localhost:44342/master/invoice"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-file-invoice""></i></div>
            Invoi");
                WriteLiteral("ce\r\n        </a>\r\n    </div>\r\n");
            }
            );
            WriteLiteral(@"
<nav>
    <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
        <a class=""nav-link text-dark active"" id=""ongoing-btn"" data-toggle=""tab"" href=""#data-tables""
           role=""tab"" aria-controls=""card-data"" aria-selected=""true"">On Going</a>
        <a class=""nav-link text-dark"" id=""finished-btn"" data-toggle=""tab"" href=""#data-tables""
           role=""tab"" aria-controls=""card-data"" aria-selected=""true"">Finished</a>        
    </div>
</nav>
<div class=""tab-content"" id=""nav-tabContent"">    
    <div class=""tab-pane fade show active"" id=""data-tables"" role=""tabpanel"" aria-labelledby=""data-tables-tab"">
        <div class=""table-responsive mt-4"">
            <table class=""table table-bordered"" id=""myTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>No</th>
                        <th>Invoice Id</th>
                        <th>Request Id</th>
                        <th>Requester</th>
                        <th>Total Items</th");
            WriteLiteral(@">                                              
                        <th>Action</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>No</th>
                        <th>Invoice Id</th>
                        <th>Request Id</th>
                        <th>Requester</th>
                        <th>Total Items</th>
                        <th>Action</th>
                    </tr>
                </tfoot>
                <tbody>
                </tbody>
            </table>
        </div>
    </div>
</div>

<!-- Start Modal -->
<div class=""modal fade"" id=""detailsModal"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1""
     aria-labelledby=""detailsModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-dialog-scrollable modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""detailsModalLa");
            WriteLiteral(@"bel"">Request Details</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"" id=""closeModal"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <table cellpadding=""5"">
                    <tr>
                        <td>Invoice Id</td>
                        <td>:</td>
                        <td id=""setId""></td>
                    </tr>
                </table>
                <hr>
                <h5>Items List</h5>
                <ol id=""itemList"">
                </ol>
                <hr>
                <h5>Items Condition</h5>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9df58fcb8119df3d109687bfea055f19c118049810283", async() => {
                WriteLiteral("\r\n                    <input hidden id=\"invoiceId\" name=\"invoiceId\" />\r\n                   <div id=\"assetPinalty\">\r\n\r\n                   </div>\r\n                ");
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
                <button type=""button"" class=""btn btn-sm btn-dark"" id=""submit-btn"">Processed</button>
            </div>
        </div>
    </div>
</div>
<!-- End Modal -->

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
                ""url"": ""https://localhost:44329/api/Invoice/data/ongoing"",
                ""datatype"": ""json"",
                ""dataSrc"": """"
            },
            ""columnDefs"": [
                {
                    ""targets"": [0, 1,2,4],
                    ""searchable"": true,
                    ""orderable"": true,
                },
                {
                    ""targets"": [3,5],
                    ""searchable"": false,
                    ""orderable"": false
                }
            ],
            ""columns"": [
                {
                    ""data"": null,
                    ""render"": function (data, type, row, meta) {
                        return meta.row + meta.settings._iDisplayStart + 1;
                    }
                },
                {
                    ""data"": 'id'
                },
                {             
                    ""data"":'requestId'                  ");
                WriteLiteral(@" 
                },
                {
                    ""data"": 'null',
                    ""render"": function (data, type, row, meta) {                        
                       return row.request.employee.firstName+"" ""+row.request.employee.lastName ;
                    }                    
                },
                {
                    ""data"": 'request.itemRequest.length'                    
                },                                         
                {
                    ""data"": 'id',
                    ""render"": function (data, type, row, meta) {
                        if(row.status==0){
                            return '<a href=""javascript:void(0)"" class=""btn btn-sm btn-light"" onclick=""Details(\'' + data + '\')""><i class=""far fa-check-square""></i></a>';              
                        }else{
                            return '-';
                        }
                    }
                }
            ]
        });    

    $(""#o");
                WriteLiteral(@"ngoing-btn"").click(function(){
        table.ajax.url( 'https://localhost:44329/api/Invoice/data/ongoing').load();
    }); 
    $(""#finished-btn"").click(function(){
        table.ajax.url( 'https://localhost:44329/api/Invoice/data/finished').load();
    });
    
    $(""#closeModal"").click(function(){
      ClearForm();
    }); 

    $(""#submit-btn"").click(function(e){
        e.preventDefault();
        Submit();
    });
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    let listAssetId = [];

    function Details(id){
        let pinaltyList = """";
        $.ajax({
                type:'GET',
                url: 'https://localhost:44329/api/Invoice/'+id,
                data: 'data'
            }).done((result) => {                
                if (result.status == ""Ok"") {
                    let hasil="""";
                    $('#setId').html('#'+result.data.id);                  
                    $.each( result.data.request.itemRequest, function( i, field ) {
                        listAssetId.push(field.asset.id.toString());                        
                        pinaltyList+='<div class=""form-row"">'+
                                        '<div class=""form-group col-md-5"">'+
                                            '<input type=""text"" class=""form-control-plaintext"" id=""asset'+field.asset.id +'"" value=""#'+field.asset.id+' "">'+
                                        '</div>'+
                                        '<div class=""f");
                WriteLiteral("orm-group col-md-7\">\'+\r\n                                            \'<select id=\"pinalty\'+field.asset.id +\'\" class=\"form-control\">\'+\r\n                                                \'");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9df58fcb8119df3d109687bfea055f19c118049816512", async() => {
                    WriteLiteral("Choose...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\'+\r\n                                                \'");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9df58fcb8119df3d109687bfea055f19c118049818115", async() => {
                    WriteLiteral("Fine");
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
                WriteLiteral("\'+\r\n                                                \'");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9df58fcb8119df3d109687bfea055f19c118049819390", async() => {
                    WriteLiteral("Low Damaged");
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
                WriteLiteral("\'+\r\n                                                \'");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9df58fcb8119df3d109687bfea055f19c118049820672", async() => {
                    WriteLiteral("Middle Damaged");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\'+\r\n                                                \'");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9df58fcb8119df3d109687bfea055f19c118049821957", async() => {
                    WriteLiteral("High Damaged");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\'+\r\n                                                \'");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9df58fcb8119df3d109687bfea055f19c118049823240", async() => {
                    WriteLiteral("Asset Lost");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"'+
                                            '</select>'+
                                        '</div>'+
                                      '</div>';                        
                        hasil+='<li>#'+field.asset.id+' - '+field.asset.name+'</li>';                                      
                    });
                    $('#itemList').html(hasil);
                    $('#assetPinalty').html(pinaltyList);
                    $('#invoiceId').val(result.data.id);                    
                    $('#detailsModal').modal('show');                    
                } 
                else {
                      swal(""Failed to get data"", {
                        icon: ""warning"",
                    });               
                }
            }).fail((error) => {
                console.log(error);
            });
    }
   

    function ClearForm(){
         $('#setId').html('');
         $('#assetPinalty').html('');
         $('#itemList').html('");
                WriteLiteral(@"');        
         $('#invoiceId').val('');
         listAssetId = [];        
    }

    function Coba(){
        let assetData =[];
        let problemCount =0;
        $.each(listAssetId, function( index, value ) {
    	    let res = $('#pinalty'+value).val();
  		    assetData.push([value,res]);
            if(value!=0){
                problemCount+=1;
            }
	    });
        var Invoice = new Object();        
        Invoice.InvoiceId = $('#invoiceId').val();
        Invoice.Assets = assetData;
        if(problemCount>0){
            Invoice.StatusInvoice = ""2"";
        }else{
            Invoice.StatusInvoice = ""1"";
        }
        console.log(Invoice);
    }

    function Submit(){
        swal({
            title: ""Processing..."",
            text: ""Please wait"",
            button: false,
            closeOnClickOutside: false,
        });        
        let assetData =[];
        let problemCount =0;
        $.each(listAssetId, function( index, value ");
                WriteLiteral(@") {
    	    let res = $('#pinalty'+value).val().toString();
  		    assetData.push([value,res]);
            if(value!=0){
                problemCount+=1;
            }
	    });
        var Invoice = new Object();        
        Invoice.InvoiceId = $('#invoiceId').val();
        Invoice.Assets = assetData;
        if(problemCount>0){
            Invoice.StatusInvoice = ""2"";
        }else{
            Invoice.StatusInvoice = ""1"";
        }
        console.log(Invoice.Assets);
        console.log(assetData);
            $.ajax({
                type:'POST',
                url: 'https://localhost:44342/employee/return',                
                data: Invoice
            }).done((result) => {
                console.log(result);
                if (result == 200) {
                    swal({
                        title: ""Success!"",
                        text: ""Success returning the assets"",
                        icon: ""success""                        
                 ");
                WriteLiteral(@"   });
                    ClearForm();
                    $('#detailsModal').modal('hide');
                    table.ajax.url( 'https://localhost:44329/api/Invoice/data/ongoing').load();                    
                } 
                else {
                      swal(""Failed to returning asset"", {
                        icon: ""warning"",
                    });               
                }
            }).fail((error) => {
                console.log(error);
            });
    }    
");
            }
            );
            WriteLiteral(" ");
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
