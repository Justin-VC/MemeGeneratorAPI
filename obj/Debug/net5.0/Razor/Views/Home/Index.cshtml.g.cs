#pragma checksum "F:\2021\PROG\MemeGenerator\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9358ddfacf5d485dcc7f4c6267f6aaadecd4fed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "F:\2021\PROG\MemeGenerator\Views\_ViewImports.cshtml"
using MemeGenerator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\2021\PROG\MemeGenerator\Views\_ViewImports.cshtml"
using MemeGenerator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9358ddfacf5d485dcc7f4c6267f6aaadecd4fed", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bdd28fe52b8efe6ca8bcf6b1881c30d9cc5bcd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\2021\PROG\MemeGenerator\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>


    <a href=""/MemeController/GetMemes"" class=""Button"">Get Memes</a>
    ");
#nullable restore
#line 11 "F:\2021\PROG\MemeGenerator\Views\Home\Index.cshtml"
Write(Html.ActionLink("Button name", "GetMemes", "Meme"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\nViews\\Memes\\GetMemes.cshtml");
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
