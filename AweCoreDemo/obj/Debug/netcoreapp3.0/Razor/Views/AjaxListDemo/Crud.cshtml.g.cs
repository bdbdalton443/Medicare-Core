#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AjaxListDemo\Crud.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70214ab8cdd02d8fc87c0ae45423a99cd96c6065"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AjaxListDemo_Crud), @"mvc.1.0.view", @"/Views/AjaxListDemo/Crud.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70214ab8cdd02d8fc87c0ae45423a99cd96c6065", @"/Views/AjaxListDemo/Crud.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_AjaxListDemo_Crud : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AjaxListDemo\Crud.cshtml"
  
    ViewBag.Title = "AjaxList CRUD Demo using PopupForm";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>AjaxList CRUD demo</h1>\r\n");
#nullable restore
#line 6 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AjaxListDemo\Crud.cshtml"
  
    var ajl = "DinnersList1";

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AjaxListDemo\Crud.cshtml"
Write(Html.InitCrudPopupsForAjaxList(ajl, "AjaxListCrud", "Dinner"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"bar\">\r\n    <div style=\"float: right;\">\r\n        ");
#nullable restore
#line 13 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AjaxListDemo\Crud.cshtml"
   Write(Html.Awe().TextBox("txtName").Placeholder("search...").CssClass("searchtxt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <button type=\"button\" class=\"awe-btn mbtn\" onclick=\"awe.open(\'createDinner\')\">Create</button>\r\n</div>\r\n\r\n");
#nullable restore
#line 19 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AjaxListDemo\Crud.cshtml"
Write(Html.Awe().AjaxList(ajl)
    .Url(Url.Action("GetDinners", "AjaxListCrud"))
    .TableLayout(true)
    .Parent("txtName", "search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<br />\r\n\r\n<div class=\"tabs\">\r\n    <div data-caption=\"view\">");
#nullable restore
#line 27 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AjaxListDemo\Crud.cshtml"
                        Write(Html.Source("AjaxListDemo/Crud.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div data-caption=\"controller\">");
#nullable restore
#line 28 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AjaxListDemo\Crud.cshtml"
                              Write(Html.Csource("Demos/AjaxList/AjaxListCrudController.cs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div data-caption=\"Dinner list item view\">");
#nullable restore
#line 29 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AjaxListDemo\Crud.cshtml"
                                         Write(Html.Source("Shared/ListItems/Dinner.cshtml"));

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