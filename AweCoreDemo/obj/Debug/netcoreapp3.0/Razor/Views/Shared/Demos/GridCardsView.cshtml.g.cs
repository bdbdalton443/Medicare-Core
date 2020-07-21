#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\GridCardsView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b6ad02fb9002b574c361148c8c79993b21a66b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Demos_GridCardsView), @"mvc.1.0.view", @"/Views/Shared/Demos/GridCardsView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b6ad02fb9002b574c361148c8c79993b21a66b5", @"/Views/Shared/Demos/GridCardsView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Demos_GridCardsView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2 data-u=\"");
#nullable restore
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\GridCardsView.cshtml"
       Write(Url.Action("Index","GridCustomRender"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Grid Cards View</h2>\r\n");
#nullable restore
#line 3 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\GridCardsView.cshtml"
Write(Html.Awe().Grid("GridCardsView")
      .CssClass("scrlh") // scrollbar for grid header when needed
      .Reorderable()
      .Mod(o => o.PageInfo().PageSize().AutoMiniPager().ColumnsSelector().CustomRender("cardsview"))
      .Columns(
          new Column { Bind = "Id", Width = 75, Groupable = false, Resizable = false },
          new Column { Bind = "Person" }.Mod(o => o.Nohide()),
          new Column { Bind = "Food" },
          new Column { Bind = "Location" },
          new Column { Bind = "Date", Width = 120 }.Mod(o => o.Autohide()),
          new Column { Bind = "Country.Name", ClientFormat = ".(CountryName)", Header = "Country" },
          new Column { Bind = "Chef.FirstName,Chef.LastName", ClientFormat = ".(ChefName)", Header = "Chef" })
      .Url(Url.Action("GetItems", "LunchGrid"))
      .Resizable()
      .Height(450));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    function cardsview(o) {
        var api = o.api;

        // node content add wrap for padding
        api.ncon = function(p) {
            if (!p.lvl) return p.ren();
            return '<div style=""padding-left:' + p.lvl + 'em;"" >' + p.ren() + '</div>';
        };

        // group header content
        api.ghead = function(g) {
            return api.ceb() + g.c;
        };

        // render item
        api.itmf = function (opt) {
            var columns = o.columns;

            var content = '';
            if (opt.con) {
                content = opt.con;
            } else {
                for (var i = 0; i < columns.length; i++) {
                    var col = columns[i];
                    
                    // is column hidden
                    if (api.ich(col)) continue;
                    content += '<div class=""elabel"">'+ (col.H ? col.H +': ' : '') + '</div>' + utils.gcvw(api, col, opt) + '</br>';
                }
            }

          ");
            WriteLiteral(@"  if (opt.ceb) {
                opt.clss += ' cardhead';
                opt.style += 'margin-left:' + opt.ind + 'em;';
            } else {
                opt.clss += ' itcard';
            }

            var attr = opt.attr;
            attr += ' class=""' + opt.clss + '""';
            opt.style && (attr += ' style=""'+opt.style+'""');

            return '<div ' + attr + '>' + content + '</div>';
        };

        // ignore columns width for grid content
        o.syncon = 0;

        // no alt rows
        o.alt = 0;
    }
</script>
");
            WriteLiteral(@"<br/>
<br/>
<div class=""tabs"">
    <div data-caption=""description"" class=""expl"">
        Grid cards view achieved by overriding api methods, columns can be reordered, hidden/shown, and the changes will be reflected in the rendered card. 
        The column headers width is ignored for calculating grid content width, so when you shrink the browser window the grid content won't get a horizontal scrollbar.
        On touch you can scroll the grid header horizontally by dragging from the left an right sides of the grid header.
    </div>
    <div data-caption=""view"">");
#nullable restore
#line 80 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\GridCardsView.cshtml"
                        Write(Html.Source("Shared/Demos/GridCardsView.cshtml"));

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