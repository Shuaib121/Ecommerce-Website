#pragma checksum "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Shared\_Modal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffae9de4d57171012239d91705b650750421c2fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Modal), @"mvc.1.0.view", @"/Views/Shared/_Modal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Modal.cshtml", typeof(AspNetCore.Views_Shared__Modal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffae9de4d57171012239d91705b650750421c2fc", @"/Views/Shared/_Modal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdcfd767e355ea1f7fe3f76c8d3c44826b14e999", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Modal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROG7311_TASK2.BootstrapModal.BootstrapModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 24, true);
            WriteLiteral("\n<div aria-hidden=\"true\"");
            EndContext();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 76, "\"", 114, 1);
#line 3 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Shared\_Modal.cshtml"
WriteAttributeValue("", 94, Model.AreaLabeledId, 94, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(115, 28, true);
            WriteLiteral(" role=\"dialog\" tabindex=\"-1\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 143, "\"", 157, 1);
#line 3 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Shared\_Modal.cshtml"
WriteAttributeValue("", 148, Model.ID, 148, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(158, 29, true);
            WriteLiteral(" class=\"modal fade\">\n    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 187, "\"", 229, 2);
            WriteAttributeValue("", 195, "modal-dialog", 195, 12, true);
#line 4 "C:\Users\Shuaib\Desktop\All Assignments\PROG7311 _TASK2\Ecommerce_MVC_Core\Views\Shared\_Modal.cshtml"
WriteAttributeValue(" ", 207, Model.ModalSizeClass, 208, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(230, 71, true);
            WriteLiteral(">\n        <div class=\"modal-content\">\n        </div>\n    </div>\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROG7311_TASK2.BootstrapModal.BootstrapModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
