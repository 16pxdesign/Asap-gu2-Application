#pragma checksum "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57089638ad1e935e4a74c894bc46d46efec6b62f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member__GuardianTable), @"mvc.1.0.view", @"/Views/Member/_GuardianTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Member/_GuardianTable.cshtml", typeof(AspNetCore.Views_Member__GuardianTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57089638ad1e935e4a74c894bc46d46efec6b62f", @"/Views/Member/_GuardianTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ea476b5db410d4405042b0a5ed991b4e6710c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Member__GuardianTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JuniorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 57, true);
            WriteLiteral("\r\n<table id=\"GuardianTable\" class=\"table mt-1\" data-url=\"");
            EndContext();
            BeginContext(82, 26, false);
#line 3 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
                                                  Write(Url.Action("CreateUpdate"));

#line default
#line hidden
            EndContext();
            BeginContext(108, 178, true);
            WriteLiteral("\">\r\n    <thead>\r\n    <tr>\r\n        <th>Guardian</th>\r\n        <th>Signature Date</th>\r\n        <th>Edit</th>\r\n        <th>Delete</th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n   \r\n");
            EndContext();
#line 14 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
     for (var i = 0; i < Model.Guardians.Count; i++)
    {

#line default
#line hidden
            BeginContext(347, 36, true);
            WriteLiteral("        <tr>\r\n            <td><input");
            EndContext();
            BeginWriteAttribute("name", " name=\'", 383, "\'", 424, 3);
            WriteAttributeValue("", 390, "Player.Junior.Guardians[", 390, 24, true);
#line 17 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 414, i, 414, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 418, "].Name", 418, 6, true);
            EndWriteAttribute();
            BeginContext(425, 14, true);
            WriteLiteral(" type=\'hidden\'");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 439, "\'", 471, 1);
#line 17 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 447, Model.Guardians[i].Name, 447, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(472, 2, true);
            WriteLiteral("/>");
            EndContext();
            BeginContext(475, 23, false);
#line 17 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
                                                                                                            Write(Model.Guardians[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(498, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(500, 26, false);
#line 17 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
                                                                                                                                     Write(Model.Guardians[i].Surname);

#line default
#line hidden
            EndContext();
            BeginContext(526, 51, true);
            WriteLiteral("</td>\r\n            <td style=\'display: none\'><input");
            EndContext();
            BeginWriteAttribute("name", " name=\'", 577, "\'", 621, 3);
            WriteAttributeValue("", 584, "Player.Junior.Guardians[", 584, 24, true);
#line 18 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 608, i, 608, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 612, "].Surname", 612, 9, true);
            EndWriteAttribute();
            BeginContext(622, 14, true);
            WriteLiteral(" type=\'hidden\'");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 636, "\'", 671, 1);
#line 18 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 644, Model.Guardians[i].Surname, 644, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(672, 53, true);
            WriteLiteral("/></td>\r\n            <td style=\'display: none\'><input");
            EndContext();
            BeginWriteAttribute("name", " name=\'", 725, "\'", 767, 3);
            WriteAttributeValue("", 732, "Player.Junior.Guardians[", 732, 24, true);
#line 19 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 756, i, 756, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 760, "].Phone", 760, 7, true);
            EndWriteAttribute();
            BeginContext(768, 14, true);
            WriteLiteral(" type=\'hidden\'");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 782, "\'", 815, 1);
#line 19 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 790, Model.Guardians[i].Phone, 790, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(816, 53, true);
            WriteLiteral("/></td>\r\n            <td style=\'display: none\'><input");
            EndContext();
            BeginWriteAttribute("name", " name=\'", 869, "\'", 918, 3);
            WriteAttributeValue("", 876, "Player.Junior.Guardians[", 876, 24, true);
#line 20 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 900, i, 900, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 904, "].Relationship", 904, 14, true);
            EndWriteAttribute();
            BeginContext(919, 14, true);
            WriteLiteral(" type=\'hidden\'");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 933, "\'", 973, 1);
#line 20 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 941, Model.Guardians[i].Relationship, 941, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(974, 2, true);
            WriteLiteral("/>");
            EndContext();
            BeginContext(977, 31, false);
#line 20 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
                                                                                                                                                  Write(Model.Guardians[i].Relationship);

#line default
#line hidden
            EndContext();
            BeginContext(1008, 29, true);
            WriteLiteral("</td>\r\n            <td><input");
            EndContext();
            BeginWriteAttribute("name", " name=\'", 1037, "\'", 1083, 3);
            WriteAttributeValue("", 1044, "Player.Junior.Guardians[", 1044, 24, true);
#line 21 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 1068, i, 1068, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 1072, "].Signature", 1072, 11, true);
            EndWriteAttribute();
            BeginContext(1084, 14, true);
            WriteLiteral(" type=\'hidden\'");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 1098, "\'", 1135, 1);
#line 21 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 1106, Model.Guardians[i].Signature, 1106, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1136, 2, true);
            WriteLiteral("/>");
            EndContext();
            BeginContext(1139, 51, false);
#line 21 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
                                                                                                                      Write(Model.Guardians[i].Signature.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 51, true);
            WriteLiteral("</td>\r\n            <td style=\'display: none\'><input");
            EndContext();
            BeginWriteAttribute("name", " name=\'", 1241, "\'", 1290, 3);
            WriteAttributeValue("", 1248, "Player.Junior.Guardians[", 1248, 24, true);
#line 22 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 1272, i, 1272, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 1276, "].Address.Flat", 1276, 14, true);
            EndWriteAttribute();
            BeginContext(1291, 14, true);
            WriteLiteral(" type=\'hidden\'");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 1305, "\'", 1345, 1);
#line 22 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 1313, Model.Guardians[i].Address.Flat, 1313, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1346, 53, true);
            WriteLiteral("/></td>\r\n            <td style=\'display: none\'><input");
            EndContext();
            BeginWriteAttribute("name", " name=\'", 1399, "\'", 1450, 3);
            WriteAttributeValue("", 1406, "Player.Junior.Guardians[", 1406, 24, true);
#line 23 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 1430, i, 1430, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 1434, "].Address.Street", 1434, 16, true);
            EndWriteAttribute();
            BeginContext(1451, 14, true);
            WriteLiteral(" type=\'hidden\'");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 1465, "\'", 1507, 1);
#line 23 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 1473, Model.Guardians[i].Address.Street, 1473, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1508, 53, true);
            WriteLiteral("/></td>\r\n            <td style=\'display: none\'><input");
            EndContext();
            BeginWriteAttribute("name", " name=\'", 1561, "\'", 1610, 3);
            WriteAttributeValue("", 1568, "Player.Junior.Guardians[", 1568, 24, true);
#line 24 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 1592, i, 1592, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 1596, "].Address.City", 1596, 14, true);
            EndWriteAttribute();
            BeginContext(1611, 14, true);
            WriteLiteral(" type=\'hidden\'");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 1625, "\'", 1665, 1);
#line 24 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 1633, Model.Guardians[i].Address.City, 1633, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1666, 53, true);
            WriteLiteral("/></td>\r\n            <td style=\'display: none\'><input");
            EndContext();
            BeginWriteAttribute("name", " name=\'", 1719, "\'", 1772, 3);
            WriteAttributeValue("", 1726, "Player.Junior.Guardians[", 1726, 24, true);
#line 25 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 1750, i, 1750, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 1754, "].Address.Postcode", 1754, 18, true);
            EndWriteAttribute();
            BeginContext(1773, 14, true);
            WriteLiteral(" type=\'hidden\'");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 1787, "\'", 1831, 1);
#line 25 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 1795, Model.Guardians[i].Address.Postcode, 1795, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1832, 82, true);
            WriteLiteral("/></td>\r\n\r\n\r\n            <!-- Buttons -->\r\n\r\n            <td><button type=\"button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1914, "\"", 1941, 3);
            WriteAttributeValue("", 1919, "Guardian[", 1919, 9, true);
#line 30 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
WriteAttributeValue("", 1928, i, 1928, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 1932, "]_editBtn", 1932, 9, true);
            EndWriteAttribute();
            BeginContext(1942, 57, true);
            WriteLiteral(" class=\"btn btn-link\" data-toggle=\"ajax-modal\" data-url=\"");
            EndContext();
            BeginContext(2000, 39, false);
#line 30 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
                                                                                                                     Write(Url.Action("AddGuardian", new {id = i}));

#line default
#line hidden
            EndContext();
            BeginContext(2039, 84, true);
            WriteLiteral("\"><i class=\"fas fa-edit\"></i></button></td>\r\n            <td><button data-deleteid=\"");
            EndContext();
            BeginContext(2125, 1, false);
#line 31 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
                                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2127, 74, true);
            WriteLiteral("\" class=\'btn btn-link text-danger\' data-toggle=\"GuardianDelete\" data-url=\"");
            EndContext();
            BeginContext(2202, 38, false);
#line 31 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
                                                                                                                Write(Url.Action("DeleteGuardian", "Member"));

#line default
#line hidden
            EndContext();
            BeginContext(2240, 65, true);
            WriteLiteral("\"><i class=\'fas fa-trash-alt\'></i></button></td>\r\n        </tr>\r\n");
            EndContext();
#line 33 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Member\_GuardianTable.cshtml"
    }

#line default
#line hidden
            BeginContext(2312, 36, true);
            WriteLiteral("    \r\n\r\n\r\n\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JuniorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
