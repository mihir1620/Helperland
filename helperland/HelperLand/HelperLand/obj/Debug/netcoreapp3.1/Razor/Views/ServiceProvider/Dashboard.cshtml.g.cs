#pragma checksum "D:\Helperland\helperland\HelperLand\HelperLand\Views\ServiceProvider\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11bd505c01d103b35729ce7a382ec0f18e02ef85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ServiceProvider_Dashboard), @"mvc.1.0.view", @"/Views/ServiceProvider/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11bd505c01d103b35729ce7a382ec0f18e02ef85", @"/Views/ServiceProvider/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e66cca87be2827d8164341c70d0a69872a1e884f", @"/Views/_ViewImports.cshtml")]
    public class Views_ServiceProvider_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 1 "D:\Helperland\helperland\HelperLand\HelperLand\Views\ServiceProvider\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"name-container text-align-center\">\r\n    <div class=\"container-fluid \">\r\n        <h1>Welcome <b>");
#nullable restore
#line 8 "D:\Helperland\helperland\HelperLand\HelperLand\Views\ServiceProvider\Dashboard.cshtml"
                  Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h1>\r\n    </div>\r\n</section>\r\n\r\n<section>\r\n");
#nullable restore
#line 13 "D:\Helperland\helperland\HelperLand\HelperLand\Views\ServiceProvider\Dashboard.cshtml"
     if (TempData["serviceAccepteError"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container d-flex justify-content-center\">\r\n            <div class=\"alert alert-success col-lg-6 alert1\">\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>\r\n                <strong>");
#nullable restore
#line 18 "D:\Helperland\helperland\HelperLand\HelperLand\Views\ServiceProvider\Dashboard.cshtml"
                   Write(TempData["serviceAccepteError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 21 "D:\Helperland\helperland\HelperLand\HelperLand\Views\ServiceProvider\Dashboard.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Helperland\helperland\HelperLand\HelperLand\Views\ServiceProvider\Dashboard.cshtml"
     if (TempData["serviceConcurrentError"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container d-flex justify-content-center\">\r\n            <div class=\"alert alert-success col-lg-6 alert1\">\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>\r\n                <strong>");
#nullable restore
#line 27 "D:\Helperland\helperland\HelperLand\HelperLand\Views\ServiceProvider\Dashboard.cshtml"
                   Write(TempData["serviceConcurrentError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 30 "D:\Helperland\helperland\HelperLand\HelperLand\Views\ServiceProvider\Dashboard.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</section>

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

    </div>
</div>-->
<!-- M");
            WriteLiteral(@"odal footer -->
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

<div class=""d-flex flex-row horizontal-menu flex-wrap"">

    <a href=""#"" id=""newServiceTab1"" class=""active"">New Service Request</a>

    <a href=""#"" id=""upcomingServiceTab1"">Upcoming Service</a>

    <a href=""#"" id=""serviceHistoryTab1"">S");
            WriteLiteral(@"ervice History</a>

    <a href=""#"" id=""myRatingTab1"">My Ratings</a>

    <a href=""#"" id=""blockCustomerTab1"">Block Customer</a>

</div>

<section class=""left-side-menu"">

    <div class=""container-fluid"">

        <div class=""row"">
            <!-- <div class=""col-lg-3 col-xl-3 col-md-3 col-sm-3 col-3 table-responsive menu service-tabs""> -->
            <div class=""col-lg-3 menu remove"">

                <a href=""#"" id=""newServiceTab"" class=""active"">New Service Request</a>

                <a href=""#"" id=""upcomingServiceTab"">Upcoming Service</a>

                <a href=""#"" id=""serviceHistoryTab"">Service History</a>

                <a href=""#"" id=""myRatingTab"">My Ratings</a>

                <a href=""#"" id=""blockCustomerTab"">Block Customer</a>


            </div>
");
            WriteLiteral(@"
            <div class=""col-lg-9 table-responsive service-details"" id=""newService"">
                <div class=""btn-group "">
                    <p style=""color: #646464;font-family: Roboto;font-weight: bold;font-size: 22px;"">New Service Request</p>
                </div>

                <div id=""loadNewServices"">

                </div>

            </div>


            <div class=""col-lg-9 table-responsive service-details"" id=""upcomingService"">
                <div class=""btn-group "">
                    <p style=""color: #646464;font-family: Roboto;font-weight: bold;font-size: 22px;"">Upcoming Service Request</p>
                </div>

                <div id=""loadUpcomingServices"">

                </div>


            </div>

            <div class=""col-lg-9 table-responsive service-details"" id=""serviceHistory"">
                <div class=""d-flex justify-content-between"">
                    <p style=""color: #646464;font-family: Roboto;font-weight: bold;font-size: 22px;"">Servi");
            WriteLiteral("ce History</p>\r\n");
#nullable restore
#line 164 "D:\Helperland\helperland\HelperLand\HelperLand\Views\ServiceProvider\Dashboard.cshtml"
                     using (Html.BeginForm("Export", "ServiceProvider", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input class=\"export-btn float-right excel\" type=\"submit\" value=\"Export\" />\r\n");
#nullable restore
#line 167 "D:\Helperland\helperland\HelperLand\HelperLand\Views\ServiceProvider\Dashboard.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>

                <div id=""loadServiceHistory"">

                </div>


            </div>

            <div class=""col-lg-9 table-responsive service-details"" id=""myRating"">
                <div class=""btn-group "">
                    <p style=""color: #646464;font-family: Roboto;font-weight: bold;font-size: 22px;"">My Rating</p>
                </div>

                <div id=""loadMyRating"">

                </div>


            </div>

            <div class=""col-lg-9 table-responsive service-details"" id=""blockCustomer"">
                <div class=""btn-group "">
                    <p style=""color: #646464;font-family: Roboto;font-weight: bold;font-size: 22px;"">Block Customer</p>
                </div>

                <div id=""loadBlockCustomer"">

                </div>


            </div>

        </div>
    </div>
    <a href=""#top"" class=""to-top"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "11bd505c01d103b35729ce7a382ec0f18e02ef8512355", async() => {
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
            WriteLiteral(@"
    </a>
</section>

<script type=""text/javascript"">

    $('#upcomingService').hide();
    $('#serviceHistory').hide();
    $('#myRating').hide();
    $('#blockCustomer').hide();

    $('#newServiceTab').click(function () {
        $('#loadNewServices').load('/ServiceProvider/NewServiceTable');
        $('#upcomingService').hide();
        $('#serviceHistory').hide();
        $('#myRating').hide();
        $('#blockCustomer').hide();
        $('#newService').show();
        $('#upcomingServiceTab').removeClass('active');
        $('#serviceHistoryTab').removeClass('active');
        $('#myRatingTab').removeClass('active');
        $('#blockCustomerTab').removeClass('active');
        $('#newServiceTab').addClass('active');
    });
    $('#upcomingServiceTab').click(function () {
        $('#loadUpcomingServices').load('/ServiceProvider/UpcomingServiceTable');
        $('#newService').hide();
        $('#serviceHistory').hide();
        $('#myRating').hide();
        $('#blockCus");
            WriteLiteral(@"tomer').hide();
        $('#upcomingService').show();
        $('#newServiceTab').removeClass(""active"");
        $('#serviceHistoryTab').removeClass(""active"");
        $('#myRatingTab').removeClass('active');
        $('#blockCustomerTab').removeClass('active');
        $('#upcomingServiceTab').addClass(""active"");
    });
    $('#serviceHistoryTab').click(function () {
        $('#loadServiceHistory').load('/ServiceProvider/ServiceHistoryTable');
        $('#newService').hide();
        $('#upcomingService').hide();
        $('#myRating').hide();
        $('#blockCustomer').hide();
        $('#serviceHistory').show();
        $('#newServiceTab').removeClass(""active"");
        $('#upcomingServiceTab').removeClass(""active"");
        $('#myRatingTab').removeClass('active');
        $('#blockCustomerTab').removeClass('active');
        $('#serviceHistoryTab').addClass(""active"");
    });
    $('#myRatingTab').click(function () {
        $('#loadMyRating').load('/ServiceProvider/MyRatingTable'");
            WriteLiteral(@");
        $('#newService').hide();
        $('#upcomingService').hide();
        $('#serviceHistory').hide();
        $('#blockCustomer').hide();
        $('#myRating').show();
        $('#newServiceTab').removeClass(""active"");
        $('#upcomingServiceTab').removeClass(""active"");
        $('#serviceHistoryTab').removeClass(""active"");
        $('#blockCustomerTab').removeClass('active');
        $('#myRatingTab').addClass('active');
    });
    $('#blockCustomerTab').click(function () {
        $('#loadBlockCustomer').load('/ServiceProvider/BlockCustomer');
        $('#newService').hide();
        $('#upcomingService').hide();
        $('#serviceHistory').hide();
        $('#myRating').hide();
        $('#blockCustomer').show();
        $('#newServiceTab').removeClass(""active"");
        $('#upcomingServiceTab').removeClass(""active"");
        $('#serviceHistoryTab').removeClass(""active"");
        $('#myRatingTab').removeClass('active');
        $('#blockCustomerTab').addClass('active'");
            WriteLiteral(@");
    });

    $('#newServiceTab1').click(function () {
        $('#loadNewServices').load('/ServiceProvider/NewServiceTable');
        $('#upcomingService').hide();
        $('#serviceHistory').hide();
        $('#myRating').hide();
        $('#blockCustomer').hide();
        $('#newService').show();
        $('#upcomingServiceTab1').removeClass('active');
        $('#serviceHistoryTab1').removeClass('active');
        $('#myRatingTab1').removeClass('active');
        $('#blockCustomerTab1').removeClass('active');
        $('#newServiceTab1').addClass('active');
    });
    $('#upcomingServiceTab1').click(function () {
        $('#loadUpcomingServices').load('/ServiceProvider/UpcomingServiceTable');
        $('#newService').hide();
        $('#serviceHistory').hide();
        $('#myRating').hide();
        $('#blockCustomer').hide();
        $('#upcomingService').show();
        $('#newServiceTab1').removeClass(""active"");
        $('#serviceHistoryTab1').removeClass(""active"");
     ");
            WriteLiteral(@"   $('#myRatingTab1').removeClass('active');
        $('#blockCustomerTab1').removeClass('active');
        $('#upcomingServiceTab1').addClass(""active"");
    });
    $('#serviceHistoryTab1').click(function () {
        $('#loadServiceHistory').load('/ServiceProvider/ServiceHistoryTable');
        $('#newService').hide();
        $('#upcomingService').hide();
        $('#myRating').hide();
        $('#blockCustomer').hide();
        $('#serviceHistory').show();
        $('#newServiceTab1').removeClass(""active"");
        $('#upcomingServiceTab1').removeClass(""active"");
        $('#myRatingTab1').removeClass('active');
        $('#blockCustomerTab1').removeClass('active');
        $('#serviceHistoryTab1').addClass(""active"");
    });
    $('#myRatingTab1').click(function () {
        $('#loadMyRating').load('/ServiceProvider/MyRatingTable');
        $('#newService').hide();
        $('#upcomingService').hide();
        $('#serviceHistory').hide();
        $('#blockCustomer').hide();
       ");
            WriteLiteral(@" $('#myRating').show();
        $('#newServiceTab1').removeClass(""active"");
        $('#upcomingServiceTab1').removeClass(""active"");
        $('#serviceHistoryTab1').removeClass(""active"");
        $('#blockCustomerTab1').removeClass('active');
        $('#myRatingTab1').addClass('active');
    });
    $('#blockCustomerTab1').click(function () {
        $('#loadBlockCustomer').load('/ServiceProvider/BlockCustomer');
        $('#newService').hide();
        $('#upcomingService').hide();
        $('#serviceHistory').hide();
        $('#myRating').hide();
        $('#blockCustomer').show();
        $('#newServiceTab1').removeClass(""active"");
        $('#upcomingServiceTab1').removeClass(""active"");
        $('#serviceHistoryTab1').removeClass(""active"");
        $('#myRatingTab1').removeClass('active');
        $('#blockCustomerTab1').addClass('active');
    });
</script>");
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
