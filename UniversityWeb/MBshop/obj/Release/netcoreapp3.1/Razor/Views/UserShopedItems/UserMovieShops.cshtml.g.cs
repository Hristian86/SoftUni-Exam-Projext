#pragma checksum "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\UserShopedItems\UserMovieShops.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cc8b8bfb24a3fe2bbf489c6646b5afd609d7440"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserShopedItems_UserMovieShops), @"mvc.1.0.view", @"/Views/UserShopedItems/UserMovieShops.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc8b8bfb24a3fe2bbf489c6646b5afd609d7440", @"/Views/UserShopedItems/UserMovieShops.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8579fc7af4c90e53a0565a581932c1274a5b5cc0", @"/Views/_ViewImports.cshtml")]
    public class Views_UserShopedItems_UserMovieShops : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OutputMovies>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserShopedItems", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserBooksShops", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
  
    ViewData["Title"] = "UserShops";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
   Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s shoped products</h1>\r\n\r\n\r\n    <br />\r\n    <p class=\"bookLink\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cc8b8bfb24a3fe2bbf489c6646b5afd609d74405807", async() => {
                WriteLiteral("Book collection");
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
            WriteLiteral("\r\n    </p>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
     if (Model != null)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
         if (Model.Any())
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table\" id=\"tabul\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 26 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
                       Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            Product\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n");
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 1110, "\"", 1129, 1);
#nullable restore
#line 40 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
WriteAttributeValue("", 1116, item.Picture, 1116, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"MovieList\" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 41 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
                                 using (Html.BeginForm("MovieDetail", "MovieList", new { id = item.Id }, FormMethod.Get))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input class=\"form-control mr-sm-2\" type=\"hidden\" name=\"type\"");
            BeginWriteAttribute("value", " value=\"", 1426, "\"", 1445, 1);
#nullable restore
#line 43 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
WriteAttributeValue("", 1434, item.price, 1434, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <button type=\"submit\" class=\"btn btn-warning btn-lg\" id=\"shope-button\">Rate </button>\r\n");
#nullable restore
#line 45 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
            WriteLiteral("                                <iframe id=\"product-frame\"");
            BeginWriteAttribute("src", " src=\"", 1831, "\"", 1866, 1);
#nullable restore
#line 49 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
WriteAttributeValue("", 1837, item.LinkForPurchasedContend, 1837, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </iframe>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 57 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"wrapper bg-transparent mt-5\"><h3 class=\"text-center pt-3\">There are no products</h3></div>\r\n");
#nullable restore
#line 62 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\UserShopedItems\UserMovieShops.cshtml"
         

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OutputMovies>> Html { get; private set; }
    }
}
#pragma warning restore 1591
