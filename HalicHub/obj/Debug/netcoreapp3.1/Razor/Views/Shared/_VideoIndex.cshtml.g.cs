#pragma checksum "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Shared\_VideoIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08c49e0ee72f144c8b01ea901dddd84613e4ee05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__VideoIndex), @"mvc.1.0.view", @"/Views/Shared/_VideoIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c49e0ee72f144c8b01ea901dddd84613e4ee05", @"/Views/Shared/_VideoIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d447f06f600cad35a08585f36a3d6ae0aa3e3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__VideoIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Video>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"item\">\r\n    <div class=\"shadow-effect\">\r\n        <div class=\"portfolio__item\">\r\n            <div style=\"border-radius: 15px\" class=\"portfolio__item__video set-bg video-sz\" data-setbg=\"/img/");
#nullable restore
#line 6 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Shared\_VideoIndex.cshtml"
                                                                                                        Write(Model.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                <button type=\"button\" class=\"video-btn play-btn\" data-toggle=\"modal\" data-src=\"https://www.youtube.com/embed/");
#nullable restore
#line 7 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Shared\_VideoIndex.cshtml"
                                                                                                                        Write(Model.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-target=\"#myModal\">\r\n                    <i class=\"fa fa-play\"></i>\r\n                </button>\r\n            </div>\r\n            <div class=\"portfolio__item__text\">\r\n                <h4>");
#nullable restore
#line 12 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Shared\_VideoIndex.cshtml"
               Write(Model.Tittle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <span>");
#nullable restore
#line 13 "C:\Users\muhammetkaya\Desktop\hubrolok-main\HalicHub\Views\Shared\_VideoIndex.cshtml"
                 Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Video> Html { get; private set; }
    }
}
#pragma warning restore 1591
