#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac7e29b98143c314ecf288016efadc1cf19db5a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AweCoreDemo.Pages.Home.Pages_Home_Index), @"mvc.1.0.razor-page", @"/Pages/Home/Index.cshtml")]
namespace AweCoreDemo.Pages.Home
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
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\_ViewImports.cshtml"
using Omu.AwesomeMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\_ViewImports.cshtml"
using Omu.Awem.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\_ViewImports.cshtml"
using AweCoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
using AweCoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
using AweCoreDemo.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
using AweCoreDemo.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac7e29b98143c314ecf288016efadc1cf19db5a4", @"/Pages/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4da6ccc4d0d5bb3d961440360a6eba8b4767abf6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Home_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
  
    ViewBag.Title = "Overview";
    var mealsDir = Url.Content(DemoUtils.MealsUrl);
    Layout = "~/Views/Shared/_Home.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    var categories = ");
#nullable restore
#line 13 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
                Write(Html.Raw(DemoUtils.Encode(Db.Categories.Select(o => new KeyContent(o.Id, o.Name)))));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var meals = ");
#nullable restore
#line 14 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
           Write(Html.Raw(DemoUtils.Encode(Db.Meals.Select(o => new { k = o.Id, c = o.Name, cid = o.Category.Id, url = mealsDir + o.Name + ".jpg" }))));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    function getMealsChild(params) {
        var pobj = utils.getParams(params);
        var result = [];

        awef.loop(meals, function(item) {
            if(item.cid == pobj.categories)
                result.push(item);
        });

        return result;
    }
</script>
<h1 style=""font-size: 1.2em;"">ASP.net Core MVC Awesome Controls overview:</h1>

<div class=""qo"">
    <div class=""example cbl"">
        <div class=""efield"">
            <div class=""elabel"">
                <a");
            BeginWriteAttribute("href", " href=\"", 1048, "\"", 1108, 2);
#nullable restore
#line 34 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 1055, Url.Action("Index", "AutocompleteDemo"), 1055, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1095, "#Autocomplete", 1095, 13, true);
            EndWriteAttribute();
            WriteLiteral(">Autocomplete</a>\r\n            </div>\r\n            <div class=\"einput\">\r\n                ");
#nullable restore
#line 37 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
            Write(Html.Awe().Autocomplete("Meal")
                      .ItemFunc("awem.imgItem")
                      .DataFunc("utils.getItems(meals)")
                      .Url(Url.Action("GetMealsImgAutoc", "Data"))
                      .Placeholder("try o"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"efield\">\r\n            <div class=\"elabel\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1572, "\"", 1616, 1);
#nullable restore
#line 46 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 1579, Url.Action("Index","DatePickerDemo"), 1579, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">DatePicker</a>\r\n            </div>\r\n            <div class=\"einput\">\r\n                ");
#nullable restore
#line 49 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
           Write(Html.Awe().DatePicker("Date1").ChangeMonth().ChangeYear());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"efield\">\r\n            <div class=\"elabel\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1882, "\"", 1923, 1);
#nullable restore
#line 54 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 1889, Url.Action("Index","TextBoxDemo"), 1889, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Textbox (numeric)</a>\r\n            </div>\r\n            <div class=\"einput\">\r\n                ");
#nullable restore
#line 57 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
            Write(Html.Awe().TextBox("PriceUSD")
                      .Value("20")
                      .FormatFunc("utils.prefix('$')")
                      .Numeric(o => o.Decimals(2)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"example cbl\">\r\n        <div class=\"efield\">\r\n            <div class=\"elabel\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2360, "\"", 2417, 2);
#nullable restore
#line 68 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 2367, Url.Action("Index","AjaxRadioListDemo"), 2367, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2407, "#odropdown", 2407, 10, true);
            EndWriteAttribute();
            WriteLiteral(">Odropdown</a>\r\n            </div>\r\n            <div class=\"einput\">\r\n                ");
#nullable restore
#line 71 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
            Write(Html.Awe().AjaxRadioList("AllMeals")
                      .Odropdown(o => o.AutoSelectFirst()
                                    .ItemFunc("awem.imgItem")
                                    .CaptionFunc("utils.imgCaption"))
                      .DataFunc("utils.getItems(meals)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"efield\">\r\n            <div class=\"elabel\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2914, "\"", 2971, 2);
#nullable restore
#line 80 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 2921, Url.Action("Index", "AjaxRadioListDemo"), 2921, 41, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2962, "#Combobox", 2962, 9, true);
            EndWriteAttribute();
            WriteLiteral(">Combobox</a>\r\n            </div>\r\n            <div class=\"einput\">\r\n                ");
#nullable restore
#line 83 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
            Write(Html.Awe().AjaxRadioList("AllMealsCombo")
                      .Combobox()
                      .Value(Db.Meals[3].Id)
                      .DataFunc("utils.getItems(meals)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"efield\">\r\n            <div class=\"elabel\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 3360, "\"", 3422, 2);
#nullable restore
#line 91 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 3367, Url.Action("Index", "AjaxRadioListDemo"), 3367, 41, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3408, "#oremotesearch", 3408, 14, true);
            EndWriteAttribute();
            WriteLiteral(">Odropdown remote search</a>\r\n            </div>\r\n            <div class=\"einput\">\r\n                ");
#nullable restore
#line 94 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
            Write(Html.Awe().AjaxRadioList("RemoteSearchOdropdown")
                      .Load(false)
                      .Odropdown(o => o.SearchFunc("utils.osearch", Url.Action("SearchMeals", "Data"))));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"example cbl\">\r\n        <div class=\"efield\">\r\n            <div class=\"elabel\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 3881, "\"", 3940, 2);
#nullable restore
#line 104 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 3888, Url.Action("Index","AjaxRadioListDemo"), 3888, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3928, "#ButtonGroup", 3928, 12, true);
            EndWriteAttribute();
            WriteLiteral(">ButtonGroup</a>\r\n            </div>\r\n            <div class=\"einput\">\r\n                ");
#nullable restore
#line 107 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
            Write(Html.Awe().AjaxRadioList("CategoriesButtonGroup")
                  .ButtonGroup()
                  .Value(Db.Categories[2].Id)
                  .DataFunc("utils.getItems(categories)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"efield\">\r\n            <div class=\"elabel\"><a");
            BeginWriteAttribute("href", " href=\"", 4323, "\"", 4369, 1);
#nullable restore
#line 114 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 4330, Url.Action("Index","AjaxDropdownDemo"), 4330, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">AjaxDropdown</a></div>\r\n            <div class=\"einput\">\r\n                ");
#nullable restore
#line 116 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
            Write(Html.Awe().AjaxDropdown("add1")
                      .DataFunc("getMealsChild")
                      .Parent("CategoriesButtonGroup", "categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"efield\">\r\n            <div class=\"elabel\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 4719, "\"", 4811, 2);
#nullable restore
#line 123 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 4726, Url.Action("Index","AjaxRadioListDemo"), 4726, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4766, "#Odropdown-tree-data-lazy-nodes-remote-search", 4766, 45, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    Tree data, remote search, lazy nodes\r\n                </a>\r\n            </div>\r\n            <div class=\"einput\">\r\n                ");
#nullable restore
#line 128 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
            Write(Html.Awe().AjaxRadioList("RmtLazyTree")
                    .Url(Url.Action("GetTreeNodesLazy", "Data"))
                    .Odropdown(o => o.CollapseNodes()
                        .PopupMinWidth(350)
                        .SearchFunc("utils.osearch", Url.Action("SearchTree", "Data"))
                    ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"example cbl\" style=\"padding-left:1em;\">\r\n        <div class=\"ib arl\">\r\n            <div class=\"elabel\"><a");
            BeginWriteAttribute("href", " href=\"", 5455, "\"", 5502, 1);
#nullable restore
#line 139 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 5462, Url.Action("Index","AjaxRadioListDemo"), 5462, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">AjaxRadioList</a></div>\r\n            ");
#nullable restore
#line 140 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
        Write(Html.Awe().AjaxRadioList("ParentCat")
              .Value(Db.Categories[2].Id)
              .Ochk()
              .DataFunc("utils.getItems(categories)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"ib arl\">\r\n            <div class=\"elabel\"><a");
            BeginWriteAttribute("href", " href=\"", 5784, "\"", 5834, 1);
#nullable restore
#line 146 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 5791, Url.Action("Index","AjaxCheckboxListDemo"), 5791, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">AjaxCheckboxList</a></div>\r\n            ");
#nullable restore
#line 147 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
        Write(Html.Awe().AjaxCheckboxList("ChildMeal1")
              .DataFunc("getMealsChild")
              .Ochk()
              .Value(new[] { 185, 187 })
              .Parent("ParentCat", "categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"example cbl\">\r\n        <div class=\"efield\">\r\n            <div class=\"elabel\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 6222, "\"", 6285, 2);
#nullable restore
#line 158 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 6229, Url.Action("Index", "AjaxCheckboxListDemo"), 6229, 44, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6273, "#Multiselect", 6273, 12, true);
            EndWriteAttribute();
            WriteLiteral(">Multiselect</a>\r\n            </div>\r\n            ");
#nullable restore
#line 160 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
        Write(Html.Awe().AjaxCheckboxList("AllMealsMulti")
                  .Multiselect(o => o.ItemFunc("awem.imgItem")
                                    .CaptionFunc("utils.imgCaption")
                                    .NoSelectClose())
                  .CssClass("bigMulti")
                  .Value(new[] { Db.Meals[2].Id, Db.Meals[3].Id, Db.Meals[5].Id })
                  .Url(Url.Action("GetMealsGroupedImg", "Data")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"example cbl\">\r\n        <div class=\"efield\">\r\n            <div class=\"elabel\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 6908, "\"", 6948, 1);
#nullable restore
#line 173 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 6915, Url.Action("Index", "PopupDemo"), 6915, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Popup</a>\r\n            </div>\r\n\r\n            ");
#nullable restore
#line 176 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
        Write(Html.Awe().InitPopup()
                  .Name("popup1")
                  .Url(Url.Action("Popup1", "PopupDemo"))
                  .LoadOnce()
                  .Title("popup title"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 182 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
       Write(Html.Awe().Button().Text("Open Popup").OnClick(Html.Awe().OpenPopup("popup1")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 184 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
        Write(Html.Awe().InitPopup()
                  .Name("popupTop")
                  .Url(Url.Action("Popup1", "PopupDemo"))
                  .LoadOnce()
                  .Modal()
                  .Top()
                  .Mod(o => o.OutClickClose())
                  .Width(1000)
                  .Title("top modal popup"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 194 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
       Write(Html.Awe().Button().Text("Open top modal").OnClick(Html.Awe().OpenPopup("popupTop")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"example\">\r\n        <div class=\"efield cbl\">\r\n            <div class=\"elabel\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 7874, "\"", 7915, 1);
#nullable restore
#line 201 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 7881, Url.Action("Index", "LookupDemo"), 7881, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Lookup</a>\r\n            </div>\r\n            <div class=\"einput\">\r\n                ");
#nullable restore
#line 204 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
            Write(Html.Awe().Lookup("MealLookupDropdown")
                      .Controller("MealLookup")
                      .Mod(o => o.Dropdown()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"efield cbl\">\r\n            <div class=\"elabel\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 8263, "\"", 8309, 1);
#nullable restore
#line 212 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 8270, Url.Action("Index", "MultiLookupDemo"), 8270, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">MultiLookup</a>\r\n            </div>\r\n            <div class=\"einput\">\r\n                ");
#nullable restore
#line 215 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
            Write(Html.Awe().MultiLookup("MealsMultiLookupDropdown")
                  .Controller("MealsMultiLookup"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"efield cbl\">\r\n            <div class=\"elabel\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 8628, "\"", 8676, 1);
#nullable restore
#line 222 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 8635, Url.Action("CustomSearch", "LookupDemo"), 8635, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Lookup (custom search)</a>\r\n            </div>\r\n            <div class=\"einput\">\r\n                ");
#nullable restore
#line 225 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
            Write(Html.Awe().Lookup("MealCustomSearch")
                  .CustomSearch());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"example qo\">\r\n    <div class=\"efield\">\r\n        <div class=\"elabel\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 9005, "\"", 9057, 2);
#nullable restore
#line 234 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 9012, Url.Action("Misc", "LookupDemo"), 9012, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9045, "#Lookup-Grid", 9045, 12, true);
            EndWriteAttribute();
            WriteLiteral(">Lookup grid</a>\r\n        </div>\r\n        <div class=\"einput\">\r\n            ");
#nullable restore
#line 237 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
        Write(Html.Awe().Lookup("MealCustomPopup")
          .LookupGrid(Url.Action("MealLookup", "LookupDemo"))
          .Controller("MealLookup"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<br />\r\n\r\n<div class=\"example\">\r\n    <h3>Grid, search using parent binding</h3>\r\n");
            WriteLiteral("    <div class=\"bar\">\r\n        ");
#nullable restore
#line 250 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
   Write(Html.Awe().TextBox("txtperson").Placeholder("search for person ...").CssClass("searchtxt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 251 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
   Write(Html.Awe().TextBox("txtfood").Placeholder("search for food ...").CssClass("searchtxt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 252 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
   Write(Html.Awe().AjaxRadioList("oCountry").Url(Url.Action("GetCountries", "Data")).Odropdown().HtmlAttributes(new { style = "min-width:15em;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 255 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
Write(Html.Awe().Grid("Grid1")
          .Reorderable()
          .Mod(o => o.PageInfo().PageSize().AutoMiniPager().ColumnsSelector())
          .Columns(
              new Column { Bind = "Id", Width = 75, Groupable = false, Resizable = false },
              new Column { Bind = "Person" },
              new Column { Bind = "Food", ClientFormatFunc = "imgFood", MinWidth = 200 },
              new Column { Bind = "Location" },
              new Column { Bind = "Date", Width = 120 }.Mod(o => o.Autohide()),
              new Column { Bind = "Country.Name", ClientFormat = ".CountryName", Header = "Country" }.Mod(o => o.Autohide()),
              new Column { Bind = "Chef.FirstName,Chef.LastName", ClientFormat = ".ChefName", Header = "Chef" }.Mod(o => o.Autohide()))
          .Url(Url.Action("GetItems", "LunchGrid"))
          .Persistence(Persistence.Session) // save collapsed groups and nodes when switching between grid pages
          .ColumnsPersistence(Persistence.Session) // save columns (width, visibility, etc..) for browser session lifetime
          .Resizable()
          .Height(350)
          .Parent("txtperson", "person")
          .Parent("txtfood", "food")
          .Parent("oCountry", "country"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <script>\r\n        var root = \'");
#nullable restore
#line 275 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
               Write(Url.Content("~/Content/Pictures/Food/"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        function imgFood(itm) {\r\n            return \'<img src=\"\' + root + itm.FoodPic + \'\" class=\"food\" />\' + itm.Food;\r\n        }\r\n    </script>\r\n");
            WriteLiteral("    ");
#nullable restore
#line 281 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
Write(Html.Awe().Tabs().CssClass("code")
          .Add("description",
                        item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("Grid basic features and search using <code>Parent</code> binding.<br />\r\n                            Some columns have autohide mod, you can resize the browser window to see the columns hide and show depending on window width.");
    PopWriter();
}
), "expl")
.Add("view", Html.Source("Home/Index.cshtml", 1))
.Add("controller", Html.Code("Awesome/Grid/LunchGridController.cs")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"example\">\r\n");
            WriteLiteral(@"    <button type=""button"" class=""awe-btn"" onclick=""awem.notif('Hi,</br> how are you ! ', 5000)"">Show Notification</button>
    <button type=""button"" class=""awe-btn redbtn"" onclick=""awem.notif('<h5>Oops !</h5> error example ', 0, 'o-err')"">Show Error</button>
    <button type=""button"" class=""awe-btn"" onclick=""awe.flash($(this).parent())"">Flash</button>
    <button type=""button"" class=""awe-btn"" onclick=""awe.flash(awem.notif('Hi,</br> how are you ! ', 5000))"">Flash Notify</button>
");
            WriteLiteral("\r\n    <div class=\"code\">\r\n        ");
#nullable restore
#line 298 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
   Write(Html.Source("Home/Index.cshtml", "msc"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div id=\'lastEx\'>\r\n</div>\r\n\r\n<br />\r\n<br />\r\nSee also:\r\n<br />\r\n<a");
            BeginWriteAttribute("href", " href=\"", 12467, "\"", 12513, 1);
#nullable restore
#line 309 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 12474, Url.Action("Index", "DragAndDropDemo"), 12474, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Drag And Drop Demo (grid move rows)</a>\r\n<br />\r\n<a");
            BeginWriteAttribute("href", " href=\"", 12567, "\"", 12616, 1);
#nullable restore
#line 311 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 12574, Url.Action("Index", "GridClientDataDemo"), 12574, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Grid Client Data Demo</a>\r\n<br />\r\n<a");
            BeginWriteAttribute("href", " href=\"", 12656, "\"", 12723, 2);
#nullable restore
#line 313 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
WriteAttributeValue("", 12663, Url.Action("Index", "GridNestingDemo"), 12663, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 12702, "#In-nest-editing-grid", 12702, 21, true);
            EndWriteAttribute();
            WriteLiteral(">Grid In Nest Editing Demo</a>\r\n<br />\r\n");
#nullable restore
#line 315 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
Write(Html.ActionLink("Grid Inline Editing Demo", "Index", "GridInlineEditDemo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 317 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
Write(Html.ActionLink("Master Detail Crud Demo", "Index", "MasterDetailCrudDemo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 319 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
Write(Html.ActionLink("Wizard Demo", "Index", "WizardDemo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<script>\r\n    $(function() {\r\n        var indx = 0;\r\n        var last = $(\'#lastEx\');\r\n        var url = \'");
#nullable restore
#line 326 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Home\Index.cshtml"
              Write(Url.Action("Rend", "Data"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

        site.loadWhenSeen(last, url, indx++, loadNext);

        function loadNext(res) {
            if (!res || res == 'end') return;

            var el = $('<div class=""example"" />').html(res);
            last.after(el);
            last = el;

            site.handleAnchors();
            site.handleTabs();
            site.parseCode();
            site.prettyPrint();

            site.loadWhenSeen(last, url, indx++, loadNext);
        }
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AweCoreDemo.Pages.Home.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AweCoreDemo.Pages.Home.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AweCoreDemo.Pages.Home.IndexModel>)PageContext?.ViewData;
        public AweCoreDemo.Pages.Home.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591