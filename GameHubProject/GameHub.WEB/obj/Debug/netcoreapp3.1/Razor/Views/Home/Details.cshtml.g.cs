#pragma checksum "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b98b1218308dd7c0046278c18481183b3bdc3600"
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
#line 1 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\_ViewImports.cshtml"
using GameHub.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\_ViewImports.cshtml"
using GameHub.WEB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\_ViewImports.cshtml"
using GameHub.WEB.Models.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\_ViewImports.cshtml"
using GameHub.WEB.Models.Game;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\_ViewImports.cshtml"
using GameHub.WEB.Models.Brand;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b98b1218308dd7c0046278c18481183b3bdc3600", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8910b1bd4dfab2cd2cad0b91f6eb2a0cc6352f17", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("error"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/02b1cafb-7e4c-49ce-a372-2af8bbaa01f2_9-600x400.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .checked {
        color: orange;
    }
</style>
<div class=""banner"">
    <div class=""bnr2"">
    </div>
</div>
<div class=""container"">
    <div class=""blog"">
        <div class=""container"">
            <div class=""col-md-8 blog-left"">
                <div class=""blog-info"">
                    <input id=""Gameid""");
            BeginWriteAttribute("value", " value=\"", 399, "\"", 420, 1);
#nullable restore
#line 19 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
WriteAttributeValue("", 407, Model.GameId, 407, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input id=\"UserId\"");
            BeginWriteAttribute("value", " value=\"", 464, "\"", 485, 1);
#nullable restore
#line 20 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
WriteAttributeValue("", 472, Model.UserId, 472, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 21 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
                     if (@Model.UserName != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input id=\"gameid1\"");
            BeginWriteAttribute("value", " value=\"", 608, "\"", 660, 1);
#nullable restore
#line 23 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
WriteAttributeValue("", 616, Model.Categorys.FirstOrDefault().CategoryId, 616, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n");
#nullable restore
#line 24 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input id=\"gameid1\" value=\"2\" />\r\n");
#nullable restore
#line 28 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h1 style=\"font-size: 4em; line-height: 1.1; color: #29292f;\">\r\n                        ");
#nullable restore
#line 30 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
                   Write(Model.GameName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h1>\r\n                    <hr />\r\n                    <div class=\"blog-info-text\">\r\n                        <div class=\"blog-img\">\r\n");
#nullable restore
#line 35 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
                             if (@Model.UserName != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b98b1218308dd7c0046278c18481183b3bdc36008364", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1236, "~/images/", 1236, 9, true);
#nullable restore
#line 37 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 1245, Model.Images.FirstOrDefault().PathImage, 1245, 40, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b98b1218308dd7c0046278c18481183b3bdc360010307", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <hr />\r\n                        ");
#nullable restore
#line 45 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
                   Write(Html.Raw(Model.Desciption));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
                    </div>
                    <div class=""comment-icons"">
                        <ul>
                            <li><span></span><a href=""#"">Lorem ipsum dolor sit</a> </li>
                            <li><span class=""clndr""></span>");
#nullable restore
#line 50 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
                                                      Write(Model.CreateDate.ToString("MMM, dd,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><span class=\"admin\"></span> <a href=\"#\">");
#nullable restore
#line 51 "C:\Users\XuanHoang\Desktop\Gamehub\Longdev\GameHubProject\GameHub.WEB\Views\Home\Details.cshtml"
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
                <div class=""coment-form"">
                    <h4>Leave your comment</h4>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b98b1218308dd7c0046278c18481183b3bdc360013641", async() => {
                WriteLiteral("\r\n                        <input type=\"text\" value=\"Name \" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Name\';}\"");
                BeginWriteAttribute("required", " required=\"", 2848, "\"", 2859, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"text\" value=\"Subject \" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Subject\';}\"");
                BeginWriteAttribute("required", " required=\"", 3006, "\"", 3017, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"text\" value=\"Email (will not be published)*\" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Email (will not be published)*\';}\"");
                BeginWriteAttribute("required", " required=\"", 3209, "\"", 3220, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <textarea id=\"text\" placeholder=\"Your Comment...\"></textarea>\r\n                        <input type=\"submit\" value=\"SUBMIT\" id=\"Post\">\r\n                    ");
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
                WriteLiteral(@" 
<script>
    var CategoryId = parseInt(document.getElementById('gameid1').value);
    
    var GameId = parseInt(document.getElementById('Gameid').value);
    var UserId = document.getElementById('UserId').value;
    debugger;
    var GetGameByCategory = function (id) {
        $.ajax({
            url: `/game/getbycategory/${id}`,
            method: 'GET',
            dataType: 'JSON',
            success: function (response) {
                var dem = 0;
                $.each(response.result, function (i, v) {
                    dem++;
                    if (dem > response.result.length - 3) {
                        $('.recent-posts').append(`
                        <div class=""recent-posts-info"">
                            <div class=""posts-left sngl-img"">
                                <a href=""#""> <img src=""images/"" class=""img-responsive zoom-img"" alt="""" /> </a>
                            </div>
                            <div class=""posts-right"">
                     ");
                WriteLiteral(@"           <label>March 5, 2015</label>
                                <h5><a href=""single.html"">Finibus Bonorum</a></h5>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing incididunt.</p>
                                <a href=""single.html"" class=""btn btn-primary hvr-rectangle-in"">Read More</a>
                            </div>
                            <div class=""clearfix""> </div>
                        </div>
                    `);
                    }
                })
            }
        });

    };
    $(""#Post"").click(function () {
        var saveObj = {};
        saveObj.text = $('#text').val();
        saveObj.gameId = parseInt($('#Gameid').val());
        saveObj.userId = $('#UserId').val();
        debugger;
        $.ajax({
            url: '/Post/save',
            method: 'POST',
            data: saveObj,
            success: function (response) {
                console.log(response);
                bootbox.alert(respo");
                WriteLiteral(@"nse.data.message);
            }
        });
    });
    var GetComment = function (id) {
        $.ajax({
            url: `/Post/Gets/${id}`,
            method: ""GET"",
            dataType: ""json"",
            success: function (response) {
                console.log(response);
                $.each(response.result, function (i, v) {
                    $(""#add"").append(`
                        <div class=""media response-info"">
                            <div class=""media-left response-text-left"">
                                    <a href=""#"">
                                        <img class=""media-object"" src=""~/template/images/icon1.png"" alt=""error"" />
                                    </a>
                                    <h5><a href=""#"">Admin</a></h5>
                                </div>
                                    <div class=""media-body response-text-right"">
                                        <p>
                                            Lorem ipsum ");
                WriteLiteral(@"dolor sit amet, consectetur adipisicing elit,There are many variations of passages of Lorem Ipsum available,
                                            sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                                            </p>
                                        <ul>
                                            <li>MARCH 21, 2013</li>
                                            <li><a href=""single.html"">Reply</a></li>
                                        </ul>
                                    </div>
                                    <div class=""clearfix""> </div>
                        </div>
                        `);

                });
            }
        });
    }
    var vote = 0;
    $(document).ready(function () {
        GetGameByCategory(CategoryId);
        GetComment(GameId);
        checkRate(GameId, UserId);
    });
    function onmove(id) {
        if (id >= 1) {
            for (let i = 1; i <= id; i++) {
        ");
                WriteLiteral(@"        document.getElementById(i).style.color = ""orange"";
            }
            for (let i = id + 1; i <= 5; i++) {
                document.getElementById(i).style.color = ""black"";
            }
        }
        vote = id;
    }
    function click(id) {
        var Obj = {};
        Obj.userId = $('#UserId').val();
        Obj.gameId = GameId;
        Obj.vote = parseInt(id);
        $.ajax({
            url: '/Rate/saveVote',
            method: 'POST',
            data: Obj,
            success: function () {
                alert(""Success Rate! thanks"");
            }
        });
    }
    var checkRate = function (GameId, UserId) {
        $.ajax({
            url: `/Post/CheckVote/${GameId}/${UserId}`,
            method: ""GET"",
            dataType: ""json"",
            success: function (response) {
                console.log(response.result);
                $(""#addcheck"").empty();
                if (response.result.check = 0) {
                    $(""#addcheck"")");
                WriteLiteral(@".append(`
                    <span id=""1"" onmousemove=""onmove(1)"" onclick=""click(1)"" class=""fa fa-star checked""></span>
                    <span id=""2"" onmousemove=""onmove(2)"" onclick=""click(2)"" class=""fa fa-star checked""></span>
                    <span id=""3"" onmousemove=""onmove(3)"" onclick=""click(3)"" class=""fa fa-star""></span>
                    <span id=""4"" onmousemove=""onmove(4)"" onclick=""click(4)"" class=""fa fa-star""></span>
                    <span id=""5"" onmousemove=""onmove(5)"" onclick=""click(5)"" class=""fa fa-star""></span>
                `);
                }
                else {
                    $(""#addcheck"").append(`
                    <h3>Checked</h3>
                `);
                }
            }
        });
    }
</script>
");
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