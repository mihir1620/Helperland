#pragma checksum "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\User_Address.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cd4f32b35e49c99a00b36cab901d02862f76102"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_User_Address), @"mvc.1.0.view", @"/Views/Customer/User_Address.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cd4f32b35e49c99a00b36cab901d02862f76102", @"/Views/Customer/User_Address.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e66cca87be2827d8164341c70d0a69872a1e884f", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_User_Address : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HelperLand.Models.UserAddress>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/edit-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("edit-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("typeof", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/delete-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("delete-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-section"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addressForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/included.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:block;margin:auto;height:40px;width:40px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\User_Address.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table table-bordered\">\r\n    <thead class=\"table-active text-left\">\r\n        <tr>\r\n            <th class=\"col-lg-9\">Address</th>\r\n            <th class=\"col-lg-2\">Actions</th>\r\n        </tr>\r\n    </thead>\r\n\r\n\r\n\r\n");
#nullable restore
#line 17 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\User_Address.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n\r\n            <tr>\r\n                <td>\r\n                    <div>\r\n                        <span> <b>Address</b>: : ");
#nullable restore
#line 24 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\User_Address.cshtml"
                                            Write(item.AddressLine1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\User_Address.cshtml"
                                                               Write(item.AddressLine2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\User_Address.cshtml"
                                                                                  Write(item.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div>\r\n                        <span> <b>Phone number</b>:");
#nullable restore
#line 27 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\User_Address.cshtml"
                                              Write(item.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </td>\r\n                <td class=\"details\">\r\n                    <div>\r\n                        <div class=\"d-flex justify-content-around\">\r\n                            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 893, "\"", 935, 3);
            WriteAttributeValue("", 903, "callEditAddress(", 903, 16, true);
#nullable restore
#line 33 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\User_Address.cshtml"
WriteAttributeValue("", 919, item.AddressId, 919, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 934, ")", 934, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 936, "\"", 959, 1);
#nullable restore
#line 33 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\User_Address.cshtml"
WriteAttributeValue("", 944, item.AddressId, 944, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6cd4f32b35e49c99a00b36cab901d02862f7610210206", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </button>\r\n                            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1138, "\"", 1182, 3);
            WriteAttributeValue("", 1148, "callDeleteAddress(", 1148, 18, true);
#nullable restore
#line 36 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\User_Address.cshtml"
WriteAttributeValue("", 1166, item.AddressId, 1166, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1181, ")", 1181, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1183, "\"", 1206, 1);
#nullable restore
#line 36 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\User_Address.cshtml"
WriteAttributeValue("", 1191, item.AddressId, 1191, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6cd4f32b35e49c99a00b36cab901d02862f7610212376", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </button>\r\n                        </div>\r\n\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n\r\n        </tbody>\r\n");
#nullable restore
#line 46 "D:\Helperland\helperland\HelperLand\HelperLand\Views\Customer\User_Address.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</table>

<!--Edit Add popup start-->
<div class=""modal fade"" id=""editAddressModal2"" tabindex=""-1"">
    <div class=""modal-dialog modal-dialog-centered address-modal"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" style=""color:#646464""><b>Edit Address</b></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <div class=""modal-body address-modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cd4f32b35e49c99a00b36cab901d02862f7610214504", async() => {
                WriteLiteral(@"

                    <div class=""row"">
                        <div class=""col-lg-6"">
                            <div class=""form-group"">
                                <label>Street Name</label>
                                <input type=""text"" class=""form-control"" placeholder=""Enter Street Name"" id=""street"">
                            </div>

                        </div>

                        <div class=""col-lg-6"">
                            <div class=""form-group"">
                                <label>House Number</label>
                                <input type=""text"" class=""form-control"" placeholder=""Enter House Number"" id=""house_no"">
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-lg-6"">
                            <div class=""form-group"">
                                <label>Postal code</label>
                                <input type=""tex");
                WriteLiteral(@"t"" class=""form-control"" placeholder=""Enter Postalcode"" id=""postalcode"">
                            </div>
                        </div>
                        <div class=""col-lg-6"">
                            <div class=""form-group"">
                                <label>City</label>
                                <input type=""text"" class=""form-control"" placeholder=""Enter City"" id=""city"">
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-lg-6"">
                            <div class=""form-group"">
                                <label>Phone no</label>
                                <div class=""form-group mt-2"">
                                    <div class=""input-group "">
                                        <div class=""input-group-prepend"">
                                            <div class=""input-group-text"">+49</div>
                                      ");
                WriteLiteral(@"  </div>
                                        <input class=""form-control"" type=""tel"" id=""MobileNo"" placeholder=""Mobile Number"">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row justify-content-center"">
                        <button class=""saveAdd1""");
                BeginWriteAttribute("value", " value=\"", 4525, "\"", 4533, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"editAddbtn\" onclick=\"SaveEditAddress(this.value,$(\'#street\').val(),$(\'#house_no\').val(),$(\'#city\').val(),$(\'#postalcode\').val(),$(\'#MobileNo\').val())\">Update</button>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
</div>
<!--Edit add popup ends-->
<!--update add popup success starts-->
<div class=""modal fade"" id=""updatedAddressModal"" tabindex=""-1"">
    <div class=""modal-dialog modal-dialog-centered  modal-sm"">
        <div class=""modal-content"">

            <div class=""modal-header"">
                <h4 class=""modal-title"" style=""color:#646464""><b>Delete Address</b></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <div class=""modal-body address-modal-body"">
                <div class=""form-section"">
                    <div class=""text-center"">
                        Your Address updated successfully
                    </div>
                    <div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6cd4f32b35e49c99a00b36cab901d02862f7610219757", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
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
        </div>
    </div>
</div>
<!--update add success popup ends-->
<!--delete add modal starts-->
<div class=""modal fade"" id=""deleteAddModal"" tabindex=""-1"">
    <div class=""modal-dialog modal-dialog-centered "">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" style=""color:#646464""><b>Cancel Service Request</b></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <div class=""modal-body address-modal-body"">
                <div class=""form-section"">
                    <div class=""text-center"">
                        <h4>Are you sure you want to delete this address?</h4>
                    </div>
                </div>
            </div>

            <div class=""modal-body address-modal-body"">
                <div class=""form-section"">
                    <div class=""row ju");
            WriteLiteral("stify-content-center\">\r\n                        <button");
            BeginWriteAttribute("value", " value=\"", 6752, "\"", 6760, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control saveAdd1"" id=""delete_btn"" onclick=""DeleteAddress(this.value)"">Delete</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!--delete add modal ends-->
<!--Delete add success popup starts-->
<div class=""modal fade"" id=""deletedAddressModal"" tabindex=""-1"">
    <div class=""modal-dialog modal-dialog-centered  modal-sm"">
        <div class=""modal-content"">

            <div class=""modal-header"">
                <h4 class=""modal-title"" style=""color:#646464""><b>Delete Address</b></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>

            <div class=""modal-body address-modal-body"">
                <div class=""form-section"">
                    <div class=""text-center"">
                        Your Address deleted successfully
                    </div>
                    <div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6cd4f32b35e49c99a00b36cab901d02862f7610223166", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
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
        </div>
    </div>
</div>
<!--Delete add success popup ends-->


<script type=""text/javascript"">

    function callEditAddress(id) {

        $(""#editAddbtn"").prop(""value"", id);

        $.get(""/Customer/EditAddress"", { Id: parseInt(id) },

            function (data) {
                
                $('#street').val(data.addressLine1);
                $('#house_no').val(data.addressLine2);
                $('#postalcode').val(data.postalcode);
                $('#city').val(data.city);
                $('#MobileNo').val(data.mobile);
                $(""#editAddressModal2"").modal('show');
            });

    }

    function SaveEditAddress(AddressId, line1, line2, city, postalcode, mobile) {
        $.post(""/Customer/SaveEditAddress"", { Id: parseInt(AddressId), addLine1: line1, addLine2: line2, userCity: city, userPostalcode: postalcode, userMobile: mobile },

            function (data) {
       ");
            WriteLiteral(@"         $(""#editAddressModal2"").modal('hide');
                $(""#deletedAddressModal"").modal('show');
            });
    }

    function callDeleteAddress(id) {
        $(""#delete_btn"").prop(""value"", id);
        $(""#deleteAddModal"").modal('show');
    }

    function DeleteAddress(AddressId) {
        $.post(""/Customer/DeleteAddress"", { Id: parseInt(AddressId) },
            function (data) {
                $(""#deleteAddModal"").modal('hide');
                $(""#deletedAddressModal"").modal('show');
            });
    }

</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HelperLand.Models.UserAddress>> Html { get; private set; }
    }
}
#pragma warning restore 1591
