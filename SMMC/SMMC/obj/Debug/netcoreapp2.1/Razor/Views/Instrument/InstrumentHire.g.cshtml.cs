#pragma checksum "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aad55d4ced45a530a5fe7100d11f0bcc8f0ede2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instrument_InstrumentHire), @"mvc.1.0.view", @"/Views/Instrument/InstrumentHire.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Instrument/InstrumentHire.cshtml", typeof(AspNetCore.Views_Instrument_InstrumentHire))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aad55d4ced45a530a5fe7100d11f0bcc8f0ede2b", @"/Views/Instrument/InstrumentHire.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0a060a0b77bef058bf727801f1ef3801cf1bbe0", @"/Views/_ViewImports.cshtml")]
    public class Views_Instrument_InstrumentHire : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SMMC.Models.Instrument>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InstrumentHireAdd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InstrumentHireDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml"
  
    ViewData["Title"] = "Instruments Hire";

#line default
#line hidden
            BeginContext(98, 44, true);
            WriteLiteral("<h2>Instruments Hire</h2>\r\n<hr />\r\n<p>\r\n    ");
            EndContext();
            BeginContext(142, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "340379f1de124843b5ee795bdcb49a24", async() => {
                BeginContext(176, 71, true);
                WriteLiteral("<input type=\"submit\" value=\"Hire Instrument\" class=\"btn btn-primary\" />");
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
            BeginContext(251, 212, true);
            WriteLiteral("\r\n\r\n</p>\r\n\r\n<br />\r\n\r\n<h2>Instruments Hire Record for Students</h2>\r\n<table class=\"table table-striped table-bordered dt-responsive nowrap\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Hire ID\r\n");
            EndContext();
            BeginContext(524, 53, true);
            WriteLiteral("            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(578, 45, false);
#line 24 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml"
           Write(Html.DisplayNameFor(model => model.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(623, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(679, 43, false);
#line 27 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml"
           Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(722, 72, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Instrument Name\r\n");
            EndContext();
            BeginContext(857, 64, true);
            WriteLiteral("            </th>\r\n            <th>\r\n                Hire Date\r\n");
            EndContext();
            BeginContext(988, 53, true);
            WriteLiteral("            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1042, 39, false);
#line 38 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml"
           Write(Html.DisplayNameFor(model => model.Fee));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 59, true);
            WriteLiteral(" ($)\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1141, 42, false);
#line 41 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml"
           Write(Html.DisplayNameFor(model => model.Repair));

#line default
#line hidden
            EndContext();
            BeginContext(1183, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1239, 44, false);
#line 44 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml"
           Write(Html.DisplayNameFor(model => model.Returned));

#line default
#line hidden
            EndContext();
            BeginContext(1283, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 50 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1418, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1467, 37, false);
#line 54 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1504, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1560, 44, false);
#line 57 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml"
           Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(1604, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1660, 42, false);
#line 60 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml"
           Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(1702, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1758, 39, false);
#line 63 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1797, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1853, 43, false);
#line 66 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml"
           Write(Html.DisplayFor(modelItem => item.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1896, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1952, 38, false);
#line 69 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fee));

#line default
#line hidden
            EndContext();
            BeginContext(1990, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2046, 41, false);
#line 72 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml"
           Write(Html.DisplayFor(modelItem => item.Repair));

#line default
#line hidden
            EndContext();
            BeginContext(2087, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2143, 43, false);
#line 75 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml"
           Write(Html.DisplayFor(modelItem => item.Returned));

#line default
#line hidden
            EndContext();
            BeginContext(2186, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2241, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20e7c9fb86f8499d83b79fefdd2720c8", async() => {
                BeginContext(2303, 12, true);
                WriteLiteral("Hire Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml"
                                                        WriteLiteral(item.ID);

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
            BeginContext(2319, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 81 "C:\Users\alber\OneDrive\Desktop\Bit Year\Year 3\Semester 2\DB3\Main Git\warnaa1\Assignment2\SMMC\SMMC\Views\Instrument\InstrumentHire.cshtml"
        }

#line default
#line hidden
            BeginContext(2366, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SMMC.Models.Instrument>> Html { get; private set; }
    }
}
#pragma warning restore 1591