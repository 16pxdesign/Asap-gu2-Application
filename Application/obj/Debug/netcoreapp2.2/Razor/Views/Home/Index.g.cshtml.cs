#pragma checksum "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d205cb1151f5c054eda5cd7ebd6ae3ef1eef74b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d205cb1151f5c054eda5cd7ebd6ae3ef1eef74b8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ea476b5db410d4405042b0a5ed991b4e6710c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Home\Index.cshtml"
   ViewData["Title"] = "Contact form"; 

#line default
#line hidden
            BeginContext(71, 209, true);
            WriteLiteral("\r\n\r\n<!-- Modal placeholder -->\r\n<div id=\"modal-placeholder\"></div>\r\n\r\n<!-- Button trigger modal -->\r\n<button type=\"button\" class=\"btn btn-primary\" data-toggle=\"ajax-modal\" data-target=\"#add-contact\" data-url=\"");
            EndContext();
            BeginContext(281, 21, false);
#line 9 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Home\Index.cshtml"
                                                                                                       Write(Url.Action("Contact"));

#line default
#line hidden
            EndContext();
            BeginContext(302, 59, true);
            WriteLiteral("\">\r\n    Add contact\r\n</button>\r\n\r\n<!-- Contacts table -->\r\n");
            EndContext();
            BeginContext(362, 40, false);
#line 14 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_Table", Model));

#line default
#line hidden
            EndContext();
            BeginContext(402, 37, true);
            WriteLiteral("\r\n\r\n<div id=\"notification\" data-url=\"");
            EndContext();
            BeginContext(440, 35, false);
#line 16 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Home\Index.cshtml"
                            Write(Url.Action("Notifications", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(475, 8, true);
            WriteLiteral("\"></div>");
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
