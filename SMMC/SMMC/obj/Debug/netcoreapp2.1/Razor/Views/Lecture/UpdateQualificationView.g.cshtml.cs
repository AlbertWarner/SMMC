#pragma checksum "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Lecture\UpdateQualificationView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e21a52646a45028d9cc54af05ca7d615488f494c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lecture_UpdateQualificationView), @"mvc.1.0.view", @"/Views/Lecture/UpdateQualificationView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lecture/UpdateQualificationView.cshtml", typeof(AspNetCore.Views_Lecture_UpdateQualificationView))]
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
#line 1 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\_ViewImports.cshtml"
using SMMC;

#line default
#line hidden
#line 2 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\_ViewImports.cshtml"
using SMMC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e21a52646a45028d9cc54af05ca7d615488f494c", @"/Views/Lecture/UpdateQualificationView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0a060a0b77bef058bf727801f1ef3801cf1bbe0", @"/Views/_ViewImports.cshtml")]
    public class Views_Lecture_UpdateQualificationView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SMMC.Models.Lecture>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Lecture\UpdateQualificationView.cshtml"
  
    ViewData["Title"] = "Update Tutors Qualifications";

#line default
#line hidden
            BeginContext(107, 254, true);
            WriteLiteral("<h2>Tutors Qualifications Update</h2>\r\n<hr />\r\n<br />\r\n<table class=\"table table-striped table-bordered dt-responsive nowrap\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                First Name\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(362, 43, false);
#line 16 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Lecture\UpdateQualificationView.cshtml"
           Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(405, 377, true);
            WriteLiteral(@"
            </th>
            <th>
                Skill
            </th>
            <th>
                Role
            </th>
            <th>
                Qualification Name
            </th>
            <th>
                Instrument
            </th>
            <th>
                
            </th>

        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 37 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Lecture\UpdateQualificationView.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(831, 62, true);
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(894, 44, false);
#line 42 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Lecture\UpdateQualificationView.cshtml"
               Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(938, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1006, 42, false);
#line 45 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Lecture\UpdateQualificationView.cshtml"
               Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1116, 40, false);
#line 48 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Lecture\UpdateQualificationView.cshtml"
               Write(Html.DisplayFor(modelItem => item.skill));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1224, 39, false);
#line 51 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Lecture\UpdateQualificationView.cshtml"
               Write(Html.DisplayFor(modelItem => item.role));

#line default
#line hidden
            EndContext();
            BeginContext(1263, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1331, 52, false);
#line 54 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Lecture\UpdateQualificationView.cshtml"
               Write(Html.DisplayFor(modelItem => item.qualificationType));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1451, 45, false);
#line 57 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Lecture\UpdateQualificationView.cshtml"
               Write(Html.DisplayFor(modelItem => item.instrument));

#line default
#line hidden
            EndContext();
            BeginContext(1496, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1565, "\"", 1646, 2);
            WriteAttributeValue("", 1572, "/Lecture/UpdateQualification?qualificationTypeID=", 1572, 49, true);
#line 60 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Lecture\UpdateQualificationView.cshtml"
WriteAttributeValue("", 1621, item.qualificationTypeID, 1621, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1647, 13, true);
            WriteLiteral(">Update</a>\r\n");
            EndContext();
            BeginContext(1758, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 64 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Lecture\UpdateQualificationView.cshtml"
        }

#line default
#line hidden
            BeginContext(1811, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SMMC.Models.Lecture>> Html { get; private set; }
    }
}
#pragma warning restore 1591