#pragma checksum "C:\RepoGithub\MCC\FINALPROJECT\PROJECT\MetroAssetSystem\MAS.Client\Views\Requester\CreateRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a81ca21dc02b1d916e852833cce677f3205d649"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Requester_CreateRequest), @"mvc.1.0.view", @"/Views/Requester/CreateRequest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a81ca21dc02b1d916e852833cce677f3205d649", @"/Views/Requester/CreateRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58438fb03bc46bda326dff31745fed6749c862ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Requester_CreateRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/datepicker/css/datepicker.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("requestForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/datepicker/js/datepicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\RepoGithub\MCC\FINALPROJECT\PROJECT\MetroAssetSystem\MAS.Client\Views\Requester\CreateRequest.cshtml"
  
    Layout = "~/Views/Template/DashboardBase.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9a81ca21dc02b1d916e852833cce677f3205d6495649", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/vendor/datatables/css/dataTables.bootstrap4.min.css\">\r\n    <style>\r\n        .error {\r\n            color: rgb(221, 0, 0);\r\n        }\r\n    </style>\r\n");
            }
            );
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
        <a class=""nav-link disabled"" href=""https://localhost:44342/employee/invoice"">
            <div class=""sb-nav-link-icon""><i class=""fas fa-file-invoice""></i></div>
            Invoice
        </a>
    </div>
");
            }
            );
            WriteLiteral(@"
<div class=""row mb-3"">
    <div class=""col-lg-8 col-md-7 overflow-auto"">
        <nav>
            <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
                <a class=""nav-link active text-dark"" data-toggle=""tab""
                   href=""#data-tables"" id=""available-btn"" role=""tab"" aria-controls=""card-data""
                   aria-selected=""true"">Available</a>
                <a class=""nav-link text-dark"" data-toggle=""tab""
                   href=""#data-tables"" id=""unavailable-btn"" role=""tab"" aria-controls=""card-data""
                   aria-selected=""true"">Unavailable</a>
            </div>
        </nav>
        <div class=""tab-content"" id=""nav-tabContent"">
            <div class=""tab-pane fade show active"" id=""data-tables"" role=""tabpanel""
                 aria-labelledby=""data-tables-tab"">
                <div class=""table-responsive mt-4"">
                    <table class=""table table-bordered"" id=""myTable"" width=""100%"" cellspacing=""0"">
                        <thead>
      ");
            WriteLiteral(@"                      <tr>
                                <th>Id Asset</th>
                                <th>Name</th>
                                <th>Low Pinalty</th>
                                <th>Middle Pinalty</th>
                                <th>High Pinalty</th>
                                <th>Lost Pinalty</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th>Id Asset</th>
                                <th>Name</th>
                                <th>Low Pinalty</th>
                                <th>Middle Pinalty</th>
                                <th>High Pinalty</th>
                                <th>Lost Pinalty</th>
                                <th>Action</th>
                            </tr>
                        </tfoot>
                        <tbody>
                      ");
            WriteLiteral(@"  </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-4 col-md-5"">
        <div class=""card"">
            <div class=""card-header bg-dark text-light"">
                <i class=""far fa-list-alt""></i> Request Detail
            </div>
            <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a81ca21dc02b1d916e852833cce677f3205d64910458", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""start"">From</label>
                        <input type=""text"" class=""form-control date-input"" id=""start"" name=""start"">
                    </div>
                    <div class=""form-group"">
                        <label for=""end"">Until</label>
                        <input type=""text"" class=""form-control date-input"" id=""end"" name=""end"">
                    </div>
                    <div class=""form-group form-check agree"">
                        <input type=""checkbox"" class=""form-check-input"" id=""agreement"" name=""agreement"">
                        <label class=""form-check-label"" for=""agreement"">
                            I agree with all terms
                            and conditions
                        </label>
                    </div>
                    <hr>
                    <h5 class=""text-center mb-3""><b>Items List</b></h5>
                    <input type=""text"" id=""listCheck"" name=""lis");
                WriteLiteral(@"tCheck"" hidden>
                    <ol class=""px-3"" id=""itemsList"">
                    </ol>
                    <div class=""w-100"">
                        <button type=""reset"" class=""btn btn-secondary btn-sm w-25 d-inline"" id=""reset-btn""><i class=""fas fa-undo-alt""></i></button>
                        <button type=""submit"" class=""btn btn-dark btn-sm w-auto d-inline"" id=""submit-btn"">Submit</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("ScriptsLink", async() => {
                WriteLiteral("\r\n    <script src=\"/vendor/datatables/js/jquery.dataTables.min.js\"></script>\r\n    <script src=\"/vendor/datatables/js/dataTables.bootstrap4.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a81ca21dc02b1d916e852833cce677f3205d64913689", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a81ca21dc02b1d916e852833cce677f3205d64914789", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("ScriptsDocReady", async() => {
                WriteLiteral(@"
    table = $('#myTable').DataTable({
    ""ajax"": {
    ""url"": ""https://localhost:44329/api/Asset/GetAsset/available"",
    ""datatype"": ""json"",
    ""dataSrc"": ""data""
    },
    ""columnDefs"": [
    {
    ""targets"": [0, 1],
    ""searchable"": true,
    ""orderable"": true,
    },
    {
    ""targets"": [2, 3, 4, 5, 6],
    ""searchable"": false,
    ""orderable"": false
    }
    ],
    ""columns"": [
    {
    ""data"": 'id'
    },
    {
    ""data"": 'name'
    },
    {
    ""data"": 'pinalty.lowPinalty'
    },
    {
    ""data"": 'pinalty.middlePinalty'
    },
    {
    ""data"": 'pinalty.highPinalty'
    },
    {
    ""data"": 'pinalty.lostPinalty'
    },
    {
    ""render"": function (data, type, row, meta) {
    if(row.loanStatus==0){
    return '<a href=""javascript:void(0)"" class=""btn btn-sm btn-light""><i class=""far fa-plus-square"" onclick=""Add(\'' + row.id + '\')""></i></a>'
    }else{
    return 'Not Available'
    }
    }
    }
    ]
    });

    $(""#available-btn"").click(func");
                WriteLiteral(@"tion(){
    table.ajax.url( 'https://localhost:44329/api/Asset/GetAsset/available').load();
    });
    $(""#unavailable-btn"").click(function(){
    table.ajax.url( 'https://localhost:44329/api/Asset/GetAsset/unavailable').load();
    });

    $(function () {
    $("".date-input"").datepicker({
    format: 'dd/mm/yyyy',
    autoclose: true,
    todayHighlight: true,
    leftArrow: '<i class=""far fa-arrow-alt-circle-left""></i>',
    rightArrow: '<i class=""far fa-arrow-alt-circle-right""></i>'
    });
    });

    $(""#submit-btn"").click(function (e) {
    e.preventDefault();
    let listCheck = $('#listCheck').val();
    if (listCheck=='') {
    swal(""Warning!"", ""Please choose at least 1 items!"", ""warning"");
    }else if(requestForm.valid()){
    Request();
    }
    });

    $(""#reset-btn"").click(function (e) {
    ClearForm();
    });

    let requestForm = $(""#requestForm"");

    requestForm.validate({
    rules: {
    start: {
    required: true,
    maxLoan: true
    },
 ");
                WriteLiteral(@"   end: {
    required: true
    },
    agreement: ""required""
    },
    highlight: function (element) {
    $(element).closest('.form-control').addClass('is-invalid');
    $(element).closest('.form-control').removeClass('is-valid');
    },
    unhighlight: function (element) {
    $(element).closest('.form-control').removeClass('is-invalid');
    $(element).closest('.form-control').addClass('is-valid');
    }, errorPlacement: function (error, element) {
    if (element.is("":checkbox"")) {
    error.appendTo(element.parents("".agree""));
    } else {
    error.insertAfter(element)
    }
    }
    })

    $.validator.addMethod(""maxLoan"", function (value, element) {
    let start = new Date(value);
    let now = new Date();
    let maxDate = new Date(now);
    maxDate.setDate(maxDate.getDate() + 5);

    if (start > maxDate) {
    return false;
    } else {
    return true;
    }
    }, ""You only can loan for 5 days forward from now!"");

");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    let countItems = 0;
    let itemList = [];
    var output = """";
    function Add(id) {
    if (itemList.includes(id)){
    swal({
    title: ""Abort"",
    text: ""You have add this item"",
    icon: ""warning"",
    button: ""I got it"",
    });
    }else if(countItems>=3){
    swal({
    title: ""Abort"",
    text: ""You cann't add more than 3 items"",
    icon: ""warning"",
    button: ""I got it"",
    });
    }
    else{
    CountItems(id);
    DisplayItems(id);
    $('#listCheck').val(""true"");
    }
    }

    function CountItems(id){
    itemList.push(id);
    countItems+=1;
    }

    function DisplayItems(id){
    output+='<li>#'+id+'</li>';
    $(""#itemsList"").html(output);
    }

    function ClearForm(){
    $('#start').val('').removeClass(""is-valid"");
    $('#end').val('').removeClass(""is-valid"");
    $('#agreement').prop('checked', false);
    $(""#itemsList"").empty();
    $('#listCheck').val('');
    countItems = 0;
    itemList=[];
    }

    function Request");
                WriteLiteral(@"(){
    swal({
    title: ""Requesting..."",
    text: ""Please wait"",
    button: false,
    closeOnClickOutside: false,
    });
    var Request = new Object();
    Request.StartDate = $('#start').val();
    Request.EndDate = $('#end').val();
    Request.Assets = itemList;
    $.ajax({
    type:'POST',
    url: 'https://localhost:44342/employee/create',
    data: Request
    }).done((result) => {
    if (result == 200) {
    swal({
    title: ""Success!"",
    text: ""Your request has been created"",
    icon: ""success""
    });
    ClearForm();
    $('#myTable').ajax.url( 'https://localhost:44329/api/Asset/GetAsset/available').load();
    }
    else {
    swal(""Failed to create request"", {
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
