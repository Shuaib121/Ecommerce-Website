#pragma checksum "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21f9af175899d8c4721e65add57437513b35e266"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21f9af175899d8c4721e65add57437513b35e266", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdcfd767e355ea1f7fe3f76c8d3c44826b14e999", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PROG7311_TASK2.ViewModel.ProductListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("createModel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddEditProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#modal-popUP"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetProdutcsImages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editUserModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteUserModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(104, 28, true);
            WriteLiteral("\n<div class=\"col-md-2\">\n    ");
            EndContext();
            BeginContext(132, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73e1603f76144f4c93a88a9b51447583", async() => {
                BeginContext(273, 57, true);
                WriteLiteral("\n        <i class=\"glyphicon glyphicon-plus\"></i>Add\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(334, 35, true);
            WriteLiteral("\n</div>\n<div class=\"col-md-3\">\n    ");
            EndContext();
            BeginContext(369, 379, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12e21d579ee24cdc97e6399aee74448c", async() => {
                BeginContext(428, 124, true);
                WriteLiteral("\n        <div class=\"form-horizontal\">\n            <div class=\"form-group\">\n                <input type=\"text\" name=\"search\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 552, "\"", 586, 1);
#line 15 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
WriteAttributeValue("", 560, Html.ViewBag.SearchString, 560, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(587, 154, true);
                WriteLiteral(" class=\"form-control\" />\n                <input type=\"submit\" value=\"Search\" class=\"btn btn-default pull-right\" />\n\n            </div>\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(748, 14, true);
            WriteLiteral("\n</div>\n<hr/>\n");
            EndContext();
#line 23 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
  
    if (Model.ToList().Count <= 0)
    {

#line default
#line hidden
            BeginContext(806, 38, true);
            WriteLiteral("        <h1>No Product Added Yet</h1>\n");
            EndContext();
#line 27 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(865, 460, true);
            WriteLiteral(@"        <table class=""table table-responsive table-hover"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Product</th>

                    <th>Info</th>
                    <th>Price</th>
                    <th>Stocks</th>
                    <th>Total Comments</th>
                    <th>Total Images</th>
                    <th>Action</th>
                </tr>
            </thead>

            <tbody>
");
            EndContext();
#line 46 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
              
                int count = 1;
                foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1433, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(1479, 5, false);
#line 51 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
                   Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1484, 71, true);
            WriteLiteral("</td>\n                    <td>\n                        <b>Product:</b> ");
            EndContext();
            BeginContext(1556, 9, false);
#line 53 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1565, 42, true);
            WriteLiteral(" <br />\n                    <b> Code:</b> ");
            EndContext();
            BeginContext(1608, 9, false);
#line 54 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
                             Write(item.Code);

#line default
#line hidden
            EndContext();
            BeginContext(1617, 45, true);
            WriteLiteral(" <br />\n                        <b> Tag:</b> ");
            EndContext();
            BeginContext(1663, 8, false);
#line 55 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
                                Write(item.Tag);

#line default
#line hidden
            EndContext();
            BeginContext(1671, 91, true);
            WriteLiteral("\n                    </td>\n                    <td>\n                      <b>Category</b>  ");
            EndContext();
            BeginContext(1763, 17, false);
#line 58 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
                                  Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(1780, 46, true);
            WriteLiteral(" <br />\n                        <b>Brand</b>  ");
            EndContext();
            BeginContext(1827, 14, false);
#line 59 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
                                 Write(item.BrandName);

#line default
#line hidden
            EndContext();
            BeginContext(1841, 98, true);
            WriteLiteral(" \n                    </td>\n                    <td>\n                        <b>Current Price</b> ");
            EndContext();
            BeginContext(1941, 32, false);
#line 62 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
                                         Write(Convert.ToInt32(item.FinalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1974, 52, true);
            WriteLiteral("<br />\n                        <b>Regular Price</b> ");
            EndContext();
            BeginContext(2027, 10, false);
#line 63 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
                                        Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2037, 2, true);
            WriteLiteral(" /");
            EndContext();
            BeginContext(2040, 13, false);
#line 63 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
                                                     Write(item.UnitName);

#line default
#line hidden
            EndContext();
            BeginContext(2053, 47, true);
            WriteLiteral("<br />\n                        <b>Discount</b> ");
            EndContext();
            BeginContext(2101, 13, false);
#line 64 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
                                   Write(item.Discount);

#line default
#line hidden
            EndContext();
            BeginContext(2114, 52, true);
            WriteLiteral("%\n                    </td>\n                    <td>");
            EndContext();
            BeginContext(2167, 18, false);
#line 66 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
                   Write(item.ProductStocks);

#line default
#line hidden
            EndContext();
            BeginContext(2185, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(2216, 20, false);
#line 67 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
                   Write(item.ProductComments);

#line default
#line hidden
            EndContext();
            BeginContext(2236, 55, true);
            WriteLiteral("</td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(2291, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0964fbda02247d0b2ab1ec443d15e71", async() => {
                BeginContext(2397, 15, false);
#line 69 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
                                                                                                                            Write(item.TotalImage);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
                                                                                WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2416, 68, true);
            WriteLiteral("\n                    </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2484, 263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e8bae477b24426e9fb428218b17f506", async() => {
                BeginContext(2649, 94, true);
                WriteLiteral("\n                        <i class=\"glyphicon glyphicon-pencil\"></i>  Edit\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
                                                                                            WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2747, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(2768, 244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08b03ce236be422196994f099b648248", async() => {
                BeginContext(2913, 95, true);
                WriteLiteral("\n                        <i class=\"glyphicon glyphicon-trash\"></i>  Delete\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3012, 45, true);
            WriteLiteral("\n                </td>\n                </tr>\n");
            EndContext();
#line 81 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
                    count++;
                }
            

#line default
#line hidden
            BeginContext(3118, 38, true);
            WriteLiteral("            </tbody>\n        </table>\n");
            EndContext();
#line 86 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(3165, 126, false);
#line 88 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Product\Index.cshtml"
Write(Html.Partial("_Modal", new BootstrapModel { ID = "modal-popUP", AreaLabeledId = "modal-popUP-label", Size = ModalSize.Large }));

#line default
#line hidden
            EndContext();
            BeginContext(3291, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PROG7311_TASK2.ViewModel.ProductListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591