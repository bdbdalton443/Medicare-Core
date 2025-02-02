#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\CustomPagerGridDemo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56c2a07774df22bea872bb3f0dca266ba54c988a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomPagerGridDemo_Index), @"mvc.1.0.view", @"/Views/CustomPagerGridDemo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56c2a07774df22bea872bb3f0dca266ba54c988a", @"/Views/CustomPagerGridDemo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomPagerGridDemo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\CustomPagerGridDemo\Index.cshtml"
  
    ViewBag.Title = "Grid with Custom Pager, pager at both top and bottom of the grid";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Grid custom pager demo</h2>\r\n");
            WriteLiteral("<div class=\"expl\">\r\n    using mods to change the pager<br />\r\n    you can see the first pager on the home page or grid demo (quick view) if you resize your browser screen to less than 1000px width\r\n</div>\r\n<br />\r\n");
#nullable restore
#line 11 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\CustomPagerGridDemo\Index.cshtml"
Write(Html.Awe().Grid("Grid")
    .Mod("awem.gridMiniPager")
    .Columns(
        new Column { Bind = "Id", Width = 75, Groupable = false },
        new Column { Bind = "Person" },
        new Column { Bind = "Food" },
        new Column { Bind = "Location" })
    .Url(Url.Action("GetItems", "LunchGrid"))
    .Height(300));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h3>Grid with pager at both top and bottom</h3>\r\n\r\n");
#nullable restore
#line 23 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\CustomPagerGridDemo\Index.cshtml"
Write(Html.Awe().Grid("Grid2")
    .Mod(o => o.PageInfo().PageSize().Custom("pagerBoth"))
    .Columns(
        new Column { Bind = "Id", Width = 75, Groupable = false },
        new Column { Bind = "Person" },
        new Column { Bind = "Food" },
        new Column { Bind = "Location" })
    .Url(Url.Action("GetItems", "LunchGrid")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>
    function pagerBoth(o) {
        var grid = o.v;
        var footer = grid.find('.awe-footer');
        var fclone = footer.clone(true);
        var psi = o.i + 'ps2';
        var pshtml = '<div class=""awe-ajaxradiolist-field o-gpgs awe-field""><input id=""' + psi +
            '"" class=""awe-val"" type=""hidden"" value=""' + o.ps +
            '"" /><div class=""awe-display""></div></div>';

        var dd = footer.find('.o-gpgs .awe-val');
        fclone.find('.o-gpgs').after(pshtml).remove();
        grid.prepend(fclone);
        
        // on small screen there's no pagesize selector
        if ($('#' + psi).length) {
            awe.radioList({ i: psi, nm: psi, l: 1, df: getdata, md: awem.odropdown, tag: { InLabel: awem.clientDict.PageSize + "": "" } });

            var dd2 = $('#' + psi);

            function getdata() {
                return dd.data('o').lrs;
            }

            dd.on('change', function() {
                dd2.val(dd.val()).data('api').render();");
            WriteLiteral(@"
            });

            dd2.on('change', function() {
                dd.val(dd2.val()).change();
            });
        }
        
        fclone.addClass('topFooter');
    }
</script>
<style>
    .awe-grid .awe-footer.topFooter {
        border-top: none;
        border-bottom: 1px solid gainsboro;
    }

    .black-cab .awe-footer.topFooter {
        border-bottom-color: #2B3443;
    }
</style>
");
#nullable restore
#line 79 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\CustomPagerGridDemo\Index.cshtml"
Write(Html.Source("CustomPagerGridDemo/Index.cshtml", wrap: true));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
