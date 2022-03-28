#pragma checksum "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cfe8fbb4f2356a154d8106eff90bc5af37d7664"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_ReadProject), @"mvc.1.0.view", @"/Views/Project/ReadProject.cshtml")]
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
#line 1 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
using AndreyTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cfe8fbb4f2356a154d8106eff90bc5af37d7664", @"/Views/Project/ReadProject.cshtml")]
    public class Views_Project_ReadProject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"ru\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cfe8fbb4f2356a154d8106eff90bc5af37d76642927", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title>Работа с БД</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cfe8fbb4f2356a154d8106eff90bc5af37d76643961", async() => {
                WriteLiteral(@"
<h2>[ЧТЕНИЕ]</h2>
<table>
    <tr>
        <th>ID</th>
        <th>Имя проекта</th>
        <th>Название компании-заказчика</th>
        <th>Название компании-исполнителя</th>
        <th>Лидер</th>
        <th>Исполнители</th>
        <th>Дата начала</th>
        <th>Дата конца</th>
        <th>Приоритет</th>
    </tr>
");
#nullable restore
#line 22 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
     foreach (var project in ViewBag.ListProjects)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
            Write(((Project) project).Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
            Write(((Project) project).NameProject);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
            Write(((Project) project).NameCustomerCompany);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
            Write(((Project) project).NamePerformingCompany);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 29 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
             if (((Project) project).Leader == null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <td>null</td>\r\n");
#nullable restore
#line 32 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 36 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
                Write(((Project) project).Leader.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(" || ");
#nullable restore
#line 36 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
                                                    Write(((Project) project).Leader.SecondName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 36 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
                                                                                             Write(((Project) project).Leader.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 38 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <td>\r\n");
#nullable restore
#line 40 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
                 if (((Project) project).Performers != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <ul>\r\n");
#nullable restore
#line 43 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
                         foreach (var performer in ((Project) project).Performers)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>");
#nullable restore
#line 45 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
                           Write(performer.Worker.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(" || ");
#nullable restore
#line 45 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
                                                   Write(performer.Worker.SecondName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 45 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
                                                                                Write(performer.Worker.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 46 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </ul>\r\n");
#nullable restore
#line 48 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <p>null</p>\r\n");
#nullable restore
#line 52 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </td>\r\n            <td>");
#nullable restore
#line 54 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
            Write(((Project) project).StartTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 55 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
            Write(((Project) project).EndTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 56 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
            Write(((Project) project).Priority);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 58 "C:\MyDoc\Projects\AndreyTest\AndreyTest\Views\Project\ReadProject.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("</table>\r\n<form action=\"projectView\">\r\n    <button>[НАЗАД]</button>\r\n</form>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
