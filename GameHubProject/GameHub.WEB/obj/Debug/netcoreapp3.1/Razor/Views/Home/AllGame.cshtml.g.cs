#pragma checksum "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Home\AllGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34e5a31ab84639299a0d4295be4047dd2a1f6754"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllGame), @"mvc.1.0.view", @"/Views/Home/AllGame.cshtml")]
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
#line 1 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Home\AllGame.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Home\AllGame.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34e5a31ab84639299a0d4295be4047dd2a1f6754", @"/Views/Home/AllGame.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71c54fcfba35c73dd5153328d91ea900b4a1fc7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllGame : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<GameView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("example-image-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-lightbox", new global::Microsoft.AspNetCore.Html.HtmlString("example-set"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-title", new global::Microsoft.AspNetCore.Html.HtmlString("Click the right half of the image to move forward."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Home\AllGame.cshtml"
  
    ViewData["Title"] = "All Game";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    a {
        color: #383838;
    }

    a {
        color: #334862;
        text-decoration: none;
    }

    a, button, input {
        -ms-touch-action: manipulation;
        touch-action: manipulation;
    }
</style>
<div class=""banner"">
    <div class=""bnr2"">
    </div>
</div>
<div class=""agileits_breadcrumbs"">
    <div class=""container"">
        <div class=""agileits_breadcrumbs_left street"">
            <ul style=""font-size: smaller; margin-bottom: 24px;"">
                <li>
                    <a style=""color:black"" href=""#"">Home </a><i class=""fa fa-angle-right"" style=""font-size:14px""></i>
                </li>
                <li><a style=""color:darkgrey"" href=""#"">Game Offline</a></li>
            </ul>
        </div>
        <div class=""clearfix""> </div>
    </div>
</div>
<div class=""gallery"">
    <div class=""container"">
        <h1 class=""jeg_cat_title"">Game Offline</h1>
        <hr />
        <p class=""jeg_cat_subtitle"">
            Tải Game Offline");
            WriteLiteral(@" cho PC, Laptop với đầy đủ các thể loại hành động, bắn súng, đua xe, phiêu lưu, chiến thuật...
            Game sẽ được cập nhật liên tục đưa đến cho bạn một kho trò chơi chất lượng.
            Và bạn sẽ không mất một khoản phí nào để có thể Download.
        </p>
        <h3 class=""h3-1"">
            Game Offline Hay Cho PC ""Chất Nhất""
        </h3>
        <p style=""font-size:15px"">Trong chuyên mục này có đầy đủ các game cho mọi dòng máy PC, laptop. Cấu hình yêu cầu của game từ thấp - nhẹ cho đến cấu hình cao tha hồ mà lựa chọn nha.</p>
        <p class=""alert alert-info"">Từ khóa tìm kiếm nhiều: game offline hay cho pc cau hinh trung binh, game offline hay cho laptop.</p>
        <p style=""font-size:15px"">Đã lâu rồi không cập nhật bài viết này nên vào đây viết đôi lời chia sẻ với anh em:</p>
        <p style=""font-size:15px"">Cảm ơn tất cả anh em trong thời gian qua đã luôn ủng hộ cho Game Hub. 
        Mong rằng thời gian tới tất cả anh em sẽ đồng hành cùng với");
            WriteLiteral(@" ad. Quảng đường cũng hơn 2 năm rồi.
        Mong rằng sẽ có 3 4 5 năm và lâu hơn nữa. Cảm ơn anh em rất nhiều.</p>
        <p style=""font-size:15px"">Những Game Offline cho máy tính luôn là lựa chọn thích hợp cho việc giải trí. 
        Khí Phách sẽ đưa đến cho bạn rất nhiều sự lựa chọn, hi vọng sẽ có tựa game mà bạn yêu thích. 
        Thường xuyên quay lại chuyên mục để cập nhật và tải những trò chơi mới nhất. Theo dõi chúng tôi trên Facebook để không bỏ lỡ những tựa game HOT.</p>
        <hr />
        <div class=""gallery-bottom"">
            <div class=""gallery-1"">
");
#nullable restore
#line 63 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Home\AllGame.cshtml"
                 foreach (var item in Model)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Home\AllGame.cshtml"
                     if (item.StatusName == "active")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-4 gallery-grid\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34e5a31ab84639299a0d4295be4047dd2a1f67549889", async() => {
                WriteLiteral("\r\n                                <img class=\"example-image\"");
                BeginWriteAttribute("src", " src=\"", 3287, "\"", 3316, 2);
                WriteAttributeValue("", 3293, "/images/", 3293, 8, true);
#nullable restore
#line 69 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Home\AllGame.cshtml"
WriteAttributeValue("", 3301, item.PathImage, 3301, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 3317, "\"", 3323, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"height: 150px\"/>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Home\AllGame.cshtml"
                                                                            WriteLiteral(item.GameId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34e5a31ab84639299a0d4295be4047dd2a1f675413266", async() => {
                WriteLiteral("<label>");
#nullable restore
#line 71 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Home\AllGame.cshtml"
                                                                                                        Write(item.GameName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Home\AllGame.cshtml"
                                                                            WriteLiteral(item.GameId);

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
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 73 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Home\AllGame.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Home\AllGame.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"clearfix\"></div>\r\n            </div>\r\n        </div>\r\n            ");
#nullable restore
#line 78 "C:\Users\XuanHoang\Desktop\NewGamehub\GameHubProject\GameHub.WEB\Views\Home\AllGame.cshtml"
       Write(Html.PagedListPager(Model, page => Url.Action($"AllGame", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<GameView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
