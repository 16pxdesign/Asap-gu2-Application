#pragma checksum "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Home\_Table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29cf288a93272b4203157b677b63e9f05e7cb058"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Table), @"mvc.1.0.view", @"/Views/Home/_Table.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_Table.cshtml", typeof(AspNetCore.Views_Home__Table))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29cf288a93272b4203157b677b63e9f05e7cb058", @"/Views/Home/_Table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ea476b5db410d4405042b0a5ed991b4e6710c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 52, true);
            WriteLiteral("\r\n<table id=\"contacts\" class=\"table mt-5\" data-url=\"");
            EndContext();
            BeginContext(82, 19, false);
#line 3 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Home\_Table.cshtml"
                                             Write(Url.Action("Index"));

#line default
#line hidden
            EndContext();
            BeginContext(101, 112, true);
            WriteLiteral("\">\r\n    <thead>\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Email</th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 11 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Home\_Table.cshtml"
     foreach (var contact in Model)
    {

#line default
#line hidden
            BeginContext(257, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(288, 17, false);
#line 14 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Home\_Table.cshtml"
           Write(contact.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(305, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(307, 16, false);
#line 14 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Home\_Table.cshtml"
                              Write(contact.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(323, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(347, 13, false);
#line 15 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Home\_Table.cshtml"
           Write(contact.Email);

#line default
#line hidden
            EndContext();
            BeginContext(360, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 17 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Home\_Table.cshtml"
    }

#line default
#line hidden
            BeginContext(389, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
