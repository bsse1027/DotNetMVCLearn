#pragma checksum "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40aaf983814d362a7ab62029bab0bc34f481616b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40aaf983814d362a7ab62029bab0bc34f481616b", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div>

    <div class=""row pt-4"">

        <div class=""col-6"">

            <h2 class=""text-primary"">Category List</h2>

        </div>

        <div class=""col-6"">

            Create a new category

        </div>

        <br /> <br />

");
#nullable restore
#line 26 "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\Category\Index.cshtml"
         if(Model.Count() > 0)

            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table table-bordered table-striped"" style=""width:100%"" >

                    <thead>
                        <tr>
                            <th>Category Name</th>
                            <th>Display Count</th>
                            <th>Button</th>
                        </tr>
                    </thead>

                    <tbody>
");
#nullable restore
#line 41 "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\Category\Index.cshtml"
                         foreach(var obj in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 45 "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\Category\Index.cshtml"
                                   Write(obj.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 49 "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\Category\Index.cshtml"
                                   Write(obj.DisplayCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td></td>\r\n                                </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\Category\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n\r\n\r\n\r\n                </table>\r\n");
#nullable restore
#line 60 "C:\Users\Junaid Mansur Ifti\source\repos\WebApplication2\Views\Category\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591