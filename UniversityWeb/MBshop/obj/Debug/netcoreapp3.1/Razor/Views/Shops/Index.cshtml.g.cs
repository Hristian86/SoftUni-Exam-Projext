#pragma checksum "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40ea01459c63b75371991cee6fef5f2faf9ea69e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shops_Index), @"mvc.1.0.view", @"/Views/Shops/Index.cshtml")]
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
#line 1 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\_ViewImports.cshtml"
using MBshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\_ViewImports.cshtml"
using MBshop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\_ViewImports.cshtml"
using MBshop.Service.WebConstants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\_ViewImports.cshtml"
using MBshop.Service.OutputModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\_ViewImports.cshtml"
using MBshop.Service.StaticProperyes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40ea01459c63b75371991cee6fef5f2faf9ea69e", @"/Views/Shops/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8579fc7af4c90e53a0565a581932c1274a5b5cc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shops_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MBshop.Models.Shops>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">

        <h1>View shops</h1>

        <div class=""table-responsive-sm"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            Purchased time
                        </th>
                        <th>
                            ");
#nullable restore
#line 18 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Books));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 21 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Movie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 24 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 34 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.RentedTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 37 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Books.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                                 if (item.Books != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                               Write(item.Books.Title);

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                                                     
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>-</div>\r\n");
#nullable restore
#line 45 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 48 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Movie.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                                 if (item.Movie != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                               Write(item.Movie.Title);

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                                                     
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>-</div>\r\n");
#nullable restore
#line 56 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 59 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                           Write(item.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40ea01459c63b75371991cee6fef5f2faf9ea69e11476", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 65 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Shops\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MBshop.Models.Shops>> Html { get; private set; }
    }
}
#pragma warning restore 1591
