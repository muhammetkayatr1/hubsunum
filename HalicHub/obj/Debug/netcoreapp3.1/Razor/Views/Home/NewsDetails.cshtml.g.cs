#pragma checksum "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c48440e58b3023e36f1138a5103864444969f7ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NewsDetails), @"mvc.1.0.view", @"/Views/Home/NewsDetails.cshtml")]
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
#line 1 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\_ViewImports.cshtml"
using Halic.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c48440e58b3023e36f1138a5103864444969f7ab", @"/Views/Home/NewsDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d447f06f600cad35a08585f36a3d6ae0aa3e3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NewsDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#fff !important; padding:5px 15px 5px 15px;  color:black !important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewsList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("author_img rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AuthorDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewsDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewsEmail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
Write(await Html.PartialAsync("_Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"blog_area p_120 single-post-area\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-lg-8\">\n                <div class=\"main_blog_details\">\n                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 266, "\"", 294, 2);
            WriteAttributeValue("", 272, "/img/", 272, 5, true);
#nullable restore
#line 7 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
WriteAttributeValue("", 277, Model.News.Image, 277, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 295, "\"", 301, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    <a href=\"#\"><h4>");
#nullable restore
#line 8 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                               Write(Model.News.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\n                    <div class=\"user_details\">\n\n");
#nullable restore
#line 11 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                         foreach (var item in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c48440e58b3023e36f1138a5103864444969f7ab9544", async() => {
#nullable restore
#line 13 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                                                                                                                                                                                    Write(item.Tittle);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categories", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                                                                                                                                                                  WriteLiteral(item.Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categories"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categories", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categories"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 13 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                                                                                                                                                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"float-right\">\n                            <div class=\"media\">\n                                <div class=\"media-body\">\n");
#nullable restore
#line 17 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                                     foreach (var item in Model.Authors)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5>");
#nullable restore
#line 19 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                       Write(item.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>");
#nullable restore
#line 19 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>");
#nullable restore
#line 20 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                                  Write(Model.News.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                </div>\n                                <div class=\"d-flex\">\n                                    <img src=\"img/blog2/user-img.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1247, "\"", 1253, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n                    <p>");
#nullable restore
#line 28 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                  Write(Html.Raw(Model.News.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n                <div style=\"margin-top: 20px\" class=\"sharethis-inline-share-buttons\"></div>\n            </div>\n            <div class=\"col-lg-4\">\n                <div class=\"blog_right_sidebar\">\n");
#nullable restore
#line 34 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                     foreach (var item in Model.Authors)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <aside class=\"single_sidebar_widget author_widget\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c48440e58b3023e36f1138a5103864444969f7ab15441", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1874, "~/img/", 1874, 6, true);
#nullable restore
#line 37 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
AddHtmlAttributeValue("", 1880, item.Image, 1880, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c48440e58b3023e36f1138a5103864444969f7ab17110", async() => {
#nullable restore
#line 38 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                                                                                                    Write(item.NameSurname);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-author", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                                                                                  WriteLiteral(item.Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["author"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-author", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["author"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\n                    <p>");
#nullable restore
#line 39 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <div class=\"br\"></div>\n                </aside>");
#nullable restore
#line 41 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <aside class=\"single_sidebar_widget popular_post_widget\">\n                        <h3 class=\"widget_title\">İlgili Yazılar</h3>\n\n");
#nullable restore
#line 45 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                         foreach (var newses in (List<News>)ViewBag.NewsInfo)
                        {
                            if (newses.Url != Model.News.Url)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\" style=\"margin-bottom: 15px\">\n                    <div class=\"col-lg-4\" style=\"padding: 0px\">\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2645, "\"", 2669, 2);
            WriteAttributeValue("", 2651, "/img/", 2651, 5, true);
#nullable restore
#line 51 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
WriteAttributeValue("", 2656, newses.Image, 2656, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"post\">\n                    </div>\n                    <div class=\"col-lg-8\" style=\"padding: 0px 0px 0px 5px\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c48440e58b3023e36f1138a5103864444969f7ab21632", async() => {
                WriteLiteral("<h3 style=\"font-size:14px\">");
#nullable restore
#line 54 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                                                                                                                            Write(newses.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-url", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                                                                             WriteLiteral(newses.Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-url", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>");
#nullable restore
#line 56 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                      }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""br""></div>
                    </aside>
                    <aside class=""single_sidebar_widget"">
                        <h4 class=""widget_title"">E-Bülten Aboneliği</h4>
                        <div class=""form-group"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c48440e58b3023e36f1138a5103864444969f7ab24979", async() => {
                WriteLiteral(@"
                                <input class=""form-control"" name=""Name"" style=""width: 100%; margin-bottom: 20px; border-radius: 0px;"" type=""text"" placeholder=""Ad"">
                                <input class=""form-control"" name=""Surname"" style=""width: 100%; margin-bottom: 20px; border-radius: 0px;"" type=""text"" placeholder=""Soyad"">
                                <input class=""form-control"" name=""Email"" style=""width: 100%; margin-bottom: 20px; border-radius: 0px;"" type=""email"" placeholder=""Email"">
                                <button type=""submit"" style="" background: #140C40; color: white; padding: 10px 5px 10px 5px; width: 100%;"">ABONE OL</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n\n                    </aside>\n                    ");
#nullable restore
#line 72 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
               Write(await Component.InvokeAsync("NewsInCategories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                </div>\n            </div>\n        </div>\n    </div>\n</section>\n\n");
            WriteLiteral("\n<div id=\"back\" class=\"mb-2 text-center\">\n");
#nullable restore
#line 116 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
     if (ViewBag.Succes != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-primary\" role=\"alert\">\n    ");
#nullable restore
#line 119 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
Write(ViewBag.Succes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n                <h5 class=\"text-success\">");
#nullable restore
#line 121 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                                    Write(ViewBag.Succes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>");
#nullable restore
#line 121 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                                                             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
     if (ViewBag.Error != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h5 class=\"text-danger\">");
#nullable restore
#line 124 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                   Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>");
#nullable restore
#line 124 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
#nullable restore
#line 127 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Home\NewsDetails.cshtml"
Write(await Html.PartialAsync("_Footer"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591