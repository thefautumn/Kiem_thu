#pragma checksum "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93e84dd52cbf4cb83d15192d651c1a05828df616"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminProducts_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminProducts/Details.cshtml")]
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
#line 1 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\_ViewImports.cshtml"
using dapm_final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\_ViewImports.cshtml"
using dapm_final.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93e84dd52cbf4cb83d15192d651c1a05828df616", @"/Areas/Admin/Views/AdminProducts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de7bca1180a586702ce5be81b08789727cd7be9f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminProducts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dapm_final.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
  
    ViewData["Title"] = "Chi Tiết Sản Phẩm " + Model.ProductName;
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <div class=\"header-sub-title\">\r\n        <nav class=\"breadcrumb breadcrumb-dash\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93e84dd52cbf4cb83d15192d651c1a05828df6166769", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Trang Chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93e84dd52cbf4cb83d15192d651c1a05828df6168472", async() => {
                WriteLiteral("Danh Sách Sản Phẩm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <span class=\"breadcrumb-item active\">Thông Tin Sản Phẩm: ");
#nullable restore
#line 13 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                                                                Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
        </nav>
    </div>
</div>

<div class=""page-header no-gutters has-tab"">
    <div class=""d-md-flex m-b-15 align-items-center justify-content-between"">
        <div class=""media align-items-center m-b-15"">
            <div class=""avatar avatar-image rounded"" style=""height:70px; width:70px"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "93e84dd52cbf4cb83d15192d651c1a05828df61610840", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1011, "~/images/products/", 1011, 18, true);
#nullable restore
#line 22 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
AddHtmlAttributeValue("", 1029, Model.Thumb, 1029, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 22 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
AddHtmlAttributeValue("", 1048, Model.Title, 1048, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"m-l-15\">\r\n                <h4 class=\"m-b-0\">");
#nullable restore
#line 25 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                             Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p class=\"text-muted m-b-0\">ID: #");
#nullable restore
#line 26 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                                            Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"m-b-15\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93e84dd52cbf4cb83d15192d651c1a05828df61613617", async() => {
                WriteLiteral("Chỉnh Sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                                                                                                           WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"card-body\">\r\n    <h4 class=\"card-title\">Thông Tin Sản Phẩm: ");
#nullable restore
#line 36 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                                          Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <div class=\"table-responsive\">\r\n        <table class=\"product-info-table m-t-20\">\r\n            <tbody>\r\n                <tr>\r\n                    <td>ID:</td>\r\n                    <td class=\"text-dark font-weight-semibold\">");
#nullable restore
#line 42 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                                                          Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Tên Sản Phẩm:</td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Mô Tả Ngắn:</td>\r\n                    <td>");
#nullable restore
#line 50 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Giá:</td>\r\n                    <td>");
#nullable restore
#line 54 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Discount:</td>\r\n                    <td>");
#nullable restore
#line 58 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Trạng Thái:</td>\r\n                    <td>\r\n");
#nullable restore
#line 63 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                         if (Model.Active)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"switch m-r-10\">\r\n                                <input type=\"checkbox\" id=\"switch-1\"");
            BeginWriteAttribute("checked", " checked=\"", 2688, "\"", 2698, 0);
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n                                <label for=\"switch-1\"></label>\r\n                            </div>\r\n");
#nullable restore
#line 69 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"switch m-r-10\">\r\n                                <input type=\"checkbox\" id=\"switch-1\" disabled />\r\n                                <label for=\"switch-1\"></label>\r\n                            </div>\r\n");
#nullable restore
#line 76 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Bestseller:</td>\r\n                    <td>\r\n");
#nullable restore
#line 82 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                         if (Model.BestSellers)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"switch m-r-10\">\r\n                                <input type=\"checkbox\" id=\"switch-1\"");
            BeginWriteAttribute("checked", " checked=\"", 3504, "\"", 3514, 0);
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n                                <label for=\"switch-1\"></label>\r\n                            </div>\r\n");
#nullable restore
#line 88 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"switch m-r-10\">\r\n                                <input type=\"checkbox\" id=\"switch-1\" disabled />\r\n                                <label for=\"switch-1\"></label>\r\n                            </div>\r\n");
#nullable restore
#line 95 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>HomeFlag:</td>\r\n                    <td>\r\n");
#nullable restore
#line 101 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                         if (Model.HomeFlag)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"switch m-r-10\">\r\n                                <input type=\"checkbox\" id=\"switch-1\"");
            BeginWriteAttribute("checked", " checked=\"", 4315, "\"", 4325, 0);
            EndWriteAttribute();
            WriteLiteral(" disabled />\r\n                                <label for=\"switch-1\"></label>\r\n                            </div>\r\n");
#nullable restore
#line 107 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"switch m-r-10\">\r\n                                <input type=\"checkbox\" id=\"switch-1\" disabled />\r\n                                <label for=\"switch-1\"></label>\r\n                            </div>\r\n");
#nullable restore
#line 114 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Danh Mục:</td>\r\n                    <td>");
#nullable restore
#line 120 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.Cat.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Ngày Tạo:</td>\r\n                    <td>");
#nullable restore
#line 124 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Ngày Chỉnh Sửa:</td>\r\n                    <td>");
#nullable restore
#line 128 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.DateModified);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Tiêu Đề:</td>\r\n                    <td>");
#nullable restore
#line 132 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>MetaDesc:</td>\r\n                    <td>");
#nullable restore
#line 136 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.MetaDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>MetaKey:</td>\r\n                    <td>");
#nullable restore
#line 140 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.MetaKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Tags:</td>\r\n                    <td>");
#nullable restore
#line 144 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Model.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Ảnh Đại Diện:</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "93e84dd52cbf4cb83d15192d651c1a05828df61626458", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5912, "~/images/products/", 5912, 18, true);
#nullable restore
#line 149 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
AddHtmlAttributeValue("", 5930, Model.Thumb, 5930, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 149 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
AddHtmlAttributeValue("", 5949, Model.Title, 5949, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Mô Tả Sản Phẩm:</td>\r\n                    <td>");
#nullable restore
#line 154 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Areas\Admin\Views\AdminProducts\Details.cshtml"
                   Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dapm_final.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
