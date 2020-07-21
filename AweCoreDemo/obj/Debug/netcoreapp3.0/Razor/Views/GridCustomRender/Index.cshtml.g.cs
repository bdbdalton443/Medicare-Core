#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCustomRender\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcec46ba1043f3490e34cd02a5f6bfabf2dc9727"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GridCustomRender_Index), @"mvc.1.0.view", @"/Views/GridCustomRender/Index.cshtml")]
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
#nullable restore
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCustomRender\Index.cshtml"
using AweCoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcec46ba1043f3490e34cd02a5f6bfabf2dc9727", @"/Views/GridCustomRender/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_GridCustomRender_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCustomRender\Index.cshtml"
  
    ViewBag.Title = "Grid custom render, cards view";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n    // used in inline crud\r\n    var meals = ");
#nullable restore
#line 7 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCustomRender\Index.cshtml"
           Write(Html.Raw(DemoUtils.Encode(Db.Meals.Select(o => new KeyContent(o.Id, o.Name)))));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</script>\r\n\r\n<h1>Grid custom rendering</h1>\r\n<div class=\"expl\">Custom rendering achieved using mods that override grid api methods</div>\r\n\r\n<div class=\"example\">\r\n    ");
#nullable restore
#line 14 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCustomRender\Index.cshtml"
Write(await Html.PartialAsync("Demos/GridCardsView"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"example\">\r\n    ");
#nullable restore
#line 18 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCustomRender\Index.cshtml"
Write(await Html.PartialAsync("Demos/GridInlineCrudCustomRender"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"example\">\r\n   ");
#nullable restore
#line 22 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCustomRender\Index.cshtml"
Write(await Html.PartialAsync("Demos/TreeGridCustomRender"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"example\">\r\n");
            WriteLiteral("    <h2> Tree grid nested cards </h2>\r\n    ");
#nullable restore
#line 28 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCustomRender\Index.cshtml"
Write(Html.Awe().Grid("LazyTreeGridCr")
          .Url(Url.Action("LazyTree", "TreeGrid"))
          .Mod(o => o.CustomRender("cardstree"))
          .Columns(
              new Column {Bind = "Name"},
              new Column {Bind = "Id", Width = 100})
          .Persistence(Persistence.View)
          .ColumnsPersistence(Persistence.Session)
          .PageSize(3)
          .Height(500));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <script>
        function cardstree(o) {
            var api = o.api;
            var fcol = utils.colf(o.columns).fcol;

            // node
            api.nodef = function(p) {
                // don't wrap nodetype = items
                if (p.gv.nt == 2) return p.ren();
                var attr = p.h ? 'style=""display:none;""' : ''; // collapsed
                var res = '<div class=""gwrap"" ' + attr + '>' + p.ren() + '</div>';
                return res;
            };

            // group header content
            api.ghead = function(g) {
                return api.ceb() + g.c;
            };

            // render row
            api.itmf = function(opt) {
                function val(col) {
                    return utils.gcv(api, col, opt);
                }

                var content = '';
                if (opt.con) {
                    content = opt.con;
                } else {
                    if (opt.ceb) content += api.ceb();
                    c");
            WriteLiteral(@"ontent += val(fcol('Name'));
                }

                if (opt.ceb) {
                    opt.clss += ' cardhead awe-ceb';
                } else {
                    opt.clss += ' itcard';
                }

                var attr = opt.attr;
                attr += ' class=""' + opt.clss + '""';
                opt.style && (attr += ' style=""' + opt.style + '""');

                return '<div ' + attr + '>' + content + '</div>';
            };

            // ignore columns width for content
            o.syncon = 0;
        }
    </script>
");
            WriteLiteral(@"    <br/>
    <br/>
    <div class=""tabs"">
        <div data-caption=""description"" class=""expl"">
            Rendering the grid nodes as cards and placing the child nodes inside the parent card. The grid is also using lazy loading.
        </div>
        <div data-caption=""view"">");
#nullable restore
#line 95 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCustomRender\Index.cshtml"
                            Write(Html.Source("GridCustomRender/Index.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>");
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
