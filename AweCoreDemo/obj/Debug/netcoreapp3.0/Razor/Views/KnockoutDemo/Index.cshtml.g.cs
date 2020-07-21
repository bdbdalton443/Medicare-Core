#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\KnockoutDemo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1467d0e8d4926d3529490c28a906a976a83d664"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KnockoutDemo_Index), @"mvc.1.0.view", @"/Views/KnockoutDemo/Index.cshtml")]
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
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\KnockoutDemo\Index.cshtml"
using AweCoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1467d0e8d4926d3529490c28a906a976a83d664", @"/Views/KnockoutDemo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_KnockoutDemo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\KnockoutDemo\Index.cshtml"
  
    ViewBag.Title = "Knockout.js Demo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Knockout.js Demo</h1>\r\n<br/>\r\n\r\n");
            WriteLiteral(@"<script src=""https://cdnjs.cloudflare.com/ajax/libs/knockout/3.3.0/knockout-min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/knockout.mapping/2.4.1/knockout.mapping.min.js""></script>

<div class=""awe-il"">
    <div data-bind=""foreach: meals"">
        <p>
            <input type=""text"" data-bind=""value: Name, event: { change: $parent.itemChanged }"" />
            <button type=""button"" class=""awe-btn"" data-bind=""click: $parent.deleteMeal"">Delete</button>
        </p>
    </div>
    <div>
        <input type=""text"" placeholder=""new meal"" data-bind=""value: newMeal"" />
        <button type=""button"" class=""awe-btn"" data-bind=""click: addMeal"">Add Meal</button>
    </div>
</div>
<div class=""awe-il vtop"" style=""margin-left: 1em;"">
    ");
#nullable restore
#line 26 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\KnockoutDemo\Index.cshtml"
Write(Html.Awe().AjaxRadioList("Meals").DataFunc("getKoData('meals', 'Id', 'Name')")
          .HtmlAttributes(null, new { data_bind = "value: selectedMeal, event: { change: selMealChange } " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 28 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\KnockoutDemo\Index.cshtml"
Write(Html.Awe().AjaxRadioList("Meals2").DataFunc("getKoData('meals', 'Id', 'Name')").Odropdown()
          .HtmlAttributes(null, new { data_bind = "value: selectedMeal, event: { change: selMealChange } " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 30 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\KnockoutDemo\Index.cshtml"
Write(Html.Awe().AjaxDropdown("Meals3").DataFunc("getKoData('meals', 'Id', 'Name')")
          .HtmlAttributes(null, new { data_bind = "value: selectedMeal, event: { change: selMealChange } " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 32 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\KnockoutDemo\Index.cshtml"
Write(Html.Awe().AjaxRadioList("Meals4").DataFunc("getKoData('meals', 'Id', 'Name')").ButtonGroup()
          .HtmlAttributes(null, new { data_bind = "value: selectedMeal, event: { change: selMealChange } " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br/>\r\n    <br/>\r\n    ");
#nullable restore
#line 36 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\KnockoutDemo\Index.cshtml"
Write(Html.Awe().AjaxCheckboxList("MealsMulti2").DataFunc("getKoData('meals', 'Id', 'Name')")
          .HtmlAttributes(null, new { data_bind = "value: selectedMultiMeals, event: { change: selMultiMealsChange } " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 38 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\KnockoutDemo\Index.cshtml"
Write(Html.Awe().AjaxCheckboxList("MealsMulti").DataFunc("getKoData('meals', 'Id', 'Name')").Multiselect()
          .HtmlAttributes(null, new { data_bind = "value: selectedMultiMeals, event: { change: selMultiMealsChange } " }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

    <div><br /><div class=""elabel"">Selected meal</div><input type=""text"" data-bind=""value: selectedMeal, event: { change: selMealChange }"" /></div>
    <div><br /><div class=""elabel"">Selected multi meals</div><input type=""text"" data-bind=""value: selectedMultiMeals, event: { change: selMultiMealsChange }"" /></div>
<div>
    <br />
    <div class=""elabel""></div>");
#nullable restore
#line 46 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\KnockoutDemo\Index.cshtml"
                          Write(Html.Awe().TextBox("awetxt")
          .HtmlAttributes(null, new { data_bind = "value: selectedMeal, event: { change: selMealChange }" })
          .FormatFunc("utils.prefix('value is: ')")
          .Numeric(o => o.Min(163).Step(2)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n <div style=\"margin-top: 1em;\">\r\n            ");
#nullable restore
#line 52 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\KnockoutDemo\Index.cshtml"
        Write(Html.Awe().Grid("GridClientData")
                  .DataFunc("getGridData")
                  .Height(250)
                  .Groupable(false)
                  .Mod(o => o.PageInfo())
                  .Persistence(Persistence.View)
                  .Resizable(true)
                  .Columns(
                      new Column { Bind = "Id", Width = 75, Groupable = false, Resizable = false },
                      new Column { Bind = "Name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n<script>\r\n    \r\n    function AppViewModel() {\r\n        var self = this;\r\n        var newCounter = 1000;\r\n        var meals = ");
#nullable restore
#line 69 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\KnockoutDemo\Index.cshtml"
               Write(Html.Raw(DemoUtils.Encode(Db.Meals.Where(o => o.Category == Db.Categories.First()))));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        \r\n        self.meals = ko.mapping.fromJS(meals);\r\n        self.selectedMeal = ko.observable(");
#nullable restore
#line 72 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\KnockoutDemo\Index.cshtml"
                                     Write(Db.Meals[1].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n        self.selectedMultiMeals = ko.observable(JSON.stringify(");
#nullable restore
#line 73 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\KnockoutDemo\Index.cshtml"
                                                          Write(Html.Raw(DemoUtils.Encode(new []{ Db.Meals[1].Id, Db.Meals[2].Id})));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"));
        self.newMeal = ko.observable('');
        
        self.addMeal = function() {
            self.meals.push(ko.mapping.fromJS({ Id: newCounter++, Name: self.newMeal() }));
            self.newMeal('');
        };

        self.deleteMeal = function(row) {
            self.meals.remove(row);
        };

        self.itemChanged = onItemsChange;
        self.meals.subscribe(onItemsChange);
        
        function onItemsChange() {
            var list = ko.mapping.toJS(self.meals);
            renderEditors(list, [""Meals"", ""Meals2"", ""Meals3"", ""Meals4"", ""MealsMulti"", ""MealsMulti2""], ""Id"", ""Name"");
            $('#GridClientData').data('api').load();
            return true;
        }
        
        self.selMealChange = function () {
            var list = ko.mapping.toJS(self.meals);
            renderEditors(list, [""Meals"", ""Meals2"", ""Meals3"", ""Meals4""], ""Id"", ""Name"");
            $('#awetxt').data('api').render();
            return true;
        };
        
        ");
            WriteLiteral(@"self.selMultiMealsChange = function() {
            var list = ko.mapping.toJS(self.meals);
            renderEditors(list, [""MealsMulti"", ""MealsMulti2""], ""Id"", ""Name"");
            return true;
        };

    }

    var appvm = new AppViewModel();
    
    ko.applyBindings(appvm);
    
    function getGridData(sgp) {
        var gp = utils.getGridParams(sgp);
        
        // clone items to avoid grid sorting items in other editors
        var items = ko.mapping.toJS(appvm[""meals""]);

        return utils.gridModelBuilder({
            gp: gp,
            items: items,
            key:""Id""
        });
    }

    // utility functions
    function renderEditors(list, ids, kprop, cprop) {
        $.each(ids, function(i, val) {
            renderEditor(list, val, kprop, cprop);
        });
    }
    
    function renderEditor(list, id, kprop, cprop) {
        var $editor = $('#' + id);
        var o = $editor.data('o');
        o.lrs = toKeyContent(list, kprop, cprop);
   ");
            WriteLiteral(@"     $editor.data('api').render(o);
    }
    
    function toKeyContent(list, key, con) {
        return $.map(list, function (o) { return { k: o[key], c: o[con] }; });
    }
    
    function getKoData(collName, kprop, cprop) {
        return function() {
            return toKeyContent(ko.mapping.toJS(appvm[collName]), kprop, cprop);
        };
    }
</script>
");
            WriteLiteral(@"<br/>
<div class=""tabs"">
    <div data-caption=""description"" class=""expl"">
    All helpers get data from the knockout application viewmodel by using the DataFunc extension. <br/>
        The value of the editors and select items are synchronized using knockout data-bind attributes, events and the client side api of the editors $(#EditorId).data('api').render(o).<br/>
    </div>
    <div data-caption=""view"">");
#nullable restore
#line 158 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\KnockoutDemo\Index.cshtml"
                        Write(Html.Source("KnockoutDemo/Index.cshtml"));

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
