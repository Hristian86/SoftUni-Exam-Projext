#pragma checksum "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "091ab9690e824f27c1840c8ba52f0992abc90378"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Cart), @"mvc.1.0.view", @"/Views/Cart/Cart.cshtml")]
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
#line 1 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\_ViewImports.cshtml"
using MBshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\_ViewImports.cshtml"
using MBshop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\_ViewImports.cshtml"
using MBshop.Service.WebConstants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\_ViewImports.cshtml"
using MBshop.Service.OutputModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\_ViewImports.cshtml"
using MBshop.Service.StaticProperyes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\_ViewImports.cshtml"
using MBshop.Models.ViewMovies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\_ViewImports.cshtml"
using MBshop.Models.ViewBooks;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"091ab9690e824f27c1840c8ba52f0992abc90378", @"/Views/Cart/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"149891f1b255974f767d45dfc172fd485e3e44cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ViewProducts>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n    <h1><i class=\"fa fa-shopping-cart pt-1\" id=\"cart-icon\" aria-hidden=\"true\"></i></h1>\n\n");
#nullable restore
#line 10 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
     if (Model != null)
    {
        if (Model.Count() > 0)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table\">\n                <thead>\n                    <tr>\n                        <th id=\"hide-on-mobile\">\n                            ");
#nullable restore
#line 19 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th id=\"hide-on-mobile\">\n                            ");
#nullable restore
#line 22 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th id=\"hide-on-mobile\">\n                            Price $\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 28 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                       Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th></th>\n                    </tr>\n                </thead>\n                <tbody>\n");
#nullable restore
#line 34 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td id=\"hide-on-mobile\">\n                                ");
#nullable restore
#line 38 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td id=\"hide-on-mobile\">\n                                ");
#nullable restore
#line 41 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td id=\"hide-on-mobile\">\n                                ");
#nullable restore
#line 44 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                           Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" $\n                            </td>\n                            <td>\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1688, "\"", 1707, 1);
#nullable restore
#line 47 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
WriteAttributeValue("", 1694, item.Picture, 1694, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"MovieList\" alt=\"Alternate Text\" />\n                            </td>\n                            <td>\r\n");
#nullable restore
#line 50 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                                 if (item.Type == WebConstantsVariables.Movie)
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                                     using (Html.BeginForm("RemoveMovieProduct", "Cart", new { id = item.Id }, FormMethod.Post))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""form-group"">
                                            <div class=""col-lg-10 col-lg-offset-2"">
                                                <button type=""submit"" class=""btn btn-warning"">Remove Product</button>
                                            </div>
                                        </div>
");
#nullable restore
#line 60 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"ml-4\" id=\"price-hide\">Price: ");
#nullable restore
#line 61 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                                                                      Write(item.price.ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</p>\r\n");
#nullable restore
#line 62 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                                }
                                else if (item.Type == WebConstantsVariables.Book)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                                     using (Html.BeginForm("RemoveBookProduct", "Cart", new { id = item.Id }, FormMethod.Post))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""form-group"">
                                            <div class=""col-lg-10 col-lg-offset-2"">
                                                <button type=""submit"" class=""btn btn-warning"">Remove Product</button>
                                            </div>
                                        </div>
");
#nullable restore
#line 72 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"ml-4\" id=\"price-hide\">Price: ");
#nullable restore
#line 73 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                                                                      Write(item.price.ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</p>\r\n");
#nullable restore
#line 74 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\n                        </tr>\n");
#nullable restore
#line 77 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n");
#nullable restore
#line 80 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"wrapper bg-transparent mt-5\"><h3 class=\"text-center pt-3\">There is no items in the cart</h3></div>\n");
#nullable restore
#line 85 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
        }

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"wrapper bg-transparent mt-5\"><h3 class=\"text-center pt-3\">There is no items in the cart</h3></div>\n");
#nullable restore
#line 91 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
      
        if (Model != null)
        {
            if (Model.Count() > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                 using (Html.BeginForm("CartChekout", "Cart", new { model = Model }, FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group\">\n                        <div class=\"col-lg-10 col-lg-offset-2\">\r\n");
#nullable restore
#line 101 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                              
                                var sum = $"{Model.Sum(p => p.price):f2}";
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                             foreach (var item in Model)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type=\"hidden\" name=\"productId\"");
            BeginWriteAttribute("value", " value=\"", 4563, "\"", 4579, 1);
#nullable restore
#line 107 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
WriteAttributeValue("", 4571, item.Id, 4571, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"type\"");
            BeginWriteAttribute("value", " value=\"", 4649, "\"", 4667, 1);
#nullable restore
#line 108 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
WriteAttributeValue("", 4657, item.Type, 4657, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 109 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button type=\"submit\" class=\"btn btn-danger mr-1\">Check out ");
#nullable restore
#line 110 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                                                                               Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</button>\r\n                        </div>\n                    </div>\n");
#nullable restore
#line 113 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\Pencho\Desktop\SoftUni-Exam-Projext-master – Fixing many things – Копие\MBshop\Views\Cart\Cart.cshtml"
                 
            }
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ViewProducts>> Html { get; private set; }
    }
}
#pragma warning restore 1591
