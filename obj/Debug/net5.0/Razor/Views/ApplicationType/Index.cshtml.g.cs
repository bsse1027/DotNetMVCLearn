#pragma checksum "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\ApplicationType\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1b0dca478eadc7382df1f7e53668ec0acdd347d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplicationType_Index), @"mvc.1.0.view", @"/Views/ApplicationType/Index.cshtml")]
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
#line 1 "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b0dca478eadc7382df1f7e53668ec0acdd347d", @"/Views/ApplicationType/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplicationType_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationType>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ApplicationType", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\ApplicationType\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div>\r\n\r\n    <div class=\"row pt-4\">\r\n\r\n        <div class=\"col-6\">\r\n\r\n            <h2 class=\"text-primary\">App Type List</h2>\r\n\r\n        </div>\r\n\r\n        <div class=\"col-6 text-right\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1b0dca478eadc7382df1f7e53668ec0acdd347d4639", async() => {
                WriteLiteral("\r\n\r\n                Create a new Application Type\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n        </div>\r\n\r\n        <br /> <br />\r\n\r\n");
#nullable restore
#line 32 "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\ApplicationType\Index.cshtml"
         if (Model.Count() > 0)

        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-bordered table-striped"" style=""width:100%"">

                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                        <th>Button</th>
                    </tr>
                </thead>

                <tbody>
");
#nullable restore
#line 47 "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\ApplicationType\Index.cshtml"
                     foreach (var obj in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 51 "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\ApplicationType\Index.cshtml"
                           Write(obj.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 55 "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\ApplicationType\Index.cshtml"
                           Write(obj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td></td>\r\n                        </tr>\r\n");
#nullable restore
#line 59 "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\ApplicationType\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n\r\n\r\n\r\n            </table>\r\n");
#nullable restore
#line 66 "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\ApplicationType\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationType>> Html { get; private set; }
    }
}
#pragma warning restore 1591
