#pragma checksum "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "895fcc282e11b007f81372d205f08efe275d4f8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\_ViewImports.cshtml"
using GameHub.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\_ViewImports.cshtml"
using GameHub.WEB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\_ViewImports.cshtml"
using GameHub.WEB.Models.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\_ViewImports.cshtml"
using GameHub.WEB.Models.Game;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\_ViewImports.cshtml"
using GameHub.WEB.Models.Brand;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"895fcc282e11b007f81372d205f08efe275d4f8b", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8910b1bd4dfab2cd2cad0b91f6eb2a0cc6352f17", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:darkgrey"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllGame", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/404.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Layout/Details.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""banner"">
    <div class=""bnr2"">
    </div>
</div>
<div class=""agileits_breadcrumbs"">
    <div class=""container"">
        <div class=""agileits_breadcrumbs_left street"">
            <ul style=""font-size: smaller; margin-bottom: 24px;"">
                <li>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "895fcc282e11b007f81372d205f08efe275d4f8b7304", async() => {
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<i class=\"fa fa-angle-right\" style=\"font-size:14px\"></i>\r\n                </li>\r\n                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "895fcc282e11b007f81372d205f08efe275d4f8b8848", async() => {
                WriteLiteral("Game Offline");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n        <div class=\"clearfix\"> </div>\r\n    </div>\r\n</div>\r\n<div class=\"container\">\r\n    <input hidden id=\"Gameid\"");
            BeginWriteAttribute("value", " value=\"", 766, "\"", 787, 1);
#nullable restore
#line 23 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
WriteAttributeValue("", 774, Model.GameId, 774, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input hidden id=\"UserId\"");
            BeginWriteAttribute("value", " value=\"", 822, "\"", 843, 1);
#nullable restore
#line 24 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
WriteAttributeValue("", 830, Model.UserId, 830, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 25 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
     if (@Model.Desciption != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input hidden id=\"gameid1\" value=\"1\" />\r\n");
#nullable restore
#line 28 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input hidden id=\"gameid1\" value=\"1\" />\r\n");
#nullable restore
#line 32 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 style=\"font-size: 4em; line-height: 1.1; color: #29292f;\">\r\n        ");
#nullable restore
#line 34 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
   Write(Model.GameName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    <hr />\r\n    <div class=\"blog-img\">\r\n");
#nullable restore
#line 38 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
         if (@Model.Desciption != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "895fcc282e11b007f81372d205f08efe275d4f8b12659", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1240, "~/images/", 1240, 9, true);
#nullable restore
#line 40 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 1249, Model.Images.FirstOrDefault().PathImage, 1249, 40, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "895fcc282e11b007f81372d205f08efe275d4f8b14503", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>
<div class=""container"">
    <div class=""blog"">
        <div class=""container"">
            <div class=""col-md-8 blog-left"">
                <div class=""blog-info"">
                    <div class=""blog-info-text"">
                        <hr />
                        ");
#nullable restore
#line 55 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
                   Write(Html.Raw(Model.Desciption));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                    </div>\r\n                    <div class=\"comment-icons\">\r\n                        <ul>\r\n                            <li><span class=\"clndr\"></span>");
#nullable restore
#line 59 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
                                                      Write(Model.CreateDate.ToString("MMM, dd,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><span class=\"admin\"></span> <a href=\"#\">By ");
#nullable restore
#line 60 "C:\Users\Admin\Documents\GameHub\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
                                                                      Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>
                            <li><span class=""cmnts""></span> <a href=""#"">5 comments</a></li>
                            <li><a href=""#"" class=""like"">15</a></li>
                        </ul>
                    </div>
                    <div class=""col-3"" id=""addcheck"">
                    </div>
                    <div class=""response"">
                        <h4>Comment</h4>
                        <div id=""add"">
                        </div>
                    </div>
                </div>
                <div id=""formRep"" class=""coment-form"">
                    <h4>Bình luận</h4>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "895fcc282e11b007f81372d205f08efe275d4f8b17914", async() => {
                WriteLiteral("\r\n                        <input type=\"text\" value=\"Name \" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Name\';}\"");
                BeginWriteAttribute("required", " required=\"", 2817, "\"", 2828, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"text\" value=\"Subject \" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Subject\';}\"");
                BeginWriteAttribute("required", " required=\"", 2975, "\"", 2986, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"text\" value=\"Email (will not be published)*\" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Email (will not be published)*\';}\"");
                BeginWriteAttribute("required", " required=\"", 3178, "\"", 3189, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <textarea id=\"text\" placeholder=\"Bình Luận\"></textarea>\r\n                        <input type=\"submit\" value=\"Bình luận\" id=\"Post\">\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-md-4 single-page-right"">
                <div class=""category blog-ctgry"">
                    <h4>Top Games</h4>
                    <div class=""list-group"">
                        <a href=""single.html"" class=""list-group-item"">Cras justo odio</a>
                        <a href=""single.html"" class=""list-group-item"">Dapibus ac facilisis in</a>
                        <a href=""single.html"" class=""list-group-item"">Morbi leo risus</a>
                        <a href=""single.html"" class=""list-group-item"">Porta ac consectetur ac</a>
                        <a href=""single.html"" class=""list-group-item"">Vestibulum at eros</a>
                        <a href=""single.html"" class=""list-group-item"">Cras justo odio</a>
                        <a href=""single.html"" class=""list-group-item"">Cras justo odio</a>
                        <a href=""single.html"" class=""list-group-item"">Cras justo odio</a>
                    </div>
            ");
            WriteLiteral(@"    </div>
                <div class=""recent-posts"">
                    <h4>Game tương tự</h4>
                    <div class=""clearfix""> </div>
                </div>
            </div>
            <div class=""clearfix""> </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "895fcc282e11b007f81372d205f08efe275d4f8b21812", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameView> Html { get; private set; }
    }
}
#pragma warning restore 1591
