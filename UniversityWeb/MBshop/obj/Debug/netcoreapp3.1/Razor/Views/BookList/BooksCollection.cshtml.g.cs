#pragma checksum "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05f9701ca35894e0bf919529f1ff0fd2eee798af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookList_BooksCollection), @"mvc.1.0.view", @"/Views/BookList/BooksCollection.cshtml")]
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
#line 1 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\_ViewImports.cshtml"
using MBshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\_ViewImports.cshtml"
using MBshop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\_ViewImports.cshtml"
using MBshop.Service.WebConstants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\_ViewImports.cshtml"
using MBshop.Service.OutputModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\_ViewImports.cshtml"
using MBshop.Service.StaticProperyes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\_ViewImports.cshtml"
using MBshop.Models.ViewMovies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\_ViewImports.cshtml"
using MBshop.Models.ViewBooks;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05f9701ca35894e0bf919529f1ff0fd2eee798af", @"/Views/BookList/BooksCollection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"149891f1b255974f767d45dfc172fd485e3e44cb", @"/Views/_ViewImports.cshtml")]
    public class Views_BookList_BooksCollection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MBshop.Service.OutputModels.OutputBooks>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MovieList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MovieCollection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("$(\'#autoPost\').submit();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BookList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BooksCollection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("autoPost"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("orderForm btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserShopedItems", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserBooksShops", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:15px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("button-padding"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
  
    ViewData["Title"] = "Book Collection";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"container\">\n\n        <h1>");
#nullable restore
#line 9 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n        <br />\n        <p class=\"movieLink\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f9701ca35894e0bf919529f1ff0fd2eee798af11672", async() => {
                WriteLiteral("Movie collection");
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
            WriteLiteral("\n        </p>\n");
#nullable restore
#line 15 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
         if (Model != null)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f9701ca35894e0bf919529f1ff0fd2eee798af13460", async() => {
                WriteLiteral("\n            <select name=\"orderBy\" class=\"custom-select-sm drop\">\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f9701ca35894e0bf919529f1ff0fd2eee798af13804", async() => {
                    WriteLiteral("Original order");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f9701ca35894e0bf919529f1ff0fd2eee798af15050", async() => {
                    WriteLiteral("Order by Title A-Z");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f9701ca35894e0bf919529f1ff0fd2eee798af16300", async() => {
                    WriteLiteral("Order by Title Z-A");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f9701ca35894e0bf919529f1ff0fd2eee798af17550", async() => {
                    WriteLiteral("Order by Price ascending");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f9701ca35894e0bf919529f1ff0fd2eee798af18806", async() => {
                    WriteLiteral("Order by Price descending");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            </select>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 28 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
   Write(Html.ActionLink("Original order", "BooksCollection", "BookList", new { orderBy = 0 }, new { @class = "btn btn-outline-success order-btn" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
   Write(Html.ActionLink("Order by Title A-Z", "BooksCollection", "BookList", new { orderBy = 1 }, new { @class = "btn btn-outline-success order-btn" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
   Write(Html.ActionLink("Order by Title Z-A", "BooksCollection", "BookList", new { orderBy = 2 }, new { @class = "btn btn-outline-success order-btn" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
   Write(Html.ActionLink("Order by Price ascending", "BooksCollection", "BookList", new { orderBy = 3 }, new { @class = "btn btn-outline-success order-btn" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
   Write(Html.ActionLink("Order by Price descending", "BooksCollection", "BookList", new { orderBy = 4 }, new { @class = "btn btn-outline-success order-btn" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"table-responsive-sm\">\n            <table class=\"table\" id=\"tabul\">\n                <thead>\n                    <tr>\n                        <th id=\"hide-on-mobile\">\n                            ");
#nullable restore
#line 39 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th id=\"hide-on-mobile\">\n                            ");
#nullable restore
#line 42 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                       Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th id=\"hide-on-mobile\">\n                            Rating\n                        </th>\n                        <th id=\"hide-on-mobile\">\n                            ");
#nullable restore
#line 48 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th id=\"hide-on-mobile\">\n                            Released\n                        </th>\n                        <th id=\"hide-on-mobile\">\n                            ");
#nullable restore
#line 54 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th id=\"hide-on-mobile\" class=\"price-title\">\n                            Price $\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 60 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                       Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th></th>\n                    </tr>\n                </thead>\n                <tbody>\n");
#nullable restore
#line 66 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td id=\"hide-on-mobile\">\n                                ");
#nullable restore
#line 70 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td id=\"hide-on-mobile\">\n                                ");
#nullable restore
#line 73 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td id=\"hide-on-mobile\">\n                                ");
#nullable restore
#line 76 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td id=\"hide-on-mobile\">\n                                ");
#nullable restore
#line 79 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td id=\"hide-on-mobile\">\n                                ");
#nullable restore
#line 82 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                           Write(Html.DisplayFor(modelItem => item.RealeseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td id=\"hide-on-mobile\">\n                                ");
#nullable restore
#line 85 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td id=\"hide-on-mobile\">\n                                ");
#nullable restore
#line 88 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                           Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" $\n                            </td>\n                            <td>\n                                <img");
            BeginWriteAttribute("src", " src=\"", 4418, "\"", 4437, 1);
#nullable restore
#line 91 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
WriteAttributeValue("", 4424, item.Picture, 4424, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"MovieList\" alt=\"Alternate Text\" />\n                            </td>\n                            <td>\r\n");
#nullable restore
#line 94 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                                 if (item.Status == false)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"price-mobile\" id=\"price-hide\">");
#nullable restore
#line 96 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                                                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 97 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                                    var rate = $"{item.Rate:f1}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"price-mobile\" id=\"price-hide\">Rate: ");
#nullable restore
#line 98 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                                                                             Write(rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"price-mobile\" id=\"price-hide\">Price: ");
#nullable restore
#line 99 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                                                                              Write(item.price.ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</p>\r\n");
#nullable restore
#line 100 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                                     using (Html.BeginForm("BookDetail", "BookList", new { id = item.Id }, FormMethod.Get))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""form-group"">
                                            <div class=""col-lg-10 col-lg-offset-2"">
                                                <button type=""submit"" class=""btn btn-outline-primary"">Purchase</button>
                                            </div>
                                        </div>
");
#nullable restore
#line 107 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                                     
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"price-mobile\" id=\"price-hide\">");
#nullable restore
#line 111 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                                                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 112 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                                    var rate = $"{item.Rate:f1}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"price-mobile\" id=\"price-hide\">Rate: ");
#nullable restore
#line 113 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                                                                             Write(rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"price-mobile\" id=\"price-hide\">Price: </p>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f9701ca35894e0bf919529f1ff0fd2eee798af35983", async() => {
                WriteLiteral("Owned");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_16);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_17);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 116 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\n                        </tr>\n");
#nullable restore
#line 119 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n");
#nullable restore
#line 123 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\BookList\BooksCollection.cshtml"
        
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MBshop.Service.OutputModels.OutputBooks>> Html { get; private set; }
    }
}
#pragma warning restore 1591
