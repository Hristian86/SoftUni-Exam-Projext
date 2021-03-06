#pragma checksum "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1421d89ec682258dd0923b888414e5ab48f5960b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 2 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Areas\Admin\Views\Home\Index.cshtml"
using MBshop.Service.OutputModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1421d89ec682258dd0923b888414e5ab48f5960b", @"/Areas/Admin/Views/Home/Index.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OutputRoleAssignModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "User Roles";
    var Admin = "Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <h1>");
#nullable restore
#line 12 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Areas\Admin\Views\Home\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n");
            WriteLiteral("                    Users\r\n                </th>\r\n                <th>\r\n");
            WriteLiteral("                    Role\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 61 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Areas\Admin\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n");
            WriteLiteral("                        ");
#nullable restore
#line 66 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Users));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            WriteLiteral("                        ");
#nullable restore
#line 70 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UserRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 73 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Areas\Admin\Views\Home\Index.cshtml"
                          
                            var roles = Model.ToList();
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Areas\Admin\Views\Home\Index.cshtml"
                         if (item.UserRole != Admin)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <form asp-controller=""UserRoles"" asp-action=""Edit"" method=""post"">

                                <select class=""custom-select-sm drop"" name=""userRole"">

                                    <option value=""User"">User</option>
                                    <option value=""Moderator"">Moderator</option>
");
            WriteLiteral("\r\n                                </select>\r\n                                <input type=\"hidden\" name=\"userName\"");
            BeginWriteAttribute("value", " value=\"", 3411, "\"", 3430, 1);
#nullable restore
#line 87 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 3419, item.Users, 3419, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"userId\"");
            BeginWriteAttribute("value", " value=\"", 3502, "\"", 3522, 1);
#nullable restore
#line 88 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 3510, item.userId, 3510, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <input type=\"submit\" class=\"btn btn-secondary\" name=\"name\" value=\"Add Role\" />\r\n\r\n                            </form>\r\n");
#nullable restore
#line 92 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Areas\Admin\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 95 "G:\FilesForGithub\SoftUni-Exam-Projext\UniversityWeb\MBshop\Areas\Admin\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OutputRoleAssignModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
