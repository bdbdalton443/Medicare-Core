#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\ClientSideApi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55fda4d21a59f5b48dabd5b21ba1b8108220ef7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GridDemo_ClientSideApi), @"mvc.1.0.view", @"/Views/GridDemo/ClientSideApi.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55fda4d21a59f5b48dabd5b21ba1b8108220ef7a", @"/Views/GridDemo/ClientSideApi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_GridDemo_ClientSideApi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\ClientSideApi.cshtml"
  
    ViewBag.Title = "Grid Client Side API";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Grid client side API</h1>
<div class=""awe-il"">
    <textarea id=""vs"" cols=""70"" rows=""7"">
$('#ApiDemoGrid').data('api').load(
{
    group: ['Food', 'Location'],
    sort: [{ Prop: ""Date"", Sort: 2}],
    params:{}
});
// Sort 0 = none, 1 = asc, 2 = desc
    </textarea><br />
    <button type=""button"" id=""bApi"" class=""awe-btn"">Execute</button>
</div>

<ul id=""samples"" class=""samples awe-il"">
    <li>
        <button type=""button"" class=""awe-btn"">Refresh grid</button>
        <div class=""hidden"">$('#ApiDemoGrid').data('api').load();</div>
    </li>
    <li>
        <button type=""button"" class=""awe-btn"">Where Food contains Pie; Sort by Price</button>
        <div class=""hidden"">
$('#ApiDemoGrid').data('api').load({
group:[],
sort: [{ Prop: ""Price"", Sort: 1}],
params: { Food: 'pie' }
});
// Sort 0 = none, 1 = asc, 2 = desc
        </div>
    </li>
    <li>
        <button type=""button"" class=""awe-btn"">Group by Food, Location; Sort by Date Desc</button>
        <div class=""hidden""");
            WriteLiteral(@">
$('#ApiDemoGrid').data('api').load({
group: ['Food', 'Location'],
sort: [{ Prop: ""Date"", Sort: 2}],
params:{}
});
// Sort 0 = none, 1 = asc, 2 = desc
        </div>
    </li>
    <li>
        <button type=""button"" class=""awe-btn"">Sort Person Desc Price Asc</button>
        <div class=""hidden"">
$('#ApiDemoGrid').data('api').load({
group:[],
sort: [{ Prop: ""Person"", Sort: 2}, { Prop: ""Price"", Sort: 1}],
params:{}
});
        </div>
    </li>
    <li>
        <button type=""button"" class=""awe-btn"">go to page 3</button>
        <div class=""hidden"">
$('#ApiDemoGrid').data('api').load({ oparams:{ page: 3 } });
// oparams - one time params, sent only for this call,
// params will persist until api with params: {} is called
        </div>
    </li>
    <li>
        <button type=""button"" class=""awe-btn"">Reset grid</button>
        <div class=""hidden"">
$('#ApiDemoGrid').data('api').reset({ params:{} });
// reset will bring the grid back to the initial state defined in the markup
// sett");
            WriteLiteral(@"ing empty params, in case they were set before
        </div>
    </li>
</ul>
<br />
<br />
<script type=""text/javascript"">
    $(function () {
        $('#bApi').click(function () {
            eval($('#vs').val());
        });

        $('#samples .awe-btn').click(function () {
            $('#vs').val($(this).next().html());
            $('#bApi').click();
        });
        var grid = $('#ApiDemoGrid');

        grid.on('aweload awebeginload awerender', function (e, data, rd) {
            if ($(e.target).is(grid)) {
                $('#log').prepend(e.type + ' grid event at ' + site.getFormattedTime() + ' \n');
            }
        });
    });

    function setContent(o) {
        $('#ApiDemoGrid').data('api').clearpersist();
        $('#demoContent').html(o);
    }
</script>

<div id=""demoContent"">
");
            WriteLiteral("    ");
#nullable restore
#line 101 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\ClientSideApi.cshtml"
Write(Html.Awe().Grid("ApiDemoGrid")
          .Mod(o => o.PageInfo().PageSize())
          .Columns(
              new Column { Bind = "Id", Width = 55 },
              new Column { Bind = "Person" },
              new Column { Bind = "Food" },
              new Column { Bind = "Price", Width = 100 },
              new Column { Bind = "Date", Width = 130 },
              new Column { Bind = "Location" })
          .Height(350)
          .Url(Url.Action("GetItems", "LunchGrid")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"</div>
<br />
<div class=""tabs"">
    <div data-caption=""description"" class=""expl"">
        <p>
            Client side api is called by doing <code>$('#gridId').data('api') </code>and an api method
        </p>
        <ul>
            <li><code>.reset()</code> - will bring the grid back to the initial state defined in the markup</li>
            <li>
                <code>.load({group, sort, params})</code> - loads the grid with the specified grouping rules, sorting and additional parameters,
                if a property is omitted than the grid won't change it's state for that property;
                for example calling <code>.load({group: ['Food', 'Location']})</code> will change the grouping but won't affect the current sorting rules
            </li>
            <li><code>.clearpersist()</code> - clears the persistence data</li>
        </ul>
    </div>
    <div data-caption=""view"">");
#nullable restore
#line 130 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\ClientSideApi.cshtml"
                        Write(Html.Source("GridDemo/ClientSideApi.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div data-caption=\"controller\">");
#nullable restore
#line 131 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\ClientSideApi.cshtml"
                              Write(Html.Code("Awesome/Grid/LunchGridController.cs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>\r\n<h2>Events</h2>\r\n<textarea id=\"log\" rows=\"7\" style=\"width: 100%\"></textarea>");
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