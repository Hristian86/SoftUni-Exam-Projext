#pragma checksum "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaf73864d54b49df330db65616e2e6f077e23d7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaf73864d54b49df330db65616e2e6f077e23d7f", @"/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"149891f1b255974f767d45dfc172fd485e3e44cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OutPutViewBooks>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\n        <h1>Create book</h1>\n\n        <p>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaf73864d54b49df330db65616e2e6f077e23d7f6908", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\n        </p>\n\n        <div class=\"table-responsive-sm\">\n            <table class=\"table\">\n                <thead>\n                    <tr>\n                        <th>\n                            ");
#nullable restore
#line 18 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 21 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 24 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 27 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.RealeseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 30 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 33 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            Rating\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 39 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            Product\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 45 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th></th>\n                    </tr>\n                </thead>\n                <tbody>\n");
#nullable restore
#line 51 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>\n                                ");
#nullable restore
#line 55 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 58 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 61 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 64 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.RealeseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n\n                            <td>\n                                ");
#nullable restore
#line 68 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 71 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 74 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 77 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                <iframe width=\"420\" height=\"315\"");
            BeginWriteAttribute("src", "\n                                        src=\"", 3062, "\"", 3147, 1);
#nullable restore
#line 81 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
WriteAttributeValue("", 3108, item.LinkForProductContentWhenPurchase, 3108, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                </iframe>\n                            </td>\n                            <td>\n                                <img");
            BeginWriteAttribute("src", " src=\"", 3295, "\"", 3314, 1);
#nullable restore
#line 85 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
WriteAttributeValue("", 3301, item.Picture, 3301, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"MovieList\" alt=\"Alternate Text\" />\n                            </td>\n                            <td>\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaf73864d54b49df330db65616e2e6f077e23d7f17228", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" <br />\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaf73864d54b49df330db65616e2e6f077e23d7f19612", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" <br />\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaf73864d54b49df330db65616e2e6f077e23d7f22002", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                            </td>\n                        </tr>\n");
#nullable restore
#line 93 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Fixing many things\MBshop\Views\Books\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OutPutViewBooks>> Html { get; private set; }
    }
}
#pragma warning restore 1591
