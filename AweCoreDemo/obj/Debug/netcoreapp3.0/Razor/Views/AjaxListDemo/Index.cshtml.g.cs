#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AjaxListDemo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36a58358ae8880cb1680ebbc33b2f0c781a39b6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AjaxListDemo_Index), @"mvc.1.0.view", @"/Views/AjaxListDemo/Index.cshtml")]
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
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\_ViewImports.cshtml"
using Omu.AwesomeMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\_ViewImports.cshtml"
using Omu.Awem.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\_ViewImports.cshtml"
using AweCoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\_ViewImports.cshtml"
using AweCoreDemo.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\_ViewImports.cshtml"
using AweCoreDemo.Helpers.Awesome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\_ViewImports.cshtml"
using AweCoreDemo.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36a58358ae8880cb1680ebbc33b2f0c781a39b6e", @"/Views/AjaxListDemo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_AjaxListDemo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AjaxListDemo\Index.cshtml"
  
    ViewBag.Title = "AjaxList Demo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AjaxList Demo</h1>\r\n<br />\r\n");
#nullable restore
#line 8 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AjaxListDemo\Index.cshtml"
Write(Html.Awe().TextBox("txtSearch").CssClass("searchtxt").Placeholder("search..."));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 11 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AjaxListDemo\Index.cshtml"
Write(Html.Awe().AjaxList("Meals")
            .Parent("txtSearch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<br />
<div class=""expl"">
    by default the AjaxList will try to get data from the Search action of a controller
    with same name as it + ""AjaxList"" but a different Url or controller can be specified
    using .Url or .Controller extensions
</div>
<br />

<div class=""tabs"">
    <div data-caption=""view"">");
#nullable restore
#line 23 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AjaxListDemo\Index.cshtml"
                        Write(Html.Source("AjaxListDemo/Index.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div data-caption=\"controller\">");
#nullable restore
#line 24 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AjaxListDemo\Index.cshtml"
                              Write(Html.Csource("Awesome/AjaxList/MealsAjaxListController.cs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>");
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