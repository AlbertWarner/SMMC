#pragma checksum "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Enrolment\EnrolmentView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea410664c8fcac5139fd99909502e840f671af6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enrolment_EnrolmentView), @"mvc.1.0.view", @"/Views/Enrolment/EnrolmentView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Enrolment/EnrolmentView.cshtml", typeof(AspNetCore.Views_Enrolment_EnrolmentView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea410664c8fcac5139fd99909502e840f671af6c", @"/Views/Enrolment/EnrolmentView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0a060a0b77bef058bf727801f1ef3801cf1bbe0", @"/Views/_ViewImports.cshtml")]
    public class Views_Enrolment_EnrolmentView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SMMC.Models.Enrolment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnrolmentAdd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnrolmentDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Enrolment\EnrolmentView.cshtml"
  
    ViewData["Title"] = "View Enrolments";

#line default
#line hidden
            BeginContext(96, 40, true);
            WriteLiteral("<h2>Enrolments</h2>\r\n<hr />\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(136, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f57895947ee48c2bc8352d1ca89fb37", async() => {
                BeginContext(189, 17, true);
                WriteLiteral("Add New Enrolment");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(210, 220, true);
            WriteLiteral("\r\n</p>\r\n\r\n<br />\r\n\r\n<table class=\"table table-striped table-bordered dt-responsive nowrap\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Lesson Name\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(431, 45, false);
#line 22 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Enrolment\EnrolmentView.cshtml"
           Write(Html.DisplayNameFor(model => model.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(476, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(532, 43, false);
#line 25 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Enrolment\EnrolmentView.cshtml"
           Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(575, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(631, 41, false);
#line 28 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Enrolment\EnrolmentView.cshtml"
           Write(Html.DisplayNameFor(model => model.Skill));

#line default
#line hidden
            EndContext();
            BeginContext(672, 66, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Ensembles\r\n");
            EndContext();
            BeginContext(801, 53, true);
            WriteLiteral("            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(855, 46, false);
#line 35 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Enrolment\EnrolmentView.cshtml"
           Write(Html.DisplayNameFor(model => model.Instrument));

#line default
#line hidden
            EndContext();
            BeginContext(901, 171, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Enrolment Date\r\n            </th>\r\n            <th>\r\n\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 46 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Enrolment\EnrolmentView.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1121, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1170, 45, false);
#line 50 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Enrolment\EnrolmentView.cshtml"
           Write(Html.DisplayFor(modelItem => item.LessonName));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1271, 44, false);
#line 53 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Enrolment\EnrolmentView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(1315, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1371, 42, false);
#line 56 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Enrolment\EnrolmentView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(1413, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1469, 40, false);
#line 59 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Enrolment\EnrolmentView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Skill));

#line default
#line hidden
            EndContext();
            BeginContext(1509, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1565, 47, false);
#line 62 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Enrolment\EnrolmentView.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnsembleName));

#line default
#line hidden
            EndContext();
            BeginContext(1612, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1668, 45, false);
#line 65 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Enrolment\EnrolmentView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Instrument));

#line default
#line hidden
            EndContext();
            BeginContext(1713, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1769, 39, false);
#line 68 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Enrolment\EnrolmentView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1808, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1863, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf3d625438dc4f5bb69b5018c567ab80", async() => {
                BeginContext(1929, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Enrolment\EnrolmentView.cshtml"
                                                   WriteLiteral(item.EnrolmentID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1940, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 74 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Enrolment\EnrolmentView.cshtml"
        }

#line default
#line hidden
            BeginContext(1987, 26, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SMMC.Models.Enrolment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
