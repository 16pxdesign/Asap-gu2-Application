#pragma checksum "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b48d3ba45917383bd469b5c8494b60d03a32935c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partial_Health), @"mvc.1.0.view", @"/Views/Partial/Health.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Partial/Health.cshtml", typeof(AspNetCore.Views_Partial_Health))]
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
#line 1 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
using Application.Data.Models;

#line default
#line hidden
#line 2 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
using Application.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b48d3ba45917383bd469b5c8494b60d03a32935c", @"/Views/Partial/Health.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ea476b5db410d4405042b0a5ed991b4e6710c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Partial_Health : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HealthIssueViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(96, 24, false);
#line 4 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
Write(ViewData["PropertyName"]);

#line default
#line hidden
            EndContext();
            BeginContext(121, 172, true);
            WriteLiteral(" \r\n<div class=\"col-md mt-4\">\r\n\t\t    <div class=\"card bg-transparent\">\r\n\t\t        <div class=\"card-body\">\r\n\t\t\t        <div>\r\n\t\t\t\t        <input id=\"btnAddItem\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n\r\n\t\t\t\t               onclick=\"", 293, "\"", 361, 3);
            WriteAttributeValue("", 325, "addRow", 325, 6, true);
#line 11 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 331, ViewData["PropertyName"], 331, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 358, "();", 358, 3, true);
            EndWriteAttribute();
            BeginContext(362, 327, true);
            WriteLiteral(@" value=""Add Item""/>
			        </div>
			        
			 
			        <table class=""table"">
				        <thead>
				        <tr>
					        <th scope=""col"">
						        Title
					        </th>
					        <th scope=""col"">
						     
					        </th>
				        </tr>
				        </thead>
				        <tbody");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 689, "\"", 726, 2);
            WriteAttributeValue("", 694, "table", 694, 5, true);
#line 26 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 699, ViewData["PropertyName"], 699, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(727, 13, true);
            WriteLiteral(">\r\n        \r\n");
            EndContext();
#line 28 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
                         for (var i = 0; i < Model.Count; i++)
				        {
					        

#line default
#line hidden
            BeginContext(822, 16, true);
            WriteLiteral("\t\t\t\t\t        <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 838, "\"", 880, 3);
            WriteAttributeValue("", 843, "trItem", 843, 6, true);
#line 31 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 849, ViewData["PropertyName"], 849, 27, false);

#line default
#line hidden
#line 31 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 876, i, 876, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(881, 48, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t        <th style=\'display:none\'><input");
            EndContext();
            BeginWriteAttribute("id", " id=\'", 929, "\'", 967, 2);
#line 32 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 934, ViewData["PropertyName"], 934, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 961, ".Index", 961, 6, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\'", 968, "\'", 1008, 2);
#line 32 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 975, ViewData["PropertyName"], 975, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 1002, ".Index", 1002, 6, true);
            EndWriteAttribute();
            BeginContext(1009, 14, true);
            WriteLiteral(" type=\'hidden\'");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 1023, "\'", 1035, 1);
#line 32 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1031, i, 1031, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1036, 46, true);
            WriteLiteral(" /></th>\r\n\t\t\t\t\t\t        <th scope=\"row\"><input");
            EndContext();
            BeginWriteAttribute("id", " id=\'", 1082, "\'", 1125, 4);
#line 33 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1087, ViewData["PropertyName"], 1087, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 1114, "[", 1114, 1, true);
#line 33 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1115, i, 1115, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 1119, "].Flat", 1119, 6, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\'", 1126, "\'", 1171, 4);
#line 33 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1133, ViewData["PropertyName"], 1133, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 1160, "[", 1160, 1, true);
#line 33 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1161, i, 1161, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 1165, "].Flat", 1165, 6, true);
            EndWriteAttribute();
            BeginContext(1172, 12, true);
            WriteLiteral(" type=\'text\'");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 1184, "\'", 1206, 1);
#line 33 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1192, Model[i].Date, 1192, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1207, 34, true);
            WriteLiteral(" /></th>\r\n\t\t\t\t\t\t        <th><input");
            EndContext();
            BeginWriteAttribute("id", " id=\'", 1241, "\'", 1286, 4);
#line 34 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1246, ViewData["PropertyName"], 1246, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 1273, "[", 1273, 1, true);
#line 34 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1274, i, 1274, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 1278, "].Street", 1278, 8, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", "  name=\'", 1287, "\'", 1335, 4);
#line 34 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1295, ViewData["PropertyName"], 1295, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 1322, "[", 1322, 1, true);
#line 34 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1323, i, 1323, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 1327, "].Street", 1327, 8, true);
            EndWriteAttribute();
            BeginContext(1336, 12, true);
            WriteLiteral(" type=\'text\'");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 1348, "\'", 1370, 1);
#line 34 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1356, Model[i].Name, 1356, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1371, 49, true);
            WriteLiteral(" /></th>\r\n\t\t\t\t\t\t        <th><input  type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("id", " id=\'", 1420, "\'", 1470, 4);
#line 35 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1425, ViewData["PropertyName"], 1425, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 1452, "[", 1452, 1, true);
#line 35 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1453, i, 1453, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 1457, "].Description", 1457, 13, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\'", 1471, "\'", 1523, 4);
#line 35 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1478, ViewData["PropertyName"], 1478, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 1505, "[", 1505, 1, true);
#line 35 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1506, i, 1506, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 1510, "].Description", 1510, 13, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", "  value=\'", 1524, "\'", 1554, 1);
#line 35 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1533, Model[i].Description, 1533, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1555, 88, true);
            WriteLiteral(" /></th>\r\n\t\t\t\t\t\t        <th><a href=\"#\" class=\"btn btn-link text-danger\" id=\'btnAddItem\'");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\'", 1643, "\'", 1696, 5);
            WriteAttributeValue("", 1653, "removeRow", 1653, 9, true);
#line 36 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1662, ViewData["PropertyName"], 1662, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 1689, "(", 1689, 1, true);
#line 36 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
WriteAttributeValue("", 1690, i, 1690, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 1694, ");", 1694, 2, true);
            EndWriteAttribute();
            BeginContext(1697, 65, true);
            WriteLiteral(" ><i class=\"fas fa-trash-alt\"></i></a></th>\r\n\t\t\t\t\t        </tr>\r\n");
            EndContext();
#line 38 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
				        }

#line default
#line hidden
            BeginContext(1777, 166, true);
            WriteLiteral("      \r\n\t\t\t\t        </tbody>\r\n\t\t\t        </table>\r\n\t\t\t        \r\n\t\t\t        <script language=\"javascript\" type=\"text/javascript\">\r\n\t                    function addRow");
            EndContext();
            BeginContext(1945, 24, false);
#line 44 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
                                   Write(ViewData["PropertyName"]);

#line default
#line hidden
            EndContext();
            BeginContext(1970, 51, true);
            WriteLiteral("() {\r\n\r\n\t\t                    var index = $(\"#table");
            EndContext();
            BeginContext(2023, 24, false);
#line 46 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
                                             Write(ViewData["PropertyName"]);

#line default
#line hidden
            EndContext();
            BeginContext(2048, 104, true);
            WriteLiteral("\").children(\"tr\").length;\r\n\r\n\t\t                    var indexCell = \"<th style=\'display:none\'><input id=\'");
            EndContext();
            BeginContext(2154, 24, false);
#line 48 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
                                                                             Write(ViewData["PropertyName"]);

#line default
#line hidden
            EndContext();
            BeginContext(2179, 14, true);
            WriteLiteral(".Index\' name=\'");
            EndContext();
            BeginContext(2195, 24, false);
#line 48 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
                                                                                                                      Write(ViewData["PropertyName"]);

#line default
#line hidden
            EndContext();
            BeginContext(2220, 118, true);
            WriteLiteral(".Index\' type=\'hidden\' value=\'\" + index + \"\' /></th>\";\r\n\t\t                    var value1 = \"<th scope=\'row\'><input id=\'");
            EndContext();
            BeginContext(2340, 24, false);
#line 49 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
                                                                 Write(ViewData["PropertyName"]);

#line default
#line hidden
            EndContext();
            BeginContext(2365, 29, true);
            WriteLiteral(".[\" + index + \"].Date\' name=\'");
            EndContext();
            BeginContext(2396, 24, false);
#line 49 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
                                                                                                                         Write(ViewData["PropertyName"]);

#line default
#line hidden
            EndContext();
            BeginContext(2421, 106, true);
            WriteLiteral(".[\" + index + \"].Date\' type=\'text\' value=\'\' /></th>\";\r\n\t\t                    var value2 = \"<th><input id=\'");
            EndContext();
            BeginContext(2529, 24, false);
#line 50 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
                                                     Write(ViewData["PropertyName"]);

#line default
#line hidden
            EndContext();
            BeginContext(2554, 29, true);
            WriteLiteral(".[\" + index + \"].Name\' name=\'");
            EndContext();
            BeginContext(2585, 24, false);
#line 50 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
                                                                                                             Write(ViewData["PropertyName"]);

#line default
#line hidden
            EndContext();
            BeginContext(2610, 121, true);
            WriteLiteral(".[\" + index + \"].Name\' type=\'text\' value=\'\' /></th>\";\r\n\t\t                    var value3 = \"<th><input  type=\'hidden\' id=\'");
            EndContext();
            BeginContext(2733, 24, false);
#line 51 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
                                                                    Write(ViewData["PropertyName"]);

#line default
#line hidden
            EndContext();
            BeginContext(2758, 29, true);
            WriteLiteral(".[\" + index + \"].Name\' name=\'");
            EndContext();
            BeginContext(2789, 24, false);
#line 51 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
                                                                                                                            Write(ViewData["PropertyName"]);

#line default
#line hidden
            EndContext();
            BeginContext(2814, 178, true);
            WriteLiteral(".[\" + index + \"].Name\' type=\'text\' value=\'\' /></th>\";\r\n\t\t                    var removeCell = \"<th><a href=\'#\' class=\'btn btn-link text-danger\' id=\'btnAddItem\' onclick=\'removeRow");
            EndContext();
            BeginContext(2994, 24, false);
#line 52 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
                                                                                                                             Write(ViewData["PropertyName"]);

#line default
#line hidden
            EndContext();
            BeginContext(3019, 116, true);
            WriteLiteral("(\" + index + \");\' ><i class=\'fas fa-trash-alt\'></i></a></th>\";\r\n\r\n\t\t                    var newRow = \"<tr id=\'trItem");
            EndContext();
            BeginContext(3137, 24, false);
#line 54 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
                                                    Write(ViewData["PropertyName"]);

#line default
#line hidden
            EndContext();
            BeginContext(3162, 112, true);
            WriteLiteral("\" + index + \"\'>\" + indexCell + value1 + value2 + value3 + removeCell + \"</tr>\";\r\n\t\t                    $(\"#table");
            EndContext();
            BeginContext(3276, 24, false);
#line 55 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
                                 Write(ViewData["PropertyName"]);

#line default
#line hidden
            EndContext();
            BeginContext(3301, 85, true);
            WriteLiteral("\").append(newRow);\r\n\t                    }\r\n\r\n\t                    function removeRow");
            EndContext();
            BeginContext(3388, 24, false);
#line 58 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
                                      Write(ViewData["PropertyName"]);

#line default
#line hidden
            EndContext();
            BeginContext(3413, 63, true);
            WriteLiteral("(id) {\r\n\t\t                    var controlToBeRemoved = \"#trItem");
            EndContext();
            BeginContext(3478, 24, false);
#line 59 "C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application\Views\Partial\Health.cshtml"
                                                         Write(ViewData["PropertyName"]);

#line default
#line hidden
            EndContext();
            BeginContext(3503, 187, true);
            WriteLiteral("\" + id;\r\n\t\t                    $(controlToBeRemoved).remove();\r\n\t                    }\r\n                    </script>\r\n\r\n\t\t\t     \r\n\t\t\t       \r\n\t\t        </div>\r\n\t\t    </div>\r\n\t\t</div>\r\n\r\n");
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