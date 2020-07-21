#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\ReorderCardsSplh.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d048957607cad027a925a52d4c37d34649314cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Demos_ReorderCardsSplh), @"mvc.1.0.view", @"/Views/Shared/Demos/ReorderCardsSplh.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d048957607cad027a925a52d4c37d34649314cd", @"/Views/Shared/Demos/ReorderCardsSplh.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Demos_ReorderCardsSplh : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2 data-u=\"");
#nullable restore
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\ReorderCardsSplh.cshtml"
       Write(Url.Action("Index","DragAndDropDemo"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">Sticky placeholder, drag reorder and drop while outside of the drop area </h2>
<div class=""expl"">
    Cards can be reordered using drag and drop, you can drag and drop the card while dragging outside and around of the drop area.<br />
    Used for the multiselect to reorder selected items.
</div>
");
            WriteLiteral(@"<script>
    $(function () {
        awem.dragReor({
            from: $('#board0'),
            to: 'body', // execute drop/hover over body
            sel: '.mcard',
            splh: 1, // sticky placeholder
            gcon: function (cx) {
                // get drop/hov container ( default was 'body' (to) )
                return $('#board0');
            }
        });
    });
</script>

<div class=""board"" id=""board0"">
    <div class=""mcard"">
        <div class=""big"">A</div>
    </div>
    <div class=""mcard"">
        <div class=""big"">B</div>
    </div>
    <div class=""mcard"">
        <div class=""big"">C</div>
    </div>

    <div class=""mcard"">
        <div class=""big"">X</div>
    </div>
    <div class=""mcard"">
        <div class=""big"">Y</div>
    </div>
    <div class=""mcard"">
        <div class=""big"">Z</div>
    </div>
</div>

<style>
    #board0 {
        max-width: 26em;
    }

    .mcard.o-plh {
        background: #f8da4e !important;
        color: #91560");
            WriteLiteral("8 !important;\r\n    }\r\n</style>\r\n");
            WriteLiteral("<div class=\"code\">\r\n    <div data-caption=\"view\">\r\n");
#nullable restore
#line 57 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\ReorderCardsSplh.cshtml"
Write(Html.Source("Shared/Demos/ReorderCardsSplh.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
