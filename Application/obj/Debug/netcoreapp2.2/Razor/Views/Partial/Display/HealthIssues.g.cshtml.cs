#pragma checksum "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Display\HealthIssues.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edc08bbbb7cf9582d010e76df95797a0148c8e48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partial_Display_HealthIssues), @"mvc.1.0.view", @"/Views/Partial/Display/HealthIssues.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Partial/Display/HealthIssues.cshtml", typeof(AspNetCore.Views_Partial_Display_HealthIssues))]
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
#line 1 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\_ViewImports.cshtml"
using Application;

#line default
#line hidden
#line 2 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\_ViewImports.cshtml"
using Application.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edc08bbbb7cf9582d010e76df95797a0148c8e48", @"/Views/Partial/Display/HealthIssues.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ea476b5db410d4405042b0a5ed991b4e6710c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Partial_Display_HealthIssues : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HealthIssueViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Display\HealthIssues.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(70, 157, true);
            WriteLiteral("    <div class=\"card mt-3\">\r\n        <div class=\"card-body\">\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                   <label>");
            EndContext();
            BeginContext(228, 32, false);
#line 9 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Display\HealthIssues.cshtml"
                     Write(item.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(260, 92, true);
            WriteLiteral("</label>\r\n                </dt>\r\n                <dd class=\"col-sm-3\">\r\n                    ");
            EndContext();
            BeginContext(353, 9, false);
#line 12 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Display\HealthIssues.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(362, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dd class=\"col-sm-3\">\r\n                    ");
            EndContext();
            BeginContext(447, 16, false);
#line 15 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Display\HealthIssues.cshtml"
               Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(463, 72, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 20 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Display\HealthIssues.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HealthIssueViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
