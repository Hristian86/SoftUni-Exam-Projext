#pragma checksum "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8988d2f98ca27660483d5aa0c39127d63f519fac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserShopedItems_UserBooksShops), @"mvc.1.0.view", @"/Views/UserShopedItems/UserBooksShops.cshtml")]
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
#line 1 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\_ViewImports.cshtml"
using MBshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\_ViewImports.cshtml"
using MBshop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\_ViewImports.cshtml"
using MBshopService.WebConstants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8988d2f98ca27660483d5aa0c39127d63f519fac", @"/Views/UserShopedItems/UserBooksShops.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e1699700dbaa7d2c95adf4bcd0bb8e85078e03b", @"/Views/_ViewImports.cshtml")]
    public class Views_UserShopedItems_UserBooksShops : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MBshopService.OutputModels.OutputBooks>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserShopedItems", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserMovieShops", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
  
    ViewData["Title"] = "UserBooksShops";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
   Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s shoped products</h1>\r\n\r\n<br />\r\n<p class=\"movieLink\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8988d2f98ca27660483d5aa0c39127d63f519fac5328", async() => {
                WriteLiteral("Movie Collection");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\" id=\"tabul\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
           Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
           Write(Html.DisplayNameFor(model => model.Raiting));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Released\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
           Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Product\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
           Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 48 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
           Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
           Write(Html.DisplayFor(modelItem => item.Raiting));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
           Write(Html.DisplayFor(modelItem => item.RealeseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
           Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" $\r\n            </td>\r\n            <td>\r\n");
            WriteLiteral("                <iframe width=\"420\" height=\"315\"");
            BeginWriteAttribute("src", "\r\n                        src=\"", 2168, "\"", 2238, 1);
#nullable restore
#line 75 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
WriteAttributeValue("", 2199, item.LinkForProductContentWhenPurchase, 2199, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </iframe>\r\n                \r\n            </td>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 2344, "\"", 2363, 1);
#nullable restore
#line 80 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
WriteAttributeValue("", 2350, item.Picture, 2350, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"MovieList\" alt=\"Alternate Text\" />\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 83 "C:\Users\Pencho\Desktop\testoveteweba\WebAppProjectCurrent\WebAppProject\WebAppProject\WebAppProject\WebAppProject\Views\UserShopedItems\UserBooksShops.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MBshopService.OutputModels.OutputBooks>> Html { get; private set; }
    }
}
#pragma warning restore 1591
