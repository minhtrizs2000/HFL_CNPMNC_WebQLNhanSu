#pragma checksum "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "165113f3a5100af02629c6a1054fe43da7bb5f3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChamCong_Index), @"mvc.1.0.view", @"/Views/ChamCong/Index.cshtml")]
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
#line 1 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\_ViewImports.cshtml"
using Web_QLNS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\_ViewImports.cshtml"
using Web_QLNS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"165113f3a5100af02629c6a1054fe43da7bb5f3c", @"/Views/ChamCong/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7f522e8760bb0d4567268c7066b32b520c29787", @"/Views/_ViewImports.cshtml")]
    public class Views_ChamCong_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web_QLNS.Controllers.ViewModelCC>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "NhanVien", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PhongBan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ChucVu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Luong", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ChamCong", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DanhGia", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
  
    ViewData["Title"] = "Chấm công";
    Layout = "_Layout";

    DateTime now = DateTime.Now;
    QLNSContext database = new QLNSContext();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    table {
      overflow: hidden;
    }

    tr:hover {
      background-color: #FE9A2E50;
    }

    td, th {
      position: relative;
    }
    td:hover::after,
    th:hover::after {
      content: """";
      position: absolute;
      background-color: #FE9A2E50;
      left: 0;
      top: -5000px;
      height: 10000px;
      width: 100%;
      z-index: -1;
    }
</style>

<div class=""col-md-2"">
    <div id=""mySideBar"">
        <ul>
            <li><h3><i class=""fa fa-tasks""></i>Tác vụ</h3></li>
            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "165113f3a5100af02629c6a1054fe43da7bb5f3c6146", async() => {
                WriteLiteral("<i class=\"fa fa-user-alt\"></i>Quản lý nhân viên");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 40 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
AddHtmlAttributeValue("", 811, ViewContext.RouteData.Values["Controller"].ToString() == "NhanVien" ? "active" : "", 811, 86, false);

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
            WriteLiteral("</li>\r\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "165113f3a5100af02629c6a1054fe43da7bb5f3c8103", async() => {
                WriteLiteral("<i class=\"fa fa-door-open\"></i>Quản lý phòng ban");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 41 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
AddHtmlAttributeValue("", 1028, ViewContext.RouteData.Values["Controller"].ToString() == "PhongBan" ? "active" : "", 1028, 86, false);

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
            WriteLiteral("</li>\r\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "165113f3a5100af02629c6a1054fe43da7bb5f3c10063", async() => {
                WriteLiteral("<i class=\"fa fa-chair\"></i>Quản lý chức vụ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 42 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
AddHtmlAttributeValue("", 1244, ViewContext.RouteData.Values["Controller"].ToString() == "ChucVu" ? "active" : "", 1244, 84, false);

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
            WriteLiteral("</li>\r\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "165113f3a5100af02629c6a1054fe43da7bb5f3c12016", async() => {
                WriteLiteral("<i class=\"fa fa-donate\"></i>Quản lý lương");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 43 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
AddHtmlAttributeValue("", 1451, ViewContext.RouteData.Values["Controller"].ToString() == "Luong" ? "active" : "", 1451, 83, false);

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
            WriteLiteral("</li>\r\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "165113f3a5100af02629c6a1054fe43da7bb5f3c13967", async() => {
                WriteLiteral("<i class=\"fa fa-calendar-check\"></i>Quản lý chấm công");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 44 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
AddHtmlAttributeValue("", 1659, ViewContext.RouteData.Values["Controller"].ToString() == "ChamCong" ? "active" : "", 1659, 86, false);

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
            WriteLiteral("</li>\r\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "165113f3a5100af02629c6a1054fe43da7bb5f3c15933", async() => {
                WriteLiteral("<i class=\"fa fa-child\"></i>Quản lý đánh giá");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 45 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
AddHtmlAttributeValue("", 1881, ViewContext.RouteData.Values["Controller"].ToString() == "DanhGia" ? "active" : "", 1881, 85, false);

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
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"col-md-10\">\r\n    <div class=\"myBodyContent\" style=\"overflow-x: scroll\">\r\n        <div class=\"myTableTitle\">\r\n            <h3>Bảng chấm công tháng ");
#nullable restore
#line 53 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                                Write(now.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h3>
        </div>
        <br />
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        ID
                    </th>
                    <th>
                        Tên NV
                    </th>
");
#nullable restore
#line 65 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                      
                        int day = 0;
                        switch (now.Month)
                        {
                            case 4:
                            case 6:
                            case 9:
                            case 11:
                                {
                                    day = 30;
                                    for (int i = 1; i <= day; i++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <th>\r\n                                            ");
#nullable restore
#line 78 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 78 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                                          Write(now.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n");
#nullable restore
#line 80 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    day = 30;
                                    for (int i = 1; i <= day; i++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <th>\r\n                                            ");
#nullable restore
#line 89 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 89 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                                          Write(now.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n");
#nullable restore
#line 91 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                                    }
                                    break;
                                }
                            default:
                                {
                                    day = 30;
                                    for (int i = 1; i <= day; i++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <th>\r\n                                            ");
#nullable restore
#line 100 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 100 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                                          Write(now.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n");
#nullable restore
#line 102 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                                    }
                                    break;
                                }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 110 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                 foreach (var nv in Model.ListNhanVien)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 114 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => nv.Idnv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 117 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => nv.TenNv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 119 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                         for(var d = 1; d <= day; d++)
                        {
                            ChamCong cc = database.ChamCongs.Where(s => s.Idnv == nv.Idnv && s.Ngay.Month == now.Month && s.Ngay.Day == d).FirstOrDefault();
                            if (cc != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <input type=\"checkbox\" checked onclick=\"return false;\" />\r\n                                </td>\r\n");
#nullable restore
#line 127 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <input type=\"checkbox\" onclick=\"return false;\" />\r\n                                </td>\r\n");
#nullable restore
#line 133 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 136 "D:\SCHOOLS\HUFLIT\WEBNC\PF_Project\Web_QLNS\Web_QLNS\Views\ChamCong\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web_QLNS.Controllers.ViewModelCC> Html { get; private set; }
    }
}
#pragma warning restore 1591
