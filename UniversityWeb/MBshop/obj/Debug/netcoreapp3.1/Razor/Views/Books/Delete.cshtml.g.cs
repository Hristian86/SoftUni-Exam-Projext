#pragma checksum "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26512caf1a338e85ca05c871e10f54ee138532e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Delete), @"mvc.1.0.view", @"/Views/Books/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26512caf1a338e85ca05c871e10f54ee138532e5", @"/Views/Books/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"826b060901f52d9bf02c148d94d0fe92e16fe72b", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MBshop.Models.Books>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Books</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 15 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 18 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 21 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 24 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 27 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 30 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 33 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 36 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 39 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RealeseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 42 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RealeseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 45 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 48 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 51 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 54 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 57 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 60 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 63 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 66 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 69 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Raiting));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 72 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Raiting));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 75 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 78 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26512caf1a338e85ca05c871e10f54ee138532e513972", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "26512caf1a338e85ca05c871e10f54ee138532e514237", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 83 "C:\Users\Pencho\Desktop\testoveteweba\SoftUni-Exam-Projext-master\SoftUni-Exam-Projext-master – Копие\MBshop\Views\Books\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26512caf1a338e85ca05c871e10f54ee138532e516075", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
                WriteLiteral("\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MBshop.Models.Books> Html { get; private set; }
    }
}
#pragma warning restore 1591
