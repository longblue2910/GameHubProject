#pragma checksum "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a48a513e1f33c584b845a550100626ecab35664d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\_ViewImports.cshtml"
using GameHub.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\_ViewImports.cshtml"
using GameHub.WEB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\_ViewImports.cshtml"
using GameHub.WEB.Models.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\_ViewImports.cshtml"
using GameHub.WEB.Models.Game;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\_ViewImports.cshtml"
using GameHub.WEB.Models.Brand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\_ViewImports.cshtml"
using GameHub.WEB.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\_ViewImports.cshtml"
using GameHub.Domain.Request.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Account\Index.cshtml"
using GameHub.Domain.Common1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a48a513e1f33c584b845a550100626ecab35664d", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71c54fcfba35c73dd5153328d91ea900b4a1fc7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedResult<GameHub.Domain.Request.User.UserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_DashboardLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a48a513e1f33c584b845a550100626ecab35664d6225", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table table-borderless table-striped"">
    <thead>
        <tr>
            <th>
                FullName
            </th>
            <th>
                Address
            </th>
            <th>
                Gender
            </th>
            <th>
                Dob
            </th>
            <th>
                Company
            </th>
            <th>
                Facebook
            </th>
            <th>
                Image
            </th>
            <th>
                Status
            </th>
            <th></th>
            <th>Role</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 46 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Account\Index.cshtml"
 foreach (var item in Model.Items) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DoB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Facebook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a48a513e1f33c584b845a550100626ecab35664d10313", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1649, "~/images/Avatar/", 1649, 16, true);
#nullable restore
#line 67 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Account\Index.cshtml"
AddHtmlAttributeValue("", 1665, item.ImagePath, 1665, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsDelete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Account\Index.cshtml"
           Write(Html.ActionLink("Edit", "Update", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 74 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Account\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 75 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Account\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Account\Index.cshtml"
           Write(Html.ActionLink("Role", "RoleAssign", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 81 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Account\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedResult<GameHub.Domain.Request.User.UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
