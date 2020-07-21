#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\AutocInTxta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dff41a20f954e42a8dd2dfbde98c2b1a2ae158f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Demos_AutocInTxta), @"mvc.1.0.view", @"/Views/Shared/Demos/AutocInTxta.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dff41a20f954e42a8dd2dfbde98c2b1a2ae158f", @"/Views/Shared/Demos/AutocInTxta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Demos_AutocInTxta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3 data-u=\"");
#nullable restore
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\AutocInTxta.cshtml"
       Write(Url.Action("Index", "Dropmenu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Autocomplete in textarea</h3>\r\n<div class=\"csettings\">\r\n    <label>Use ");
            WriteLiteral("@: ");
#nullable restore
#line 3 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\AutocInTxta.cshtml"
              Write(Html.Awe().CheckBox("chkUseAt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    <label>min len: ");
#nullable restore
#line 4 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\AutocInTxta.cshtml"
               Write(Html.Awe().TextBox("txtMinLen").Numeric(o => o.Min(1).Max(5)).Value(1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    <label>filter using starts with: ");
#nullable restore
#line 5 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\AutocInTxta.cshtml"
                                Write(Html.Awe().CheckBox("chkFstart"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n</div>\r\n");
            WriteLiteral(@"<textarea id=""text1"" style=""width: 100%"" placeholder=""try mango onion banana""></textarea>
<script>
        $(function () {
            var useAt = 0;
            var minLen = 1;
            var txt = $('#text1');
            var items = [];
            var word = '';
            var fstart;
            var dd;

            init();

            $.get('");
#nullable restore
#line 21 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\AutocInTxta.cshtml"
              Write(Url.Action("GetAllMeals", "Data"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', function (res) {
                items = res;
                dd.render();
            });

            function init() {
                if (dd) {
                    dd.destroy();
                }

                dd = awem.dropmenu({
                    df: getData,
                    opnlc: txt,
                    hpos: txt,
                    select: select,
                    clsempt: 1,
                    flts: fstart, // filter using startsWith
                    srctxt: txt,
                    gterm: getSrcTerm,
                    combo: 1
                });
            }

            function getSrcTerm() {
                // func in site.js
                word = site.getCaretWord(txt[0]);
                var res = -1;
                if (word.length >= minLen) {
                    if (useAt) {
                        if (word[0] == '");
            WriteLiteral(@"@') {
                            res = word.substr(1);
                        }
                    } else {
                        res = word;
                    }
                }

                return res;
            }

            function getData() {
                return items;
            }

            function select(item) {
                // func in site.js
                site.replaceInTexarea(txt[0], (useAt ?  '");
            WriteLiteral(@"@' : '') + item.c, word);
            }

            // settings
            $('#chkUseAt').change(function () {
                useAt = $(this).val() == 'true';
            });

            $('#txtMinLen').change(function () {
                minLen = Number($(this).val());
            });

            $('#chkFstart').change(function () {
                fstart = $(this).val() == 'true';
                init();
            });
        });
</script>
");
            WriteLiteral("<div class=\"code\">\r\n    ");
#nullable restore
#line 87 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\AutocInTxta.cshtml"
Write(Html.Source("Shared/Demos/AutocInTxta.cshtml"));

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