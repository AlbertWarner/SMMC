#pragma checksum "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Roster\RosterView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8bdb74b87a762dcc5266a30c05524e860a251e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roster_RosterView), @"mvc.1.0.view", @"/Views/Roster/RosterView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roster/RosterView.cshtml", typeof(AspNetCore.Views_Roster_RosterView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8bdb74b87a762dcc5266a30c05524e860a251e5", @"/Views/Roster/RosterView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0a060a0b77bef058bf727801f1ef3801cf1bbe0", @"/Views/_ViewImports.cshtml")]
    public class Views_Roster_RosterView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SMMC.Models.Roster>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RosterAdd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Roster\RosterView.cshtml"
  
    ViewData["Title"] = "View Roster";

#line default
#line hidden
            BeginContext(89, 34, true);
            WriteLiteral("<h2>Roster</h2>\r\n<hr />\r\n<p>\r\n    ");
            EndContext();
            BeginContext(123, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ed40367594d43e6b10197c930233266", async() => {
                BeginContext(149, 76, true);
                WriteLiteral("<input type=\"submit\" value=\"Add New Roster Entry\" class=\"btn btn-primary\" />");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(229, 475, true);
            WriteLiteral(@"
</p>
<br />
<table class=""table table-striped table-bordered dt-responsive nowrap"">
    <thead>
        <tr>
            <th>
                Roster ID
            </th>
            <th>
                Firstname
            </th>
            <th>
                Surname
            </th>
            <th>
                Lesson Name
            </th>
            <th>
                Ensembles Name
            </th>
            <th>
                ");
            EndContext();
            BeginContext(705, 40, false);
#line 31 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Roster\RosterView.cshtml"
           Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(745, 152, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Start Time\r\n            </th>\r\n            <th>\r\n                Roster Date\r\n            </th>\r\n");
            EndContext();
            BeginContext(924, 42, true);
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Roster\RosterView.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1015, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1064, 43, false);
#line 47 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Roster\RosterView.cshtml"
           Write(Html.DisplayFor(modelItem => item.RosterID));

#line default
#line hidden
            EndContext();
            BeginContext(1107, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1163, 44, false);
#line 50 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Roster\RosterView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(1207, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1263, 42, false);
#line 53 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Roster\RosterView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1361, 45, false);
#line 56 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Roster\RosterView.cshtml"
           Write(Html.DisplayFor(modelItem => item.LessonName));

#line default
#line hidden
            EndContext();
            BeginContext(1406, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1462, 48, false);
#line 59 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Roster\RosterView.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnsemblesName));

#line default
#line hidden
            EndContext();
            BeginContext(1510, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1566, 39, false);
#line 62 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Roster\RosterView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1605, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1661, 44, false);
#line 65 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Roster\RosterView.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(1705, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1761, 45, false);
#line 68 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Roster\RosterView.cshtml"
           Write(Html.DisplayFor(modelItem => item.RosterDate));

#line default
#line hidden
            EndContext();
            BeginContext(1806, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(1959, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 74 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Roster\RosterView.cshtml"
        }

#line default
#line hidden
            BeginContext(1985, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SMMC.Models.Roster>> Html { get; private set; }
    }
}
#pragma warning restore 1591