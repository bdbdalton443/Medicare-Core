#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\_FieldLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6657af8b15e000ee9d0a6075a4f69e7815d0d30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FieldLayout), @"mvc.1.0.view", @"/Views/Shared/_FieldLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6657af8b15e000ee9d0a6075a4f69e7815d0d30", @"/Views/Shared/_FieldLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FieldLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"efield\">\r\n    <div class=\"elabel\">\r\n        ");
#nullable restore
#line 3 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\_FieldLayout.cshtml"
   Write(Html.Label("", null, new {@for = Html.ViewContext.HttpContext.Items[Settings.ContextKey] + ViewData.TemplateInfo.GetFullHtmlFieldName(string.Empty) + ViewData["__idpostfix"]}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"einput\">\r\n        ");
#nullable restore
#line 6 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\_FieldLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    ");
#nullable restore
#line 8 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\_FieldLayout.cshtml"
Write(Html.ValidationMessage(""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
