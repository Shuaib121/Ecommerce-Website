#pragma checksum "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\OrderDetailsAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f982431b79c749963ec0ec523c32df6c932843a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderDetailsAdmin_Index), @"mvc.1.0.view", @"/Views/OrderDetailsAdmin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrderDetailsAdmin/Index.cshtml", typeof(AspNetCore.Views_OrderDetailsAdmin_Index))]
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
#line 1 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using PROG7311_TASK2;

#line default
#line hidden
#line 2 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using PROG7311_TASK2.Models;

#line default
#line hidden
#line 4 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using System.Collections;

#line default
#line hidden
#line 5 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using PROG7311_TASK2.BootstrapModal;

#line default
#line hidden
#line 6 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using PROG7311_TASK2.Code;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f982431b79c749963ec0ec523c32df6c932843a", @"/Views/OrderDetailsAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdcfd767e355ea1f7fe3f76c8d3c44826b14e999", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderDetailsAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PROG7311_TASK2.ViewModel.OrderDetailsListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteUserModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#modal-popUP"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\OrderDetailsAdmin\Index.cshtml"
  
    ViewData["Title"] = "Order Details";

#line default
#line hidden
            BeginContext(117, 29, true);
            WriteLiteral("\n\n<div class=\"col-md-3\">\n    ");
            EndContext();
            BeginContext(146, 379, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37a11bb627b74d81be3379c571b3d505", async() => {
                BeginContext(205, 124, true);
                WriteLiteral("\n        <div class=\"form-horizontal\">\n            <div class=\"form-group\">\n                <input type=\"text\" name=\"search\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 329, "\"", 363, 1);
#line 11 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\OrderDetailsAdmin\Index.cshtml"
WriteAttributeValue("", 337, Html.ViewBag.SearchString, 337, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(364, 154, true);
                WriteLiteral(" class=\"form-control\" />\n                <input type=\"submit\" value=\"Search\" class=\"btn btn-default pull-right\" />\n\n            </div>\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(525, 15, true);
            WriteLiteral("\n</div>\n<hr />\n");
            EndContext();
#line 19 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\OrderDetailsAdmin\Index.cshtml"
  
    if (Model.ToList().Count <= 0)
    {

#line default
#line hidden
            BeginContext(584, 35, true);
            WriteLiteral("        <h1>No one orders Yet</h1>\n");
            EndContext();
#line 23 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\OrderDetailsAdmin\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(640, 385, true);
            WriteLiteral(@"        <table class=""table table-responsive table-hover"">
            <thead>
            <tr>
                <th>#</th>
                <th>Product</th>

                <th>Order Number</th>
                <th>Quantity</th>
                <th>Total</th>
                <th>Reamrks</th>
                <th>Action</th>
            </tr>
            </thead>

            <tbody>
");
            EndContext();
#line 41 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\OrderDetailsAdmin\Index.cshtml"
              
                int count = 1;
                foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1133, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(1187, 5, false);
#line 46 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\OrderDetailsAdmin\Index.cshtml"
                       Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1192, 63, true);
            WriteLiteral("</td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1256, 16, false);
#line 48 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\OrderDetailsAdmin\Index.cshtml"
                       Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1272, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1361, 16, false);
#line 51 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\OrderDetailsAdmin\Index.cshtml"
                       Write(item.OrderNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1377, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1466, 13, false);
#line 54 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\OrderDetailsAdmin\Index.cshtml"
                       Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1479, 59, true);
            WriteLiteral("\n                        </td>\n                        <td>");
            EndContext();
            BeginContext(1539, 9, false);
#line 56 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\OrderDetailsAdmin\Index.cshtml"
                       Write(item.Rate);

#line default
#line hidden
            EndContext();
            BeginContext(1548, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1583, 12, false);
#line 57 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\OrderDetailsAdmin\Index.cshtml"
                       Write(item.Remarks);

#line default
#line hidden
            EndContext();
            BeginContext(1595, 88, true);
            WriteLiteral("</td>\n                        \n                        <td>\n                            ");
            EndContext();
            BeginContext(1683, 260, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed42adf193894d8789a373c34381b825", async() => {
                BeginContext(1828, 111, true);
                WriteLiteral("\n                                <i class=\"glyphicon glyphicon-trash\"></i>  Delete\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\OrderDetailsAdmin\Index.cshtml"
                                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1943, 57, true);
            WriteLiteral("\n                        </td>\n                    </tr>\n");
            EndContext();
#line 65 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\OrderDetailsAdmin\Index.cshtml"
                    count++;
                }
            

#line default
#line hidden
            BeginContext(2061, 38, true);
            WriteLiteral("            </tbody>\n        </table>\n");
            EndContext();
#line 70 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\OrderDetailsAdmin\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2107, 1, true);
            WriteLiteral("\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PROG7311_TASK2.ViewModel.OrderDetailsListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
