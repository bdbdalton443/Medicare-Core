#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditDemo\Popup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6c8e84c11eff28c5627405e700f4a19670a6f4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GridInlineEditDemo_Popup), @"mvc.1.0.view", @"/Views/GridInlineEditDemo/Popup.cshtml")]
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
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditDemo\Popup.cshtml"
using AweCoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6c8e84c11eff28c5627405e700f4a19670a6f4c", @"/Views/GridInlineEditDemo/Popup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_GridInlineEditDemo_Popup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditDemo\Popup.cshtml"
 using (Html.Awe().BeginContext())
{
    var gridId = "DinnersGrid";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"bar\">\r\n        <div style=\"float: right;\">\r\n            ");
#nullable restore
#line 7 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditDemo\Popup.cshtml"
       Write(Html.Awe().TextBox("txtSearch2").Placeholder("search...").CssClass("searchtxt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        ");
#nullable restore
#line 9 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditDemo\Popup.cshtml"
   Write(Html.InlineCreateButtonForGrid(gridId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditDemo\Popup.cshtml"
          
            var initObj = new
            {
                Name = DemoUtils.RndName(),
                Date = DateTime.Now.ToShortDateString(),
                ChefId = Db.Chefs.First().Id,
                MealsIds = Db.Meals.Take(2).Select(o => o.Id).ToArray()
            };
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 20 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditDemo\Popup.cshtml"
   Write(Html.InlineCreateButtonForGrid(gridId, initObj, "Create with predefined values"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 23 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditDemo\Popup.cshtml"
Write(Html.InitDeletePopupForGrid(gridId, "GridInlineEditDemo"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditDemo\Popup.cshtml"
    Write(Html.Awe().Grid(gridId)
                .Mod(o => o.PageInfo().InlineEdit(Url.Action("Create"), Url.Action("Edit"))).Url(Url.Action("GridGetItems"))
                .Parent("txtSearch2", "search")
                .Height(350)
                .Resizable()
                .Reorderable()
                .Attr("data-syncg", "dinner")
                .Columns(
          new Column { Bind = "Id", Width = 75 }
              .Mod(o => o.InlineId()),

          new Column { Bind = "Name" }
              .Mod(o => o.Inline(Html.Awe().TextBox("Name"))),

          new Column { Bind = "Date", Width = 170 }
              .Mod(o => o.Inline(Html.Awe().DatePicker("Date"))),

          new Column { Bind = "Chef.FirstName,Chef.LastName", ClientFormat = ".(ChefName)", Header = "Chef", Width = 200 }
              .Mod(o => o.Inline(Html.Awe().Lookup("Chef").Controller("ChefLookup"), "ChefId")),

          new Column { ClientFormat = ".Meals", Header = "Meals", Width = 250 }
              .Mod(o => o.Inline(Html.Awe().AjaxCheckboxList("Meals").Multiselect().DataFunc("utils.getItems(meals)"), "MealsIds")),

          new Column { Bind = "BonusMeal.Name", ClientFormat = ".BonusMeal", Header = "Bonus Meal" }
              .Mod(o => o.Inline(Html.Awe().AjaxRadioList("BonusMealId").DataFunc("utils.getItems(meals)").Odropdown(), "BonusMealId")),

          new Column { Bind = "Organic", Width = 100, ClientFormat = ".(DispOrganic)" }
              .Mod(o => o.Inline(Html.Awe().CheckBox("Organic").Otoggl())),
          new Column { ClientFormat = GridUtils.InlineEditFormat(), Width = 80 },
          new Column { ClientFormat = Html.InlineDeleteFormatForGrid(gridId), Width = 85 }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditDemo\Popup.cshtml"
                                                                                            }

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
