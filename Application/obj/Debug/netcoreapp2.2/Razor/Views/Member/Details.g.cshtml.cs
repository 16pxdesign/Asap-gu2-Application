#pragma checksum "D:\github\Application\Views\Member\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cd8a3fdaa9922abe8926f8f04ee4a6e29368db0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_Details), @"mvc.1.0.view", @"/Views/Member/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Member/Details.cshtml", typeof(AspNetCore.Views_Member_Details))]
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
#line 1 "D:\github\Application\Views\Member\Details.cshtml"
using Application.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cd8a3fdaa9922abe8926f8f04ee4a6e29368db0", @"/Views/Member/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ea476b5db410d4405042b0a5ed991b4e6710c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MemberViewModel>
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\github\Application\Views\Member\Details.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(120, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(127, 9, false);
#line 9 "D:\github\Application\Views\Member\Details.cshtml"
Write(Model.SRU);

#line default
#line hidden
            EndContext();
            BeginContext(136, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(140, 10, false);
#line 9 "D:\github\Application\Views\Member\Details.cshtml"
            Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(150, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(152, 13, false);
#line 9 "D:\github\Application\Views\Member\Details.cshtml"
                        Write(Model.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(165, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(174, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cd8a3fdaa9922abe8926f8f04ee4a6e29368db05345", async() => {
                BeginContext(241, 14, true);
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
            BeginContext(259, 135, true);
            WriteLiteral("\r\n\r\n<div class=\"card mt-3\">\r\n    <div class=\"card-body\">\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(395, 19, false);
#line 17 "D:\github\Application\Views\Member\Details.cshtml"
           Write(Html.LabelFor(m=>m));

#line default
#line hidden
            EndContext();
            BeginContext(414, 72, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
            EndContext();
            BeginContext(487, 71, false);
#line 20 "D:\github\Application\Views\Member\Details.cshtml"
           Write(Html.DisplayFor(model => model,"~/Views/Partial/Display/Member.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(558, 189, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"card mt-3\">\r\n    <div class=\"card-body\">\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(748, 27, false);
#line 30 "D:\github\Application\Views\Member\Details.cshtml"
           Write(Html.LabelFor(m=>m.Address));

#line default
#line hidden
            EndContext();
            BeginContext(775, 72, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-9\">\r\n                ");
            EndContext();
            BeginContext(848, 80, false);
#line 33 "D:\github\Application\Views\Member\Details.cshtml"
           Write(Html.DisplayFor(model => model.Address,"~/Views/Partial/Display/Address.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(928, 58, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 39 "D:\github\Application\Views\Member\Details.cshtml"
 if (Model.Type != MemberType.Member)
{

#line default
#line hidden
            BeginContext(1028, 151, true);
            WriteLiteral("    <div class=\"card mt-3\">\r\n        <div class=\"card-body\">\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-3\">\r\n                    ");
            EndContext();
            BeginContext(1180, 28, false);
#line 45 "D:\github\Application\Views\Member\Details.cshtml"
               Write(Html.LabelFor(m => m.Player));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 106, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    \r\n                    ");
            EndContext();
            BeginContext(1315, 79, false);
#line 49 "D:\github\Application\Views\Member\Details.cshtml"
               Write(Html.DisplayFor(model => model.Player, "~/Views/Partial/Display/Player.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 72, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1478, 151, true);
            WriteLiteral("    <div class=\"card mt-3\">\r\n        <div class=\"card-body\">\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-3\">\r\n                    ");
            EndContext();
            BeginContext(1630, 35, false);
#line 60 "D:\github\Application\Views\Member\Details.cshtml"
               Write(Html.LabelFor(m => m.Player.Doctor));

#line default
#line hidden
            EndContext();
            BeginContext(1665, 106, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    \r\n                    ");
            EndContext();
            BeginContext(1772, 86, false);
#line 64 "D:\github\Application\Views\Member\Details.cshtml"
               Write(Html.DisplayFor(model => model.Player.Doctor, "~/Views/Partial/Display/Doctor.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 72, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1936, 151, true);
            WriteLiteral("    <div class=\"card mt-3\">\r\n        <div class=\"card-body\">\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-3\">\r\n                    ");
            EndContext();
            BeginContext(2088, 41, false);
#line 74 "D:\github\Application\Views\Member\Details.cshtml"
               Write(Html.LabelFor(m => m.Player.HealthIssues));

#line default
#line hidden
            EndContext();
            BeginContext(2129, 106, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    \r\n                    ");
            EndContext();
            BeginContext(2236, 98, false);
#line 78 "D:\github\Application\Views\Member\Details.cshtml"
               Write(Html.DisplayFor(model => model.Player.HealthIssues, "~/Views/Partial/Display/HealthIssues.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(2334, 72, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 83 "D:\github\Application\Views\Member\Details.cshtml"
}

#line default
#line hidden
            BeginContext(2409, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 85 "D:\github\Application\Views\Member\Details.cshtml"
 if (Model.Type == MemberType.Senior)
{
    

#line default
#line hidden
            BeginContext(2459, 151, true);
            WriteLiteral("    <div class=\"card mt-3\">\r\n        <div class=\"card-body\">\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-3\">\r\n                    ");
            EndContext();
            BeginContext(2611, 39, false);
#line 92 "D:\github\Application\Views\Member\Details.cshtml"
               Write(Html.LabelFor(m => m.Player.Senior.Kin));

#line default
#line hidden
            EndContext();
            BeginContext(2650, 106, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    \r\n                    ");
            EndContext();
            BeginContext(2757, 87, false);
#line 96 "D:\github\Application\Views\Member\Details.cshtml"
               Write(Html.DisplayFor(model => model.Player.Senior.Kin, "~/Views/Partial/Display/Kin.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(2844, 72, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 101 "D:\github\Application\Views\Member\Details.cshtml"

}

#line default
#line hidden
            BeginContext(2921, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 104 "D:\github\Application\Views\Member\Details.cshtml"
 if (Model.Type == MemberType.Junior)
{
    

#line default
#line hidden
            BeginContext(2971, 151, true);
            WriteLiteral("    <div class=\"card mt-3\">\r\n        <div class=\"card-body\">\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-3\">\r\n                    ");
            EndContext();
            BeginContext(3123, 45, false);
#line 111 "D:\github\Application\Views\Member\Details.cshtml"
               Write(Html.LabelFor(m => m.Player.Junior.Guardians));

#line default
#line hidden
            EndContext();
            BeginContext(3168, 106, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-9\">\r\n                    \r\n                    ");
            EndContext();
            BeginContext(3275, 99, false);
#line 115 "D:\github\Application\Views\Member\Details.cshtml"
               Write(Html.DisplayFor(model => model.Player.Junior.Guardians, "~/Views/Partial/Display/Guardians.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(3374, 72, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 120 "D:\github\Application\Views\Member\Details.cshtml"

}

#line default
#line hidden
            BeginContext(3451, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MemberViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
