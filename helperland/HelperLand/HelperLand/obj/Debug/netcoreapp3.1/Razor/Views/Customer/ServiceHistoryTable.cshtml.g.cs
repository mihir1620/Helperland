#pragma checksum "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22896d9a017ef37e6f6c080833cf851d48d78da7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ServiceHistoryTable), @"mvc.1.0.view", @"/Views/Customer/ServiceHistoryTable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22896d9a017ef37e6f6c080833cf851d48d78da7", @"/Views/Customer/ServiceHistoryTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e66cca87be2827d8164341c70d0a69872a1e884f", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ServiceHistoryTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HelperLand.Models.ServiceRequest>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/calendar2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/layer-14.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/avatar-hat.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("providerAvatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.11.3/css/jquery.dataTables.min.css\">\r\n");
#nullable restore
#line 2 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section>\r\n");
#nullable restore
#line 8 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
     if (TempData["RateMsg"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container d-flex justify-content-center\">\r\n            <div class=\"alert alert-success col-lg-6 bookalert\">\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>\r\n                <strong>");
#nullable restore
#line 13 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                   Write(TempData["RateMsg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 16 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</section>

<table class=""table service-table table-hover table-responsive-xl"" id=""service_history_table"">
    <thead>
        <tr>
            <th class=""table-heading"">Service ID </th>
            <th class=""table-heading"">Date </th>
            <th class=""table-heading"">Service Provider  </th>
            <th class=""table-heading"">Payment  </th>
            <th class=""table-heading"">Status  </th>
            <th class=""table-heading"">Rate SP</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 31 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
         foreach (var item in Model)
        {
            if (item.Status == 0 || item.Status == 2)
            {
                var total_time = item.ServiceHours + item.ExtraHours;
                decimal t = (decimal)total_time;
                TimeSpan span = new TimeSpan(0, Convert.ToInt32(total_time), Convert.ToInt32(t - Math.Truncate(t)) * 6, 0);
                var time = item.ServiceStartDate.Add(span).ToString("HH:mm");

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <input id=\"userId\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1609, "\"", 1629, 1);
#nullable restore
#line 41 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
WriteAttributeValue("", 1617, item.UserId, 1617, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <input id=\"spId\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1689, "\"", 1720, 1);
#nullable restore
#line 42 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
WriteAttributeValue("", 1697, item.ServiceProviderId, 1697, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <input id=\"serviceId\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1785, "\"", 1815, 1);
#nullable restore
#line 43 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
WriteAttributeValue("", 1793, item.ServiceRequestId, 1793, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        ");
#nullable restore
#line 44 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                   Write(item.ServiceRequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td");
            BeginWriteAttribute("onclick", " onclick=\"", 1919, "\"", 1970, 3);
            WriteAttributeValue("", 1929, "getServiceDetails(", 1929, 18, true);
#nullable restore
#line 46 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
WriteAttributeValue("", 1947, item.ServiceRequestId, 1947, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1969, ")", 1969, 1, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"service_details\">\r\n                        <div>\r\n                            <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "22896d9a017ef37e6f6c080833cf851d48d78da710158", async() => {
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
            WriteLiteral("</span>  <b>");
#nullable restore
#line 48 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                                                                           Write(item.ServiceStartDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n                        </div>\r\n                        <div>\r\n                            <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "22896d9a017ef37e6f6c080833cf851d48d78da711638", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>  ");
#nullable restore
#line 51 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                                                                       Write(item.ServiceStartDate.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 51 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                                                                                                                  Write(time);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 55 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                         if (item.ServiceProvider == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                ");
#nullable restore
#line 58 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                           Write(item.ServiceProviderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 60 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                         if (item.ServiceProvider != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"d-flex justify-content-between\">\r\n                                <div>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22896d9a017ef37e6f6c080833cf851d48d78da714722", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div>\r\n                                    ");
#nullable restore
#line 68 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                               Write(item.ServiceProvider.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 68 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                                                               Write(item.ServiceProvider.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 72 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n\r\n                    <td class=\"payment-clm\">");
#nullable restore
#line 76 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                                       Write(item.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span style=\"font-size:20px;\">₹</span></td>\r\n\r\n                    <td>\r\n");
#nullable restore
#line 79 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                         if (item.Status == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button class=\"cancelled-btn\">Cancelled</button>\r\n");
#nullable restore
#line 82 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                         if (item.Status == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button class=\"completed-btn\">Completed</button>\r\n");
#nullable restore
#line 86 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 90 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                         if (item.Status == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button class=\"rate-sp-disabled-btn\" id=\"rate_btn_val\" disabled> Rate SP</button>\r\n");
#nullable restore
#line 93 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                         if (item.Status == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button class=\"rate-sp-enabled-btn\" id=\"rate_btn_val\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4200, "\"", 4244, 3);
            WriteAttributeValue("", 4210, "callRateSp(", 4210, 11, true);
#nullable restore
#line 96 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
WriteAttributeValue("", 4221, item.ServiceRequestId, 4221, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4243, ")", 4243, 1, true);
            EndWriteAttribute();
            WriteLiteral("> Rate SP</button>\r\n");
#nullable restore
#line 97 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 100 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\ServiceHistoryTable.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </tbody>
</table>

<div class=""modal fade"" id=""servicedetails"" tabindex=""-1"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"">
        <div class=""modal-content"">

            <div class=""modal-header"">
                <h4 class=""modal-title"" style=""color:#646464""><b>Service Details</b></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <div class=""modal-body service-details-modal-body"">

                <div class=""d-flex justify-content-around"">
                    <h3 id=""serviceDate"" class=""font-weight-bold""></h3>
                    <h3 id=""servicetime"" class=""font-weight-bold ml""></h3>
                </div>

                <div class=""d-flex"">
                    <p class=""font-weight-bold"">Duration: </p>
                    <p id=""serviceduration""></p>
                    <p>Hrs</p>
                </div>
                <div class=""d-flex"">
                    <p class=""font-weight");
            WriteLiteral("-bold\">Service Id: </p>\r\n                    <p id=\"Service_id\"></p>\r\n                </div>\r\n");
            WriteLiteral(@"                <div class=""d-flex"">
                    <p class=""font-weight-bold"">Net amount:</p>
                    <p id=""net_amount""></p>
                    <p>₹</p>
                </div>

                <hr>
                <div class=""d-flex"">
                    <p class=""font-weight-bold"">Service Address: </p>
                    <p id=""Service_address""></p>
                </div>
                <div class=""d-flex"">
                    <p class=""font-weight-bold"">Billing Address:</p>
                    <p id=""billing_address"">Same as service address</p>
                </div>
                <div class=""d-flex"">
                    <p class=""font-weight-bold"">Phone: </p>
                    <p id=""phone""></p>
                </div>
                <div class=""d-flex"">
                    <p class=""font-weight-bold"">Comments: </p>
                    <p id=""comments""></p>
                </div>

            </div>


        </div>
    </div>
</div>

<div class=""mo");
            WriteLiteral(@"dal fade"" id=""rateSpModal"" tabindex=""-1"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">

            <div class=""modal-header"">
                <h4 class=""modal-title"" style=""color:#646464""><b>Rate Service Provider</b></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22896d9a017ef37e6f6c080833cf851d48d78da723227", async() => {
                WriteLiteral(@"
                <div class=""modal-body service-details-modal-body"">
                    <div class=""row justify-content-left form-group"">
                        <div class=""col-lg-3"">
                            On time Arrival
                        </div>
                        <div class=""col-lg-6 col-md-6 align-items-center"">
                            <div class=""form-group form-check-inline sp-radio"">
                                <input type=""radio"" id=""timimg"" value=""1"" name=""time"" class=""mr-1"" required=""required"" />1
                                <input type=""radio"" id=""timimg"" value=""2"" name=""time"" class=""mr-1 ml-3"" />2
                                <input type=""radio"" id=""timimg"" value=""3"" name=""time"" class=""mr-1 ml-3"" />3
                                <input type=""radio"" id=""timimg"" value=""4"" name=""time"" class=""mr-1 ml-3"" />4
                                <input type=""radio"" id=""timimg"" value=""5"" name=""time"" class=""mr-1 ml-3"" />5
                            </div>
    ");
                WriteLiteral(@"                    </div>
                    </div>

                    <div class=""row justify-content-left form-group"">
                        <div class=""col-lg-3"">
                            Friendly
                        </div>
                        <div class=""col-lg-6 col-md-6 align-items-center"">
                            <div class=""form-group form-check-inline sp-radio"">
                                <input type=""radio"" id=""friendly"" value=""1"" name=""friendlySp"" class=""mr-1"" required=""required"" />1
                                <input type=""radio"" id=""friendly"" value=""2"" name=""friendlySp"" class=""mr-1 ml-3"" />2
                                <input type=""radio"" id=""friendly"" value=""3"" name=""friendlySp"" class=""mr-1 ml-3"" />3
                                <input type=""radio"" id=""friendly"" value=""4"" name=""friendlySp"" class=""mr-1 ml-3"" />4
                                <input type=""radio"" id=""friendly"" value=""5"" name=""friendlySp"" class=""mr-1 ml-3"" />5
                    ");
                WriteLiteral(@"        </div>
                        </div>
                    </div>

                    <div class=""row justify-content-left form-group"">
                        <div class=""col-lg-3"">
                            Qaulity of service
                        </div>
                        <div class=""col-lg-6 col-md-6 align-items-center"">
                            <div class=""form-group form-check-inline sp-radio"">
                                <input type=""radio"" id=""qos"" value=""1"" name=""qosSp"" class=""mr-1"" required=""required"" />1
                                <input type=""radio"" id=""qos"" value=""2"" name=""qosSp"" class=""mr-1 ml-3"" />2
                                <input type=""radio"" id=""qos"" value=""3"" name=""qosSp"" class=""mr-1 ml-3"" />3
                                <input type=""radio"" id=""qos"" value=""4"" name=""qosSp"" class=""mr-1 ml-3"" />4
                                <input type=""radio"" id=""qos"" value=""5"" name=""qosSp"" class=""mr-1 ml-3"" />5
                            </div>
    ");
                WriteLiteral(@"                    </div>
                    </div>

                    <div class=""row justify-content-left form-group"">
                        <div class=""col-lg-12 col"">
                            <label>Feedback for service provider</label>
                            <textarea class=""form-control"" type=""text"" placeholder=""Feedback"" id=""spFeedback"" required></textarea>
                        </div>
                    </div>

                    <div class=""text-center"">
                        <div class=""row justify-content-left"">
                            <button");
                BeginWriteAttribute("value", " value=\"", 10674, "\"", 10682, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""check-zip-btn"" id=""saveRating_btn""
                                    onclick=""rateServiceProvider(
                                                            this.value,
                                                            $('#userId').val(),
                                                            $('#spId').val(),
                                                            $('#spFeedback').val(),
                                                            $('#timimg:checked').val(),
                                                            $('#friendly:checked').val(),
                                                            $('#qos:checked').val())"">
                                Submit
                            </button>
                        </div>
                    </div>
                </div>
            ");
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
</div>



<script type=""text/javascript"">
    function getServiceDetails(serviceId) {
        $.post(""/Customer/getService"", { Id: parseInt(serviceId) },
            function (data) {
                $('#serviceDate').html(data.serviceDate);
                $('#servicetime').html(data.serviceTime);
                $('#serviceduration').html(data.duration);
                $('#Service_id').html(data.serviceId);
                $('#net_amount').html(data.netAmount);
                $('#phone').html(data.phone);
                $('#email').html(data.email);
                $('#Service_address').html(data.serviceAddress);
                $('#comments').html(data.comments);
                $(""#servicedetails"").modal('show');
            });
    }

    function callRateSp(id) {
        $(""#saveRating_btn"").prop(""value"", id);
        $(""#rateSpModal"").modal('show');
    }

    function rateServiceProvider(Id, User, Sp, feedback, timing, friendly, qos) {
    ");
            WriteLiteral(@"    $.post(""/Customer/RateSp"", { Id: parseInt(Id), User: parseInt(User), ServiceProvider: parseInt(Sp), Feedback: feedback, Ontime: timing, Friend: friendly, QOS: qos },
            function (data) {
                $(""#rateSpModal"").modal('hide');
            });
    }

    $(document).ready(function () {
        $('#service_history_table').DataTable();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HelperLand.Models.ServiceRequest>> Html { get; private set; }
    }
}
#pragma warning restore 1591
