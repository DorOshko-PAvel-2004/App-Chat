#pragma checksum "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Views\Shared\Components\Newsbar\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b48c88da47a7c7b43cb0b8d03ff337c633560ce44c0700ecbaf8d9f094634df3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Shared_Components_Newsbar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Newsbar/Default.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Views\_ViewImports.cshtml"
using SocialNetwork.Web

#nullable disable
    ;
#nullable restore
#line 2 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Views\_ViewImports.cshtml"
using SocialNetwork.Web.Models

#nullable disable
    ;
#nullable restore
#line 3 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Views\_ViewImports.cshtml"
using SocialNetwork.Models

#nullable disable
    ;
#nullable restore
#line 4 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line 5 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Views\_ViewImports.cshtml"
using SocialNetwork.Models.Common.Enums

#nullable disable
    ;
#nullable restore
#line 6 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Views\_ViewImports.cshtml"
using NewsAPI.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b48c88da47a7c7b43cb0b8d03ff337c633560ce44c0700ecbaf8d9f094634df3", @"/Views/Shared/Components/Newsbar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4a7521fece150bcab84de1202dd7a1dd21df9f0970180bea22470afecec73557", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Shared_Components_Newsbar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Views\Shared\Components\Newsbar\Default.cshtml"
       ArticlesResult

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<style>\r\n    .newsbar:hover, nav.newsbar.expanded {\r\n        width: 480px;  ");
            WriteLiteral("\r\n        overflow: visible;\r\n        background: rgba(0, 0, 0, 0.9);\r\n    }\r\n\r\n    .newsbar {\r\n");
            WriteLiteral(@"        background: rgba(0, 0, 0, 0);
        position: absolute;
        top: 0;
        bottom: 0;
        height: 100%;
        left: 0;
        width: 40px;
        overflow: hidden;
        transition: width .05s;
        z-index: 1000;
    }

        .newsbar li {
            position: relative;
            display: block;
            width: 450px; ");
            WriteLiteral(@"
        }

            .newsbar li > a {
                position: relative;
                display: table;
                border-collapse: collapse;
                border-spacing: 0;
                color: #999;
                font-family: arial;
                font-size: 14px;
                text-decoration: none;
                transition: all .1s;
            }

        .newsbar .nav-icon {
            position: relative;
            display: table-cell;
            width: 60px;
            height: 36px;
            text-align: center;
            vertical-align: middle;
            font-size: 18px;
        }

        .newsbar .nav-text {
            position: relative;
            display: table-cell;
            vertical-align: middle;
        }

        .newsbar > ul.logout {
            position: absolute;
            left: 0;
            bottom: 30px;
        }

    a:hover, a:focus {
        text-decoration: none;
    }

        nav ul, nav li {
    ");
            WriteLiteral(@"        outline: 0;
            margin: 0;
            padding: 0;
        }

        .newsbar li:hover > a, nav.newsbar li.active > a, .dropdown-menu > li > a:hover, .dropdown-menu > li > a:focus, .dropdown-menu > .active > a, .dropdown-menu > .active > a:hover, .dropdown-menu > .active > a:focus, .no-touch .dashboard-page nav.dashboard-menu ul li:hover a, .dashboard-page nav.dashboard-menu ul li.active a {
            color: #fff;
            background-color: #5fa2db;
        }

    .news-card {
        margin: 0px 0px 0px 50px !important;
        background-color: rgba(255, 255, 255, 0.2) !important;
        transition: width 5s;
        border-radius: 8px;
    }

        .news-card :hover {
            background-color: #5fa2db;
        }
</style>

<nav class=""newsbar"">
    <ul>

");
#nullable restore
#line 94 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Views\Shared\Components\Newsbar\Default.cshtml"
         for (int i = 0; i < 3; i++)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <li>\r\n                <i class=\"fa fa-2x\"></i>\r\n                <div class=\"card news-card\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title text-white\">");
            Write(
#nullable restore
#line 100 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Views\Shared\Components\Newsbar\Default.cshtml"
                                                           Model.Articles[i].Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n                        <h6 class=\"card-subtitle mb-2\" style=\"color: lightgray\">");
            Write(
#nullable restore
#line 101 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Views\Shared\Components\Newsbar\Default.cshtml"
                                                                                 Model.Articles[i].Author

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h6>\r\n                        <p class=\"text-white\" style=\"font-size: 15px\">");
            Write(
#nullable restore
#line 102 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Views\Shared\Components\Newsbar\Default.cshtml"
                                                                       Model.Articles[i].Content

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                        <a class=\"card-link\" style=\"color: dodgerblue\">");
            Write(
#nullable restore
#line 103 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Views\Shared\Components\Newsbar\Default.cshtml"
                                                                        Model.Articles[i].PublishedAt

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3114, "\"", 3143, 1);
            WriteAttributeValue("", 3121, 
#nullable restore
#line 104 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Views\Shared\Components\Newsbar\Default.cshtml"
                                  Model.Articles[i].Url

#line default
#line hidden
#nullable disable
            , 3121, 22, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-link\" style=\"color: dodgerblue\">Read All</a>\r\n                    </div>\r\n                </div>\r\n            </li>\r\n");
#nullable restore
#line 108 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Views\Shared\Components\Newsbar\Default.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n    </ul>\r\n\r\n    <ul class=\"logout\">\r\n        <li>\r\n            <a href=\"#\">\r\n");
            WriteLiteral("                <span class=\"nav-text\">\r\n");
            WriteLiteral("                </span> &nbsp;&nbsp;&nbsp;<i class=\"fa fa-angle-double-right fa-3x\"></i>\r\n            </a>\r\n        </li>\r\n    </ul>\r\n</nav>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArticlesResult> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
