#pragma checksum "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b73ede395298ce6e7fcf8144fc201cc28589f3c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Index__HealthTable), @"mvc.1.0.view", @"/Views/Index/_HealthTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Index/_HealthTable.cshtml", typeof(AspNetCore.Views_Index__HealthTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73ede395298ce6e7fcf8144fc201cc28589f3c7", @"/Views/Index/_HealthTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ea476b5db410d4405042b0a5ed991b4e6710c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Index__HealthTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HealthIssueViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 56, true);
            WriteLiteral("\r\n<table id=\"healthissues\" class=\"table mt-1\" data-url=\"");
            EndContext();
            BeginContext(92, 19, false);
#line 3 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml"
                                                 Write(Url.Action("Index"));

#line default
#line hidden
            EndContext();
            BeginContext(111, 159, true);
            WriteLiteral("\">\r\n    <thead>\r\n    <tr>\r\n        <th>Date</th>\r\n        <th>Name</th>\r\n        <th>Edit</th>\r\n        <th>Delete</th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 13 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml"
     for (var i = 0; i < Model.Count; i++)
    {

#line default
#line hidden
            BeginContext(321, 57, true);
            WriteLiteral("        <tr>\r\n            <td style=\'display:none\'><input");
            EndContext();
            BeginWriteAttribute("name", " name=\'", 378, "\'", 415, 3);
            WriteAttributeValue("", 385, "Player.HealthIssue[", 385, 19, true);
#line 16 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml"
WriteAttributeValue("", 404, i, 404, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 408, "].Index", 408, 7, true);
            EndWriteAttribute();
            BeginContext(416, 14, true);
            WriteLiteral(" type=\'hidden\'");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 430, "\'", 442, 1);
#line 16 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml"
WriteAttributeValue("", 438, i, 438, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(443, 32, true);
            WriteLiteral(" /></td>\r\n            <td><input");
            EndContext();
            BeginWriteAttribute("name", "  name=\'", 475, "\'", 512, 3);
            WriteAttributeValue("", 483, "Player.HealthIssue[", 483, 19, true);
#line 17 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml"
WriteAttributeValue("", 502, i, 502, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 506, "].Data", 506, 6, true);
            EndWriteAttribute();
            BeginContext(513, 14, true);
            WriteLiteral(" type=\'hidden\'");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 527, "\'", 549, 1);
#line 17 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml"
WriteAttributeValue("", 535, Model[i].Date, 535, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(550, 3, true);
            WriteLiteral(" />");
            EndContext();
            BeginContext(554, 36, false);
#line 17 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml"
                                                                                               Write(Model[i].Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(590, 29, true);
            WriteLiteral("</td>\r\n            <td><input");
            EndContext();
            BeginWriteAttribute("name", "  name=\'", 619, "\'", 656, 3);
            WriteAttributeValue("", 627, "Player.HealthIssue[", 627, 19, true);
#line 18 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml"
WriteAttributeValue("", 646, i, 646, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 650, "].Name", 650, 6, true);
            EndWriteAttribute();
            BeginContext(657, 14, true);
            WriteLiteral(" type=\'hidden\'");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 671, "\'", 693, 1);
#line 18 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml"
WriteAttributeValue("", 679, Model[i].Name, 679, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(694, 3, true);
            WriteLiteral(" />");
            EndContext();
            BeginContext(698, 13, false);
#line 18 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml"
                                                                                               Write(Model[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(711, 60, true);
            WriteLiteral("</td>\r\n            <td style=\'display:none\'><textarea hidden");
            EndContext();
            BeginWriteAttribute("name", "  name=\'", 771, "\'", 815, 3);
            WriteAttributeValue("", 779, "Player.HealthIssue[", 779, 19, true);
#line 19 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml"
WriteAttributeValue("", 798, i, 798, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 802, "].Description", 802, 13, true);
            EndWriteAttribute();
            BeginContext(816, 2, true);
            WriteLiteral(" >");
            EndContext();
            BeginContext(819, 20, false);
#line 19 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml"
                                                                                               Write(Model[i].Description);

#line default
#line hidden
            EndContext();
            BeginContext(839, 101, true);
            WriteLiteral("</textarea></td>\r\n\r\n            <!-- Buttons -->\r\n            \r\n            <td><button type=\"button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 940, "\"", 977, 3);
            WriteAttributeValue("", 945, "Player_HealthIssue[", 945, 19, true);
#line 23 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml"
WriteAttributeValue("", 964, i, 964, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 968, "]_editBtn", 968, 9, true);
            EndWriteAttribute();
            BeginContext(978, 83, true);
            WriteLiteral(" class=\"btn btn-link\" data-toggle=\"ajax-modal\" data-target=\"#add-health\" data-url=\"");
            EndContext();
            BeginContext(1062, 37, false);
#line 23 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml"
                                                                                                                                                         Write(Url.Action("AddHealth",new {id = i} ));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 85, true);
            WriteLiteral("\" ><i class=\"fas fa-edit\"></i></button></td>\r\n            <td><button data-deleteid=\"");
            EndContext();
            BeginContext(1186, 1, false);
#line 24 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml"
                                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1188, 72, true);
            WriteLiteral("\" class=\'btn btn-link text-danger\' data-toggle=\"HealthDelete\" data-url=\"");
            EndContext();
            BeginContext(1261, 28, false);
#line 24 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml"
                                                                                                              Write(Url.Action("Delete","Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 65, true);
            WriteLiteral("\"><i class=\'fas fa-trash-alt\'></i></button></td>\r\n        </tr>\r\n");
            EndContext();
#line 26 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Index\_HealthTable.cshtml"
    }

#line default
#line hidden
            BeginContext(1361, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HealthIssueViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
