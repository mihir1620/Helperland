#pragma checksum "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\Servicehistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a876035544234ccbad31a1f0c983ba7ae45ecaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Servicehistory), @"mvc.1.0.view", @"/Views/Customer/Servicehistory.cshtml")]
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
#line 1 "D:\Helperland\helperland\HelperLand\HelperLand\Views\_ViewImports.cshtml"
using HelperLand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Helperland\helperland\HelperLand\HelperLand\Views\_ViewImports.cshtml"
using HelperLand.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Helperland\helperland\HelperLand\HelperLand\Views\_ViewImports.cshtml"
using HelperLand.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Helperland\helperland\HelperLand\HelperLand\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a876035544234ccbad31a1f0c983ba7ae45ecaa", @"/Views/Customer/Servicehistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e66cca87be2827d8164341c70d0a69872a1e884f", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Servicehistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/up-aero.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.11.3/css/jquery.dataTables.min.css\">\r\n");
#nullable restore
#line 2 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\Servicehistory.cshtml"
  
    ViewData["Title"] = "ServiceHistory";
    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"name-container text-align-center\">\r\n    <div class=\"container-fluid \">\r\n        <h1>Welcome <b>");
#nullable restore
#line 10 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\Servicehistory.cshtml"
                  Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></h1>
    </div>
</section>

<!--<div class=""container modal-menu"">-->
<!-- The Modal -->
<!--<div class=""modal fade"" id=""collapsiblemodal"">
    <div class=""modal-dialog modal-sm"">
        <div class=""modal-content"">-->
<!-- Modal Header -->
<!--<div class=""modal-header"">
    <div class=""container"">
        <div>
            <h5 class=""modal-title"">Welcome</h5>
        </div>
        <div>
            <p class=""modal-title"">User!</p>
        </div>
    </div>
    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
</div>-->
<!-- Modal body -->
<!--<div class=""modal-body"">
    <div class=""container"">

        <a href=""#"">Dashboard</a>
        <a href=""#"">New Service Request</a>
        <a href=""#"" class=""active"">Upcoming Service</a>
        <a href=""#"">Service Schedule</a>
        <a href=""#"">Service History</a>
        <a href=""#"">My Rating</a>
        <a href=""#"">Block Customer</a>
        <a href=""#"">My Setting</a>
        <a href=""#""></a>

    </");
            WriteLiteral(@"div>
</div>-->
<!-- Modal footer -->
<!--<div class=""modal-footer"">
                    <div class=""container"">
                        <a href=""#"">Prices & Services</a>
                        <a href=""#"">Warranty</a>
                        <a href=""#"">Blog</a>
                        <a href=""#"">Content</a>
                    </div>
                </div>

                <div class=""modal-footer"">
                    <div class=""container"" style=""display: flex;margin: auto;justify-content: space-around;"">
                        <a href=""#""><img src=""~/images/ic-facebook.png""></a>
                        <a href=""#""><img src=""~/images/ic-instagram.png""></a>
                    </div>
                </div>

            </div>
        </div>
    </div>

</div>-->

<section class=""left-side-menu"">

    <div class=""container-fluid"">

        <div class=""row"">
            <!-- <div class=""col-lg-3 col-xl-3 col-md-3 col-sm-3 col-3 table-responsive menu service-tabs""> -->
       ");
            WriteLiteral("     <div class=\"col-lg-3 menu remove\">\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2431, "\"", 2473, 1);
#nullable restore
#line 78 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\Servicehistory.cshtml"
WriteAttributeValue("", 2438, Url.Action("Dashboard","Customer"), 2438, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Dashboard</a>\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2510, "\"", 2557, 1);
#nullable restore
#line 80 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\Servicehistory.cshtml"
WriteAttributeValue("", 2517, Url.Action("Servicehistory","Customer"), 2517, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""active"">Service History</a>


                <a href=""#"">Favorite Pros</a>


            </div>

            <div class=""col-lg-9 table-responsive service-details"">
                <div class=""btn-group "">
                    <p style=""color: #646464;font-family: Roboto;font-weight: bold;font-size: 22px;"">Service History</p>
                </div>
                <input class=""export-btn float-right excel"" type=""button"" value=""Export"">
                <div id=""loadServiceHistoryTable"">

                </div>
            </div>
        </div>
    </div>

    <a href=""#top"" class=""to-top"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9a876035544234ccbad31a1f0c983ba7ae45ecaa8353", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </a>\r\n</section>\r\n\r\n");
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
