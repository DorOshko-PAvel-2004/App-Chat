#pragma checksum "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Areas\Identity\Pages\Account\Logout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "241688ba6e50ccba9b7adadac7c8ab48ae7c006c7bf9eec7bdb6109741cde737"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Identity_Pages_Account_Logout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
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
#line 1 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line 2 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using SocialNetwork.Web.Areas.Identity

#nullable disable
    ;
#nullable restore
#line 3 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using SocialNetwork.Web.Areas.Identity.Pages

#nullable disable
    ;
#nullable restore
#line 1 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using SocialNetwork.Web.Areas.Identity.Pages.Account

#nullable disable
    ;
#nullable restore
#line 2 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using SocialNetwork.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"241688ba6e50ccba9b7adadac7c8ab48ae7c006c7bf9eec7bdb6109741cde737", @"/Areas/Identity/Pages/Account/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"834a183f5c4e1ad5929eec90725e052ae7e4bb43015a07081d8deb8318401045", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cb927341568dbaf28adafc5110ac629d9150b8010d250c656df02788ca06aa57", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Areas_Identity_Pages_Account_Logout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Areas\Identity\Pages\Account\Logout.cshtml"
  
    ViewData["Title"] = "Log out";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<header>\r\n    <h1>");
            Write(
#nullable restore
#line 8 "D:\coursovoi\Connectiverse\SocialNetwork\SocialNetwork.Web\Areas\Identity\Pages\Account\Logout.cshtml"
         ViewData["Title"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\r\n    <p>You have successfully logged out of the application.</p>\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LogoutModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel>)PageContext?.ViewData;
        public LogoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
