#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TextBoxDemo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f42ca8360e23d32700ba49cb32b7379b28595972"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TextBoxDemo_Index), @"mvc.1.0.view", @"/Views/TextBoxDemo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f42ca8360e23d32700ba49cb32b7379b28595972", @"/Views/TextBoxDemo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_TextBoxDemo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AweCoreDemo.ViewModels.Input.TextBoxDemoInput>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TextBoxDemo\Index.cshtml"
  
    ViewBag.Title = "TextBox helper, with numeric and custom format extensions";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>TextBox</h1>\r\n<br />\r\n<div style=\"margin-left: 2em;\">\r\n");
            WriteLiteral("    Simple textbox:<br />\r\n    ");
#nullable restore
#line 11 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TextBoxDemo\Index.cshtml"
Write(Html.Awe().TextBoxFor(o => o.Name).Numeric(o => o.AllowNegative())
          .Placeholder("type here..."));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <br />\r\n    Numeric textbox:<br />\r\n    ");
#nullable restore
#line 16 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TextBoxDemo\Index.cshtml"
Write(Html.Awe().TextBox("Numeric").Numeric().Value(123));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n     <br />\r\n    <br />   \r\n        Numeric with decimals:<br />\r\n    ");
#nullable restore
#line 20 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TextBoxDemo\Index.cshtml"
Write(Html.Awe().TextBox("NumericDec").Numeric(o => o.Decimals()).Value(1.2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <br />\r\n    <br />\r\n\r\n    Decimals and custom format:<br />\r\n    ");
#nullable restore
#line 26 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TextBoxDemo\Index.cshtml"
Write(Html.Awe().TextBoxFor(o => o.Number)
          .Value(11.23)
          .FormatFunc("utils.postfix('GBP')")
          .Numeric(o => o.Decimals(2).Step(0.01)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <br />\r\n\r\n    ");
#nullable restore
#line 33 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TextBoxDemo\Index.cshtml"
Write(Html.Awe().TextBox("Percent")
                  .Value(0.1)
                  .FormatFunc("utils.percent")
                  .Numeric(o => o.Decimals(2).Step(0.01).Max(1)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <br />\r\n\r\n    ");
#nullable restore
#line 40 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TextBoxDemo\Index.cshtml"
Write(Html.Awe().TextBox("PriceUSD")
          .Value(20)
          .FormatFunc("utils.prefix('$')")
          .Numeric(o => o.Decimals(2)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <br />\r\n\r\n    Simple with custom format:<br />\r\n    ");
#nullable restore
#line 48 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TextBoxDemo\Index.cshtml"
Write(Html.Awe().TextBox("Exp")
          .Value("the actual value")
          .FormatFunc("secret"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br/>\r\n    <br/>\r\n    Duration:<br/>\r\n    ");
#nullable restore
#line 54 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TextBoxDemo\Index.cshtml"
Write(Html.Awe().TextBox("Duration")
        .Numeric(o => o.Step(10))
        .Value(90)
        .FormatFunc("duration('hour', 'hours', 'min')"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br/>\r\n    <br/>\r\n    Disabled:<br />\r\n    ");
#nullable restore
#line 61 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TextBoxDemo\Index.cshtml"
Write(Html.Awe().TextBox("disbl")
        .Enabled(false)
        .Value("123"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <script>
        function secret(val) {
            return ""secret"";
        }
        
        function duration(hourw, hoursw, minw) {
            return function (val) {
                var mval = parseInt(val, 10);
                if (isNaN(mval)) return val;
                var hour = Math.floor(mval / 60);
                var minute = mval % 60;
                var res = """";
                if (hour > 0) {
                    res += hour + "" "" + (hour > 1 ? hoursw : hourw);
                }
                if (minute > 0) {
                    res += "" "" + minute + "" "" + minw;
                }
                return res;
            };
        };
    </script>
");
            WriteLiteral("</div>\r\n\r\n<br/>\r\n");
#nullable restore
#line 91 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TextBoxDemo\Index.cshtml"
Write(Html.Source("TextBoxDemo/Index.cshtml"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AweCoreDemo.ViewModels.Input.TextBoxDemoInput> Html { get; private set; }
    }
}
#pragma warning restore 1591
