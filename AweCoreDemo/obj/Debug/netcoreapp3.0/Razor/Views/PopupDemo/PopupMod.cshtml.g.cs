#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupDemo\PopupMod.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dc003dc3febdebd3aa48eb3ac505571cbb73b25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PopupDemo_PopupMod), @"mvc.1.0.view", @"/Views/PopupDemo/PopupMod.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dc003dc3febdebd3aa48eb3ac505571cbb73b25", @"/Views/PopupDemo/PopupMod.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_PopupDemo_PopupMod : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupDemo\PopupMod.cshtml"
  
    ViewBag.Title = "Popup Mod";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Popup Mod</h2>
<p class=""expl"">
    default popup can be replaced by setting <code>awe.popup</code>
</p>
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css"">
<link rel=""stylesheet"" href=""https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"">

<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.1/js/bootstrap.min.js""></script>
<script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.min.js""></script>


<link");
            BeginWriteAttribute("href", " href=\"", 530, "\"", 578, 1);
#nullable restore
#line 16 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupDemo\PopupMod.cshtml"
WriteAttributeValue("", 537, Url.Content(Autil.CssDir() + "site.css"), 537, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" rel=""stylesheet"" type=""text/css"" />

<script>
    function setPopup(p) {
        awe.popup = function (o) {
            if (o.tag && o.tag.DropdownPopup) {
                return awem.dropdownPopup(o);
            } else if (o.tag && o.tag.Inline) {
                return awem.inlinePopup(o);
            } else {
                return p(o);
            }
        }

        // close popups that were already opened with a different kind of popup
        $('.awe-popup').each(function () {
            if ($(this).data('api'))
                $(this).data('api').destroy();
        });

        $('.awe-multilookup, .awe-lookup').each(function () { $(this).data('api').initPopup(); });

        awe.flash($('#testArea'));
    }

    $(function () {
");
            WriteLiteral("        $.getScript(\'");
#nullable restore
#line 43 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupDemo\PopupMod.cshtml"
                Write(Url.Content(Autil.JsDir() + "awem.extras.js"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');

        $('#btnBoot').click(function () {
            setPopup(awemex.bootstrapPopup);
        });

        $('#btnAwe').click(function () {
            setPopup(awem.dropdownPopup);
        });

        $('#btnInline').click(function () {
            setPopup(awem.inlinePopup);
        });

        $('#btnUi').click(function () {
            setPopup(awemex.uiPopup);
        });
    });
</script>

<button type=""button"" id=""btnAwe"" class=""awe-btn"">set awesome popup</button>
<button type=""button"" id=""btnBoot"" class=""awe-btn"">set bootstrap popup</button>
<button type=""button"" id=""btnInline"" class=""awe-btn"">set inline popup</button>
<button type=""button"" id=""btnUi"" class=""awe-btn"">set jQueryUI popup</button>

");
#nullable restore
#line 68 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupDemo\PopupMod.cshtml"
Write(Html.Awe().InitPopup()
      .Name("popup1")
      .Url(Url.Action("Popup1"))
      .LoadOnce()
      .Title("popup title")
      .Width(500)
      .Height(450));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br/>\r\n<br/>\r\n<br/>\r\n<div id=\"testArea\" style=\"padding: 1em 0;\">\r\n    ");
#nullable restore
#line 79 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupDemo\PopupMod.cshtml"
Write(Html.Awe().Button().Text("Open Popup").OnClick(Html.Awe().OpenPopup("popup1")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"tabs code\">\r\n    <div data-caption=\"view\">");
#nullable restore
#line 83 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupDemo\PopupMod.cshtml"
                        Write(Html.Source("PopupDemo/PopupMod.cshtml"));

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
