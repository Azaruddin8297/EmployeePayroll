#pragma checksum "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d8a35fdfb86153e21f6e5c3a21375d82bae713f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_GetAllEmployees), @"mvc.1.0.view", @"/Views/Employee/GetAllEmployees.cshtml")]
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
#nullable restore
#line 1 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\_ViewImports.cshtml"
using EmployeePayroll_MVC_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\_ViewImports.cshtml"
using EmployeePayroll_MVC_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d8a35fdfb86153e21f6e5c3a21375d82bae713f", @"/Views/Employee/GetAllEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c26a094de1ead7b384e46b18af26ec8e4e861b79", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_GetAllEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataLayer.Models.EmployeeModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
  
    ViewData["Title"] = "GetAllEmployees";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetAllEmployees</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d8a35fdfb86153e21f6e5c3a21375d82bae713f3828", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.Profile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.IsTrash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdateAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 52 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.Profile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsTrash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpdateAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
           Write(Html.ActionLink("Edit", "Update", new { id=item.EmployeeId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 89 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
               Write(Html.ActionLink("Details", "GetAllEmployeesbyId", new { id=item.EmployeeId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 90 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id=item.EmployeeId  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 93 "D:\CFP\MVC\EmployeePayroll(MVC)\EmployeePayroll(MVC)\Views\Employee\GetAllEmployees.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataLayer.Models.EmployeeModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
