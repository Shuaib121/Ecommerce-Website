#pragma checksum "C:\Users\Shuaib\Desktop\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Shared\Components\GetHeaderMainMenu\MainMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7d4d86d40bc5b45aedd3b58d900ba7f7810153a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GetHeaderMainMenu_MainMenu), @"mvc.1.0.view", @"/Views/Shared/Components/GetHeaderMainMenu/MainMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/GetHeaderMainMenu/MainMenu.cshtml", typeof(AspNetCore.Views_Shared_Components_GetHeaderMainMenu_MainMenu))]
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
#line 1 "C:\Users\Shuaib\Desktop\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core;

#line default
#line hidden
#line 2 "C:\Users\Shuaib\Desktop\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.Models;

#line default
#line hidden
#line 4 "C:\Users\Shuaib\Desktop\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using System.Collections;

#line default
#line hidden
#line 5 "C:\Users\Shuaib\Desktop\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.BootstrapModal;

#line default
#line hidden
#line 6 "C:\Users\Shuaib\Desktop\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.Code;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7d4d86d40bc5b45aedd3b58d900ba7f7810153a", @"/Views/Shared/Components/GetHeaderMainMenu/MainMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71cfa9c3ae2f1e0493d4ca25e3a3394ef37b5862", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_GetHeaderMainMenu_MainMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<Ecommerce_MVC_Core.ViewModel.CategoryViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(" "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(87, 7, true);
            WriteLiteral("\n\n\n   \n");
            EndContext();
#line 6 "C:\Users\Shuaib\Desktop\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Shared\Components\GetHeaderMainMenu\MainMenu.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(124, 164, true);
            WriteLiteral("<li class=\"dropdown menu__item\">\n    <a href=\"#\" class=\"dropdown-toggle menu__link\" data-toggle=\"dropdown\" role=\"button\" aria-haspopup=\"true\" aria-expanded=\"false\">");
            EndContext();
            BeginContext(289, 9, false);
#line 8 "C:\Users\Shuaib\Desktop\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Shared\Components\GetHeaderMainMenu\MainMenu.cshtml"
                                                                                                                              Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(298, 215, true);
            WriteLiteral(" <span class=\"caret\"></span></a>\n    <ul class=\"dropdown-menu multi-column columns-3\">\n        <div class=\"agile_inner_drop_nav_info\">\n            <div class=\"col-sm-6 multi-gd-img1 multi-gd-text \">\n                ");
            EndContext();
            BeginContext(513, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5de2edb4bc354a83bc6160e13f5fd0a2", async() => {
                BeginContext(589, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "281e7b4d2f52464893b7bcbf9e8fbac0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 599, "~/images/public/", 599, 16, true);
#line 12 "C:\Users\Shuaib\Desktop\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Shared\Components\GetHeaderMainMenu\MainMenu.cshtml"
AddHtmlAttributeValue("", 615, item.Name+".jpg", 615, 19, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 12 "C:\Users\Shuaib\Desktop\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Shared\Components\GetHeaderMainMenu\MainMenu.cshtml"
                                                                      WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(650, 20, true);
            WriteLiteral("\n            </div>\n");
            EndContext();
            BeginContext(707, 284, true);
            WriteLiteral(@"            <div class=""col-sm-6 multi-gd-img"">
                <ul class=""multi-column-dropdown"">
                    <div class=""col-sm-3 multi-gd-img"">
        
                        <ul class=""multi-column-dropdown"">
                            <li>
                            ");
            EndContext();
            BeginContext(992, 78, false);
#line 25 "C:\Users\Shuaib\Desktop\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Shared\Components\GetHeaderMainMenu\MainMenu.cshtml"
                       Write(await Component.InvokeAsync("GetHeaderMainMenu", new { categoryId = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 190, true);
            WriteLiteral("\n                            </li>\n                        </ul>\n           \n                    </div>\n                       \n                    \n                </ul>\n            </div>\n");
            EndContext();
            BeginContext(1274, 78, true);
            WriteLiteral("\n            <div class=\"clearfix\"></div>\n        </div>\n    </ul>\n\n    </li>\n");
            EndContext();
#line 41 "C:\Users\Shuaib\Desktop\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Shared\Components\GetHeaderMainMenu\MainMenu.cshtml"

    }

#line default
#line hidden
            BeginContext(1359, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<Ecommerce_MVC_Core.ViewModel.CategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
