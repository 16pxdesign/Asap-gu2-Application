#pragma checksum "D:\github\Application\Views\Training\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f27e67645057d8c2feaa06b3ae2d8d05884883af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Training_Details), @"mvc.1.0.view", @"/Views/Training/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Training/Details.cshtml", typeof(AspNetCore.Views_Training_Details))]
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
#line 1 "D:\github\Application\Views\_ViewImports.cshtml"
using Application;

#line default
#line hidden
#line 2 "D:\github\Application\Views\_ViewImports.cshtml"
using Application.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f27e67645057d8c2feaa06b3ae2d8d05884883af", @"/Views/Training/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ea476b5db410d4405042b0a5ed991b4e6710c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Training_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Application.Models.TrainingViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Member", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\github\Application\Views\Training\Details.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(109, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(111, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f27e67645057d8c2feaa06b3ae2d8d05884883af4357", async() => {
                BeginContext(178, 14, true);
                WriteLiteral("< Back to list");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(196, 306, true);
            WriteLiteral(@"
<br/>


<div class=""card mt-3"">

    <div class=""card-body"">
        <dl class=""row"">

            <dd class=""col text-center"">
                <label>Training Details</label>
            </dd>
        </dl>
        <dl class=""row"">
            <dt class=""col-sm-2"">
                <label>");
            EndContext();
            BeginContext(503, 48, false);
#line 23 "D:\github\Application\Views\Training\Details.cshtml"
                  Write(Model.Date.ToString(string.Format("dd/MM/yyyy")));

#line default
#line hidden
            EndContext();
            BeginContext(551, 87, true);
            WriteLiteral("</label>\r\n            </dt>\r\n            <dd class=\"col-sm-2\">\r\n                <label>");
            EndContext();
            BeginContext(639, 43, false);
#line 26 "D:\github\Application\Views\Training\Details.cshtml"
                  Write(Model.Time.ToString(string.Format("HH:mm")));

#line default
#line hidden
            EndContext();
            BeginContext(682, 87, true);
            WriteLiteral("</label>\r\n            </dd>\r\n            <dd class=\"col-sm-4\">\r\n                <label>");
            EndContext();
            BeginContext(770, 20, false);
#line 29 "D:\github\Application\Views\Training\Details.cshtml"
                  Write(Model.Coach.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(790, 87, true);
            WriteLiteral("</label>\r\n            </dd>\r\n            <dd class=\"col-sm-4\">\r\n                <label>");
            EndContext();
            BeginContext(878, 14, false);
#line 32 "D:\github\Application\Views\Training\Details.cshtml"
                  Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(892, 197, true);
            WriteLiteral("</label>\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"card mt-3\">\r\n    <div class=\"card-body\">\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(1090, 32, false);
#line 42 "D:\github\Application\Views\Training\Details.cshtml"
           Write(Html.LabelFor(m => m.Activities));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 94, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                    \r\n                ");
            EndContext();
            BeginContext(1217, 79, false);
#line 46 "D:\github\Application\Views\Training\Details.cshtml"
           Write(Html.DisplayFor(m => m.Activities, "~/Views/Partial/Display/Activities.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 189, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"card mt-3\">\r\n    <div class=\"card-body\">\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(1486, 24, false);
#line 56 "D:\github\Application\Views\Training\Details.cshtml"
           Write(Html.Label("Attendance"));

#line default
#line hidden
            EndContext();
            BeginContext(1510, 94, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                    \r\n                ");
            EndContext();
            BeginContext(1605, 79, false);
#line 60 "D:\github\Application\Views\Training\Details.cshtml"
           Write(Html.DisplayFor(m => m.Attendance, "~/Views/Partial/Display/Attendance.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(1684, 56, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Application.Models.TrainingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
