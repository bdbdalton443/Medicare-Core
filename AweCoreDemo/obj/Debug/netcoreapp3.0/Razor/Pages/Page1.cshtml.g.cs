#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68f1f51e5769233a94f6c1f77da4897877c44e93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AweCoreDemo.Pages.Pages_Page1), @"mvc.1.0.razor-page", @"/Pages/Page1.cshtml")]
namespace AweCoreDemo.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68f1f51e5769233a94f6c1f77da4897877c44e93", @"/Pages/Page1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4da6ccc4d0d5bb3d961440360a6eba8b4767abf6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Page1 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
  
    ViewData["Title"] = "Send ajax request to page handlers instead of controllers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Send ajax request to page handlers instead of controllers</h1>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 211, "\"", 236, 1);
#nullable restore
#line 8 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
WriteAttributeValue("", 218, Url.Page("Index"), 218, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Back to main page</a>\r\n\r\n<h2>AjaxDropdown</h2>\r\n");
#nullable restore
#line 11 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().AjaxDropdown("Category").Url(Url.Page("Page1", "GetCategories")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().AjaxDropdown("Meal").Url(Url.Page("Page1", "GetMeals")).Parent("Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>AjaxRadioList and AjaxCheckboxList</h2>\r\n<div class=\"o-pad awe-il\">\r\n    ");
#nullable restore
#line 16 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().AjaxRadioList("Category1").Url(Url.Page("", "GetCategories")).Ochk());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"o-pad awe-il\">\r\n    ");
#nullable restore
#line 19 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().AjaxRadioList("Meal1").Url(Url.Page("", "GetMeals")).Parent("Category1").Ochk());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"o-pad awe-il\">\r\n    ");
#nullable restore
#line 22 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().AjaxCheckboxList("Meals").Url(Url.Page("", "GetMeals")).Parent("Category1").Ochk());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<h2>Checkbox</h2>\r\n<label>\r\n    ");
#nullable restore
#line 27 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().CheckBox("chk1").Value(true).Ochk());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"chkLbl\">label text</span>\r\n</label>\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 31 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().CheckBox("chk2").Value(true).Otoggl());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Odropdown</h2>\r\n");
#nullable restore
#line 34 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().AjaxRadioList("MealsOdropdown").Odropdown().Url(Url.Page("", "GetAllMeals")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Combobox</h2>\r\n");
#nullable restore
#line 37 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().AjaxRadioList("MealCombo").Combobox().Url(Url.Page("", "GetAllMeals")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>ColorPicker</h2>\r\n");
#nullable restore
#line 40 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().AjaxRadioList("Color").ColorDropdown(o => o.AutoSelectFirst()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>TimePicker</h2>\r\n");
#nullable restore
#line 43 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().AjaxRadioList("Time1").TimePicker(o => o.AutoSelectFirst()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Multiselect</h2>\r\n");
#nullable restore
#line 46 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().AjaxCheckboxList("CategoriesMulti").Multiselect().Url(Url.Page("", "GetAllMeals")).HtmlAttributes(new { style = "width:300px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n<h2>ButtonGroup</h2>\r\n");
#nullable restore
#line 50 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().AjaxRadioList("CategoryButtonGroup").ButtonGroup().Url(Url.Page("", "GetCategories")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Lookup</h2>\r\n");
#nullable restore
#line 53 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().Lookup("MealLookup").Controller("MealLookup"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>MultiLookup</h2>\r\n");
#nullable restore
#line 56 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().MultiLookup("MealsMultiLookup").Controller("MealsMultiLookup"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Autocomplete</h2>\r\n");
#nullable restore
#line 59 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().Autocomplete("MealsAuto").Url(Url.Page("", "GetMealsAuto")).Placeholder("try mango, apple ..."));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Datepicker</h2>\r\n");
#nullable restore
#line 62 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().DatePicker("Date").ChangeMonth().ChangeYear());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Timepicker</h2>\r\n");
#nullable restore
#line 65 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().TimePicker("Time2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Textbox</h2>\r\n");
#nullable restore
#line 68 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().TextBox("txt1").Placeholder("text"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Numeric Textbox</h2>\r\n");
#nullable restore
#line 71 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().TextBox("Number").Numeric().Placeholder("number"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Grid</h2>\r\n");
#nullable restore
#line 74 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().Grid("DinnersGrid")
        .Mod(o => o.PageInfo().PageSize().ColumnsSelector().ColumnsAutohide())
        .Url(Url.Page("","GridGetItems"))
        .Height(400)
        .Columns(
        new Column { Bind = "Name" }.Mod(o => o.NoAutohide()),
        new Column { Bind = "Country.Name", ClientFormat = ".CountryName", Header = "Country" },
        new Column { Bind = "Chef.FirstName,Chef.LastName", ClientFormat = ".ChefName", Header = "Chef" },
        new Column { Bind = "Date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>AjaxList</h2>\r\n");
#nullable restore
#line 85 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().TextBox("searchMeal").Placeholder("search for a meal..."));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div style=\"min-height:400px;margin-top: 5px;\">\r\n    ");
#nullable restore
#line 88 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Page1.cshtml"
Write(Html.Awe().AjaxList("mealsList").Url(Url.Page("", "GetMealsAjaxList")).Parent("searchMeal"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AweRazorPages.Pages.Page1Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AweRazorPages.Pages.Page1Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AweRazorPages.Pages.Page1Model>)PageContext?.ViewData;
        public AweRazorPages.Pages.Page1Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591