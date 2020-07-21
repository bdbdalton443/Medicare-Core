#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32e8ca8ca0bedb9d7cc64bf93dabddfa96af5b3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GridDemo_Filtering), @"mvc.1.0.view", @"/Views/GridDemo/Filtering.cshtml")]
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
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
using AweCoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32e8ca8ca0bedb9d7cc64bf93dabddfa96af5b3f", @"/Views/GridDemo/Filtering.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_GridDemo_Filtering : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
  
    ViewBag.Title = "Grid Filtering";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Grid Filtering</h1>\r\n\r\n<h2>Filter grid using parent controls</h2>\r\n\r\n");
            WriteLiteral("<div class=\"bar\">\r\n    ");
#nullable restore
#line 13 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
Write(Html.Awe().TextBox("txtPerson").Placeholder("search for person ...").CssClass("searchtxt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 14 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
Write(Html.Awe().TextBox("txtFood").Placeholder("search for food ...").CssClass("searchtxt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 15 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
Write(Html.Awe().AjaxRadioList("selCountry").Url(Url.Action("GetCountries", "Data")).Odropdown().HtmlAttributes(new { style = "min-width:15em;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 18 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
Write(Html.Awe().Grid("Grid1")
      .Mod(o => o.ColumnsSelector().PageSize().PageInfo())
      .Columns(
          new Column { Bind = "Id", Width = 75, Groupable = false, Resizable = false },
          new Column { Bind = "Person" },
          new Column { Bind = "Food", ClientFormatFunc = "imgFood", MinWidth = 200 },
          new Column { Bind = "Country.Name", ClientFormat = ".(CountryName)", Header = "Country" },
          new Column { Bind = "Date", Width = 120 }.Mod(o => o.Autohide()),
          new Column { Bind = "Location" }.Mod(o => o.Autohide()),
          new Column { Bind = "Chef.FirstName,Chef.LastName", ClientFormat = ".(ChefName)", Header = "Chef" })
      .Url(Url.Action("GetItems", "LunchGrid"))
      .Reorderable()
      .Resizable()
      .Height(350)
      .Parent("txtPerson", "person")
      .Parent("txtFood", "food")
      .Parent("selCountry", "country"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    var root = \'");
#nullable restore
#line 36 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
           Write(Url.Content("~/Content/Pictures/Food/"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    function imgFood(itm) {\r\n        return \'<img src=\"\' + root + itm.FoodPic + \'\" class=\"food\" />\' + itm.Food;\r\n    }\r\n</script>\r\n");
            WriteLiteral(@"<br />
<div class=""tabs"">
    <div data-caption=""description"" class=""expl"">
        The grid can be filtered by adding parent controls to it, when a parent control triggers the <code>change</code> event,
        the grid (child) will reload and the parent values will be sent as parameters to the data function (or url in this case).
    </div>
    <div data-caption=""view"">
        ");
#nullable restore
#line 49 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
   Write(Html.Source("GridDemo/Filtering.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div data-caption=\"controller\">\r\n        ");
#nullable restore
#line 52 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
   Write(Html.Code("Awesome/Grid/LunchGridController.cs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<h2>Grid filtering using a popup to enter the search criteria</h2>\r\n");
            WriteLiteral("<div class=\"bar\">\r\n    <button type=\"button\" class=\"awe-btn\" onclick=\"awe.open(\'filterGrid\', {}, event)\">Filter</button>\r\n    <button type=\"button\" class=\"awe-btn\" onclick=\"clearFilter()\">Clear Filter</button>\r\n</div>\r\n");
#nullable restore
#line 62 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
Write(Html.Awe().Grid("GridPopupFilter")
      .Mod(o => o.ColumnsSelector().PageSize().PageInfo())
      .Columns(
          new Column { Bind = "Id", Width = 75, Groupable = false, Resizable = false },
          new Column { Bind = "Person" },
          new Column { Bind = "Food", ClientFormatFunc = "imgFood", MinWidth = 200 },
          new Column { Bind = "Country.Name", ClientFormat = ".(CountryName)", Header = "Country" },
          new Column { Bind = "Date", Width = 120 }.Mod(o => o.Autohide()),
          new Column { Bind = "Location" }.Mod(o => o.Autohide()),
          new Column { Bind = "Chef.FirstName,Chef.LastName", ClientFormat = ".(ChefName)", Header = "Chef" })
      .Url(Url.Action("LunchGridFilter", "Data"))
      .Reorderable()
      .Resizable()
      .Height(350));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
     var filterModel = {};

    function clearFilter() {
        filterModel = {};
        filterGrid();
    }

    function filterGrid() {
        var api = $('#GridPopupFilter').data('api');
        api.load({
            params: filterModel
        });
    }

    $(function () {
        aweui.initPopupForm({
            id: 'filterGrid',
            title: 'Filter grid',
            height: 0,
            dropdown: true,
            loadOnce: true,
            setCont: function (sp, o) {
                var b = formBuilder({ model: filterModel, sp: sp });
                b.add({ prop: 'person', func: aweui.txt });
                b.add({ prop: 'food', func: aweui.txt });
                b.add({
                    prop: 'country',
                    func: aweui.radioList,
                    opt: {
                        url: '");
#nullable restore
#line 106 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
                         Write(Url.Action("GetCountries", "Data"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                        odropdown: true
                    }
                });
                b.add({ prop: 'location', func: aweui.txt });
                b.add({ prop: 'date', func: aweui.datepicker });
                b.add({
                    prop: 'chef',
                    func: aweui.lookup,
                    opt: {
                        getUrl: '");
#nullable restore
#line 116 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
                            Write(Url.Action("GetItem","ChefLookup"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                        searchUrl: \'");
#nullable restore
#line 117 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
                               Write(Url.Action("Search", "ChefLookup"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
                    }
                });
                b.applyToPopup(o);
            },
            postFunc: function (sp) {
                var vm = utils.getParams(sp);
                filterModel = vm;
                filterGrid();
                return {};
            }
        });
    });
</script>
");
            WriteLiteral(@"<br />
<br />
<div class=""tabs"">
    <div class=""expl"" data-caption=""description"">
        Using a popupForm and the grid api to filter the grid.
        The search criteria is built inside the popup, and when the Ok button is clicked,
        the post function executes, this is where the grid <code>api.load</code> function is called.
        <br />
        Note: we used aweui to initialize the popupForm, and a formBuilder util class to build its content (just like in the aweui grid filtering demo);
        an alternative would be to use the PopupForm helper and instead the formBuilder we could set the <code>Url</code> to point to an action that returns a partial view with the search criteria form.
    </div>
    <div data-caption=""view"">
        ");
#nullable restore
#line 144 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
   Write(Html.Source("GridDemo/Filtering.cshtml", "popupfilter"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div data-caption=\"controller\">\r\n        ");
#nullable restore
#line 147 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
   Write(Html.Code("Awesome/DataController.cs").Action("LunchGridFilter"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<h2>Filter by all columns</h2>\r\n");
            WriteLiteral("<div class=\"bar\">\r\n    ");
#nullable restore
#line 154 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
Write(Html.Awe().TextBox("txtsearch").Placeholder("search ...").CssClass("searchtxt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <span class=\"hint\">&nbsp; you can search multiple columns at the same time (try \'pizza tavern\')</span>\r\n</div>\r\n\r\n");
#nullable restore
#line 158 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
Write(Html.Awe().Grid("GridClientData")
      .DataFunc("loadDataAndBuildGridModel")
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
            WriteLiteral("\r\n<script>\r\n    var lunches;\r\n    // load data on first call\r\n    function loadDataAndBuildGridModel(sgp) {\r\n        if (!lunches) {\r\n            return $.get(\'");
#nullable restore
#line 179 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
                     Write(Url.Action("GetLunches", "Data"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"')
                .then(function(items) {
                    lunches = items;
                    return getGridData(sgp);
                });
        } else {
            return getGridData(sgp);
        }
    }

    function getGridData(sgp) {
        var where = aweq.where, contains = aweq.contains, loop = awef.loop;
        var gp = utils.getGridParams(sgp);
        var list = lunches;

        if (gp.search) {
            var words = gp.search.toLowerCase().split("" "");

            list = where(lunches, function (o) {
                var matches = 0;
                loop(words, function (w) {
                    if (contains(o.Food, w) || contains(o.Person, w) || contains(o.Location, w) || contains(o.CountryName, w)
                        || contains(o.DateStr, w)
                        || contains(o.ChefName, w)) matches++;
                });

                return matches === words.length;
            });
        }

        function map(o) { return { Id: o.Id, Person");
            WriteLiteral(@": o.Person, Food: o.Food, Location: o.Location,
            Date: o.DateStr, CountryName: o.CountryName, ChefName: o.ChefName }; };


        return utils.gridModelBuilder(
            {
                key:""Id"",
                gp: gp,
                items: list,
                map:map,
                // replace default group header value for Date column
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
        Filtering by multiple columns at once from one textbox, you can type multiple keywords separated by space and the grid will get filtered.
        <br/>
        The grid data is loaded once from the server after it is stored in the 'lunches' variable.
        The function defined in <code>DataFunc</code> can either return the grid model or a promise which will return the grid model later, and in this case on the first load we return a promise ($.get).
    </div>
    <div data-caption=""view"">
        ");
#nullable restore
#line 240 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\Filtering.cshtml"
   Write(Html.Source("GridDemo/Filtering.cshtml", "allfilter"));

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
