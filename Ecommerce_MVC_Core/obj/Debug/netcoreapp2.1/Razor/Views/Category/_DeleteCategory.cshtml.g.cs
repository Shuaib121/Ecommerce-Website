#pragma checksum "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Category\_DeleteCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4acbdc0c45ebf4a2bd193ef0ae58f247315f6bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category__DeleteCategory), @"mvc.1.0.view", @"/Views/Category/_DeleteCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/_DeleteCategory.cshtml", typeof(AspNetCore.Views_Category__DeleteCategory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4acbdc0c45ebf4a2bd193ef0ae58f247315f6bb", @"/Views/Category/_DeleteCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdcfd767e355ea1f7fe3f76c8d3c44826b14e999", @"/Views/_ViewImports.cshtml")]
    public class Views_Category__DeleteCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1, 324, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93a1dc7217b24bae9f617c56a0f2b698", async() => {
                BeginContext(39, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(45, 75, false);
#line 3 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Category\_DeleteCategory.cshtml"
Write(Html.Partial("_ModalHeader", new ModalHeader { Heading = "Are you sure?" }));

#line default
#line hidden
                EndContext();
                BeginContext(120, 86, true);
                WriteLiteral("\n\n    <div class=\"modal-body form-horizontal\">\n        Are you want to delete <strong>");
                EndContext();
                BeginContext(207, 5, false);
#line 6 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Category\_DeleteCategory.cshtml"
                                  Write(Model);

#line default
#line hidden
                EndContext();
                BeginContext(212, 27, true);
                WriteLiteral("?</strong>\n    </div>\n\n    ");
                EndContext();
                BeginContext(240, 77, false);
#line 9 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Category\_DeleteCategory.cshtml"
Write(Html.Partial("_ModalFooter", new ModalFooter { SubmitButtonText = "Delete" }));

#line default
#line hidden
                EndContext();
                BeginContext(317, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
