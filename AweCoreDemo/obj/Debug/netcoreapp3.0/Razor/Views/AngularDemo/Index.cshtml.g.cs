#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AngularDemo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "251753400ece08c5ec207d676e77ebee236398a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AngularDemo_Index), @"mvc.1.0.view", @"/Views/AngularDemo/Index.cshtml")]
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
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AngularDemo\Index.cshtml"
using AweCoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"251753400ece08c5ec207d676e77ebee236398a3", @"/Views/AngularDemo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_AngularDemo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AngularDemo\Index.cshtml"
  
    ViewBag.Title = "Angular.js Demo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Angular.js Demo</h1>\r\n<br />\r\n\r\n<div class=\"expl\">\r\n    For Angular (2+), React, Vue demos please see the <a href=\"https://www.aspnetawesome.com/#All-Downloads\">Downloads</a> section on our home page.\r\n</div>\r\n<br/>\r\n<br/>\r\n\r\n");
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.7.5/angular.min.js""></script>

<div ng-app=""myAwesomeApp"">
    <div ng-controller=""MealsCtrl"">

        <div class=""awe-il"">
            <p ng-repeat=""meal in meals"">
                <input type=""text"" ng-model=""meal.Name"" />
                <button type=""button"" class=""awe-btn"" ng-click=""deleteMeal($index)"">Delete</button>
            </p>
            <div>
                <input type=""text"" placeholder=""new meal"" ng-model=""newMeal"" />
                <button type=""button"" class=""awe-btn"" ng-click=""addMeal()"">Add Meal</button>
            </div>
        </div>

        <div class=""awe-il vtop"" style=""margin-left: 1em;"">
            ");
#nullable restore
#line 34 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AngularDemo\Index.cshtml"
       Write(Html.Awe().AjaxRadioList("Meals").DataFunc("getAngData('meals', 'Id', 'Name')").NgModel("selectedMeal"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 35 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AngularDemo\Index.cshtml"
       Write(Html.Awe().AjaxRadioList("Meals2").DataFunc("getAngData('meals', 'Id', 'Name')").Odropdown().NgModel("selectedMeal"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 36 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AngularDemo\Index.cshtml"
       Write(Html.Awe().AjaxDropdown("Meals3").DataFunc("getAngData('meals', 'Id', 'Name')").NgModel("selectedMeal"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 37 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AngularDemo\Index.cshtml"
       Write(Html.Awe().AjaxRadioList("Meals4").DataFunc("getAngData('meals', 'Id', 'Name')").ButtonGroup().NgModel("selectedMeal"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <br />\r\n            ");
#nullable restore
#line 40 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AngularDemo\Index.cshtml"
       Write(Html.Awe().AjaxCheckboxList("MealsMulti2").DataFunc("getAngData('meals', 'Id', 'Name')").NgModel("selectedMultiMeals"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 41 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AngularDemo\Index.cshtml"
       Write(Html.Awe().AjaxCheckboxList("MealsMulti").DataFunc("getAngData('meals', 'Id', 'Name')").Multiselect().NgModel("selectedMultiMeals"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div>
            <br />
            <div class=""elabel"">Selected meal</div>
            <input type=""text"" ng-model=""selectedMeal"" /></div>
        <div>
            <br />
            <div class=""elabel"">Selected multi meals</div>
            <input type=""text"" ng-model=""selectedMultiMeals"" /></div>
        <div>
            <br />
            <div class=""elabel""></div>
            ");
#nullable restore
#line 54 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AngularDemo\Index.cshtml"
        Write(Html.Awe().TextBox("awetxt")
                        .HtmlAttributes(null, new { ng_model = "selectedMeal", type="text", style="display:none;" })
                        .FormatFunc("utils.prefix('value is: ')")
                        .Numeric(o => o.Min(163).Step(2)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n        <div style=\"margin-top: 1em;\">\r\n            ");
#nullable restore
#line 60 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AngularDemo\Index.cshtml"
        Write(Html.Awe().Grid("GridClientData")
                  .DataFunc("getGridData")
                  .Height(250)
                  .Groupable(false)
                  .Mod(o => o.PageInfo())
                  .Resizable()
                  .Columns(
                      new Column { Bind = "Id", Width = 75, Groupable = false, Resizable = false },
                      new Column { Bind = "Name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    var meals = ");
#nullable restore
#line 74 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AngularDemo\Index.cshtml"
           Write(Html.Raw(DemoUtils.Encode(Db.Meals.Where(o => o.Category == Db.Categories.First()))));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var myAwesomeApp = angular.module(\'myAwesomeApp\', []);\r\n    \r\n    myAwesomeApp.controller(\'MealsCtrl\', function ($scope) {\r\n        $scope.meals = meals;\r\n        $scope.selectedMeal = ");
#nullable restore
#line 79 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AngularDemo\Index.cshtml"
                         Write(Db.Meals[1].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        $scope.selectedMultiMeals = JSON.stringify(");
#nullable restore
#line 80 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AngularDemo\Index.cshtml"
                                              Write(Html.Raw(DemoUtils.Encode(new[] { Db.Meals[1].Id, Db.Meals[2].Id })));

#line default
#line hidden
#nullable disable
            WriteLiteral(@");
        
        $scope.$watch('meals', function (oldValue, newValue) {
            if (oldValue != newValue) {
                renderEditors($scope.meals, [""Meals"", ""Meals2"", ""Meals3"", ""Meals4"", ""MealsMulti"", ""MealsMulti2""], ""Id"", ""Name"");
                $('#GridClientData').data('api').load();
            }
        }, true);

        // sync selectedMeal (single select editors) value change
        $scope.$watch('selectedMeal', function(ov, nv) {
            if (ov != nv) {
                setTimeout(function() {
                    $('#awetxt').data('api').render();
                    renderEditors($scope.meals, [""Meals"", ""Meals2"", ""Meals3"", ""Meals4""], ""Id"", ""Name"");
                });
            }
        });
        
        // sync selectedMultiMeals ( multiselect editors) value change
        $scope.$watch('selectedMultiMeals', function(ov, nv) {
            if (ov != nv) {
                setTimeout(function() {
                    renderEditors($scope.meals, ['MealsMulti");
            WriteLiteral(@"', 'MealsMulti2'], ""Id"", ""Name"");
                });
            }
        });
        
        // create, delete functions
        
        $scope.newCounter = 1000;
        $scope.addMeal = function() {
            $scope.meals.push({ Name: $scope.newMeal, Id:$scope.newCounter++ });
            $scope.newMeal = '';
        };

        $scope.deleteMeal = function(index) {
            var removed = $scope.meals.splice(index, 1);
            var remId = removed[0].Id;
            if ($scope.selectedMeal == remId) {
                $scope.selectedMeal = null;
            }

            var selmeals = JSON.parse($scope.selectedMultiMeals);
            if (selmeals && selmeals.length) {
                for (var i = 0; i < selmeals.length; i++) {
                    if (selmeals[i] == remId) {
                        selmeals.splice(i, 1);
                    }
                }

                $scope.selectedMultiMeals = JSON.stringify(selmeals);
            }
        };
    });");
            WriteLiteral(@"
    
    function getGridData(sgp) {
        var gp = utils.getGridParams(sgp);
        
        // clone items to avoid grid sorting items in other editors
        var items = $.extend(true, [], this.v.scope()[""meals""]);
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
        $editor.data('api').render(o);
    }
    
    function toKeyContent(list, key, con) {
        return $.map(list, function (o) { return { k: o[key], c: o[con] }; });
    }
    
    function getAngData(collName, kprop, cprop) {
        return function() {
            ");
            WriteLiteral("return toKeyContent(this.v.scope()[collName], kprop, cprop);\r\n        };\r\n    }\r\n</script>\r\n");
            WriteLiteral(@"<br/>
<div class=""tabs"">
    <div data-caption=""description"" class=""expl"">
        All helpers get data from the angular $scope by using the DataFunc extension.
        <br />
        The value of the editors and select items are synchronized using angular $scope.$watch and the client side api of the editors $(#EditorId).data('api').render(o).<br />
        A custom helper extension is used .NgModel to set hte ng-model attribute to the value input, it also sets type=""text"" and style=""display:none;"" which is a workaround because angular.js doesn't handle ng-model for hidden inputs. 
    </div>
    <div data-caption=""view"">");
#nullable restore
#line 181 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AngularDemo\Index.cshtml"
                        Write(Html.Source("AngularDemo/Index.cshtml"));

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
