#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26044ffdfe89c9cbd2339247e98016b8eee38735"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GridClientDataDemo_Index), @"mvc.1.0.view", @"/Views/GridClientDataDemo/Index.cshtml")]
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
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml"
using AweCoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26044ffdfe89c9cbd2339247e98016b8eee38735", @"/Views/GridClientDataDemo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_GridClientDataDemo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml"
  
    ViewBag.Title = "Grid Client Data Loading";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Grid Client Data Demo</h2>\r\n");
            WriteLiteral("<div class=\"bar\">\r\n    ");
#nullable restore
#line 9 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml"
Write(Html.Awe().TextBox("txtsearch").Placeholder("search ...").CssClass("searchtxt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <span class=\"hint\">&nbsp; you can search multiple columns at the same time (try \'pizza tavern\')</span>\r\n</div>\r\n\r\n");
#nullable restore
#line 13 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml"
Write(Html.Awe().Grid("GridClientData")
      .DataFunc("getGridData")
      .Height(350)
      .Mod(o => o.PageInfo().PageSize().ColumnsSelector())
      .Persistence(Persistence.View)
      .Resizable()
      .Reorderable()
      .Parent("txtsearch", "search", false)
      .Columns(
          new Column { Bind = "Id", Width = 75, Groupable = false, Resizable = false },
          new Column { Bind = "Person" },
          new Column { Bind = "Food" },
          new Column { Bind = "Location" },
          new Column { Bind = "Date", Width = 120 },
          new Column { Bind = "CountryName", Header = "Country" },
          new Column { Bind = "ChefName", Header = "Chef" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    // client data source\r\n    var lunches = ");
#nullable restore
#line 31 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml"
             Write(Html.Raw(DemoUtils.Encode(Db.Lunches.Take(300).Select(o => new
             {
                 o.Id,
                 o.Person,
                 o.Food,
                 o.Location,
                 o.Price,
                 CountryName = o.Country.Name,
                 ChefName = o.Chef.FirstName + " " + o.Chef.LastName,
                 o.Date,
                 DateStr = o.Date.ToShortDateString()
             }))));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    function getGridData(sgp) {
        var where = aweq.where, contains = aweq.contains, loop = awef.loop;
        var gp = utils.getGridParams(sgp);
            var list = lunches;

            // eval search
            if (gp.search) {
                var words = gp.search.toLowerCase().split("" "");

                list = where(list, function (o) {
                    var matches = 0;
                    loop(words, function (w) {
                        if (contains(o.Food, w) || contains(o.Person, w) || contains(o.Location, w) || contains(o.CountryName, w)
                            || contains(o.DateStr, w)
                            || contains(o.ChefName, w)) matches++;
                    });

                    return matches === words.length;
                });
            }

        function map(o) { return { Id: o.Id, Person: o.Person, Food: o.Food, Location: o.Location,
            Date: o.DateStr, CountryName: o.CountryName, ChefName: o.ChefName }; };


      ");
            WriteLiteral(@"  return utils.gridModelBuilder(
            {
                key:""Id"",
                gp: gp,
                items: list,
                map:map,
                // replace default group header value for Date
                getHeaderVal:{ Date: function(o){ return o.DateStr; } }
            });
    }

    $(function() {
        $('#txtsearch').keyup(function() {
            $('#GridClientData').data('api').load();
        });
    });
</script>
");
            WriteLiteral(@"<br />
<div class=""tabs"">
    <div class=""expl"" data-caption=""description"">
        Instead of setting <code>.Url(url)</code> to get data, the <code>.DataFunc(jsfunc)</code> extension is used.
        The js func can return the grid model or a promise,
        for example the function could do an ajax request and return the jqXHR object returned by <code>$.get</code>,
        so when the ajax request is complete the ajax success function can return the grid model (used in the Hybrid demo below).
    </div>
    <div data-caption=""view"">");
#nullable restore
#line 95 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml"
                        Write(Html.Source("GridClientDataDemo/Index.cshtml", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>\r\n<br />\r\n<br />\r\n\r\n");
            WriteLiteral("<h2>Tree Grid Client Data Demo</h2>\r\n<div class=\"bar\">\r\n    ");
#nullable restore
#line 103 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml"
Write(Html.Awe().TextBox("txtsearch2").Placeholder("search ...").CssClass("searchtxt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 105 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml"
Write(Html.Awe().Grid("TreeGrid1")
            .DataFunc("treeGridData")
            .Parent("txtsearch2", "search", false)
            .Columns(
                new Column { Bind = "Name" },
                new Column { Bind = "Id", Width = 100 })
            .Persistence(Persistence.View)
            .Groupable(false)
            .PageSize(3)
            .Height(400));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    var treeNodes = ");
#nullable restore
#line 116 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml"
               Write(Html.Raw(DemoUtils.Encode(Db.TreeNodes.Select(o => new { o.Id, o.Name, ParentId = o.Parent != null ? o.Parent.Id : 0 }))));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    function treeGridData(sgp) {
        var gp = utils.getGridParams(sgp);

        var words = gp.search.split("" "");

        var regs = $.map(words, function(w) {
            return new RegExp(w, ""i"");
        });

        var regsl = regs.length;

        var result = $.grep(treeNodes, function(o) {
            var matches = 0;
            $.each(regs, function(_, reg) {
                reg.test(o.Name) && matches ++;
            });

            return regsl == matches;
        });

        var searchResult = result.slice(0);

        awef.loop(searchResult, function (o) {
            addParentsTo(result, o, treeNodes);
        });

        var rootNodes = $.grep(result, function (o) { return !o.ParentId; });

        var getChildren = function (node, nodeLevel) {
            return $.grep(result, function (o) { return o.ParentId == node.Id; });
        };

        return utils.gridModelBuilder(
            {
                gp: gp,
                items: rootNodes");
            WriteLiteral(@",
                key: ""Id"",
                getChildren: getChildren
            });
    }

    function addParentsTo(result, node, all) {
        if (node.ParentId) {
            var isFound;
            awef.loop(result, function (o) {
                if (o.Id == node.ParentId) {
                    isFound = true;
                    return false;
                }
            });

            if (!isFound) {
                var parent = $.grep(all, function(o) { return o.Id == node.ParentId; })[0];
                result.push(parent);
                addParentsTo(result, parent, all);
            }
        }
    }

    $(function() {
        $('#txtsearch2').keyup(function() {
            $('#TreeGrid1').data('api').load();
        });
    });
</script>
");
            WriteLiteral("<div class=\"tabs code\">\r\n    <div data-caption=\"view\">");
#nullable restore
#line 185 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml"
                        Write(Html.Source("GridClientDataDemo/Index.cshtml", 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>\r\n<br />\r\n<br />\r\n<h2>Simpler grid, no search</h2>\r\n");
#nullable restore
#line 191 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml"
Write(Html.Awe().Grid("GridSimplerClientData")
      .DataFunc("getSimpleGridData")
      .Height(350)
      .Mod(o => o.PageInfo().PageSize().ColumnsSelector())
      .Persistence(Persistence.View)
      .Columns(
          new Column { Bind = "Id", Width = 75, Groupable = false, Resizable = false },
          new Column { Bind = "Person" },
          new Column { Bind = "Food" },
          new Column { Bind = "Location" },
          new Column { Bind = "Date", Width = 120 },
          new Column { Bind = "CountryName", Header = "Country" },
          new Column { Bind = "ChefName", Header = "Chef" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    function getSimpleGridData(sgp) {
        var gp = utils.getGridParams(sgp);

        function map(o) {
            return {
                Id: o.Id, Person: o.Person, Food: o.Food, Location: o.Location,
                Date: o.DateStr, CountryName: o.CountryName, ChefName: o.ChefName
            };
        };

        return utils.gridModelBuilder(
            {
                gp: gp,
                items: lunches,
                key: ""Id"",
                map: map,

                // replace default group header value for date
                getHeaderVal: { Date: function (o) { return o.DateStr; } }
            });
    }
</script>
");
            WriteLiteral("<div class=\"tabs code\">\r\n    <div data-caption=\"view\">");
#nullable restore
#line 229 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml"
                        Write(Html.Source("GridClientDataDemo/Index.cshtml", 3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>\r\n\r\n<h2>Hybrid</h2>\r\n<div class=\"expl\">\r\n    Using ajax in the client func on the first call only to load the items\r\n</div>\r\n<br />\r\n");
#nullable restore
#line 238 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml"
Write(Html.Awe().Grid("GridHybrid")
      .DataFunc("getHybrid")
      .Height(350)
      .Mod(o => o.PageInfo().PageSize().ColumnsSelector())
      .Persistence(Persistence.View)
      .Resizable()
      .Columns(
          new Column { Bind = "Id", Width = 75, Groupable = false, Resizable = false },
          new Column { Bind = "Person" },
          new Column { Bind = "Food" },
          new Column { Bind = "Location" },
          new Column { Bind = "Date", Width = 120 },
          new Column { Bind = "CountryName", Header = "Country" },
          new Column { Bind = "ChefName", Header = "Chef" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    var loadedItems;
    function getHybrid(sgp) {
        var gp = utils.getGridParams(sgp);
        function maph(o) { return { Id: o.Id, Person: o.Person, Food: o.Food, Location: o.Location,
            Date: o.DateStr, CountryName: o.CountryName, ChefName: o.ChefName }; };

        var opt = {
            gp: gp,
            key: ""Id"",
            map: maph,

            // replace default group header value for date
            getHeaderVal:{ Date: function(o){ return o.DateStr; } }
        };

        if (loadedItems) {
            opt.items = loadedItems;
            return utils.gridModelBuilder(opt);
        }

        return $.get('");
#nullable restore
#line 273 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml"
                 Write(Url.Action("GetLunches", "Data"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\').then(function(items) {\r\n            loadedItems = items;\r\n            opt.items = loadedItems;\r\n            return utils.gridModelBuilder(opt);\r\n        });\r\n    }\r\n</script>\r\n");
            WriteLiteral("\r\n<div class=\"tabs code\">\r\n    <div data-caption=\"view\">");
#nullable restore
#line 283 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml"
                        Write(Html.Source("GridClientDataDemo/Index.cshtml", 4));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>\r\n\r\n<br />\r\n<br />\r\n<h2>Header and Footer Summary</h2>\r\n\r\n");
#nullable restore
#line 291 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml"
Write(Html.Awe().Grid("GridClientDataSum")
      .DataFunc("getGridDataSum")
      .Height(350)
      .Mod(o => o.PageInfo().PageSize().ColumnsSelector())
      .Persistence(Persistence.View)
      .Columns(
          new Column { Bind = "Id", Width = 75, Groupable = false, Resizable = false },
          new Column { Bind = "Person", Group = true },
          new Column { Bind = "Food" },
          new Column { Bind = "Location" },
          new Column { Bind = "Price", Width = 120 },
          new Column { Bind = "CountryName", Header = "Country" },
          new Column { Bind = "ChefName", Header = "Chef" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    function getGridDataSum(sgp) {
        var gp = utils.getGridParams(sgp);

        function makeFooter(info) {
            var total = !info.Level ? ""Total: "" : """";
            var priceSum = 0;
            awef.loop(info.Items, function (el) { priceSum += el.Price; });

            return {
                Person: total,
                Food: "" count = "" + info.Items.length,
                Price: priceSum
            };
        }

        function makeHeader(gr) {
            var name = utils.getColVal(gr.Column, gr.Items[0]);
            return { Content: name + ' Count = ' + gr.Items.length };
        }

        return utils.gridModelBuilder(
            {
                gp: gp,
                items: lunches,
                key: ""Id"",
                makeFooter: makeFooter,
                makeHeader: makeHeader
            });
    }
</script>
");
            WriteLiteral("<div class=\"tabs code\">\r\n    <div data-caption=\"view\">");
#nullable restore
#line 337 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridClientDataDemo\Index.cshtml"
                        Write(Html.Source("GridClientDataDemo/Index.cshtml", 5));

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
