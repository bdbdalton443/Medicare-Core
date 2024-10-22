#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Shared\_Examination.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8b6f2bbc6c15915747a5677fe3da5654e06803c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AweCoreDemo.Pages.Shared.Pages_Shared__Examination), @"mvc.1.0.view", @"/Pages/Shared/_Examination.cshtml")]
namespace AweCoreDemo.Pages.Shared
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
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Shared\_Examination.cshtml"
using AweCoreDemo.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b6f2bbc6c15915747a5677fe3da5654e06803c", @"/Pages/Shared/_Examination.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4da6ccc4d0d5bb3d961440360a6eba8b4767abf6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Examination : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AweRazorPages.Pages.InlineEdtModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2 data-u=\"");
#nullable restore
#line 2 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Shared\_Examination.cshtml"
       Write(Url.Action("Index","GridInlineEditDemo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Grid inline editing demo</h2>\r\n");
#nullable restore
#line 5 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Shared\_Examination.cshtml"
  
    var gridIdExam = "examinations";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n     var tests = ");
#nullable restore
#line 9 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Shared\_Examination.cshtml"
            Write(Html.Raw(DemoUtils.Encode(Model.Tests.Select(o => new KeyContent(o.TestID, o.Name)))));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</script>\r\n<div class=\"bar\">\r\n    <div style=\"float: right;\">\r\n        ");
#nullable restore
#line 13 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Shared\_Examination.cshtml"
   Write(Html.Awe().TextBox("txtSearchInlExam").Placeholder("search...").CssClass("searchtxt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input id=\"assID\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 525, "\"", 563, 1);
#nullable restore
#line 14 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Shared\_Examination.cshtml"
WriteAttributeValue("", 533, Model.Assignment.AssignmentID, 533, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 606, "\"", 660, 3);
            WriteAttributeValue("", 616, "$(\'#", 616, 4, true);
#nullable restore
#line 16 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Shared\_Examination.cshtml"
WriteAttributeValue("", 620, gridIdExam, 620, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 631, "\').data(\'api\').inlineCreate()", 631, 29, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"awe-btn\">Create</button>\r\n</div>\r\n\r\n");
#nullable restore
#line 19 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Shared\_Examination.cshtml"
Write(Html.Awe()
    .InitPopupForm()
    .Name("delete2" + gridIdExam)
    .Group(gridIdExam)
    .Url(Url.Action("Delete", "Data"))
    .Success("utils.itemDeleted('" + gridIdExam + "')")
    .OnLoad("utils.delConfirmLoad('" + gridIdExam + "')") // calls grid.api.select and animates the row
    .Height(200)
    .Modal());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 29 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Pages\Shared\_Examination.cshtml"
Write(Html.Awe().Grid(gridIdExam)
      .Mod(o => o.PageInfo().InlineEdit(Url.Action("CreateProcedure", "Data"), Url.Action("EditProcedure", "Data")))
      .Url(Url.Action("GridGetProcedures", "Data"))
      .Parent("assID", "searchProc")
      .Height(350)
      .Resizable()
      .Reorderable()
    .Columns(
          new Column { Bind = "ProcedureID", Width = 70, Header = "ID" }
          .Mod(o => o.InlineId()),

          new Column { Bind = "Test.Name", ClientFormat = ".(Test)", Header = "Test" }
            .Mod(o => o.Inline(Html.Awe().AjaxRadioList("TestID").Odropdown().DataFunc("utils.getItems(tests)"), "TestID")),

          new Column { Bind = "Description", Width = 200, Header = "Description" }
            .Mod(o => o.Inline(Html.Awe().TextBox("Description"))),

           new Column { Bind = "Findings", Width = 200, Header = "Findings" }
            .Mod(o => o.Inline(Html.Awe().TextBox("Findings"))),

          //new Column { Bind = "Date", Width = 160 }
          //  .Mod(o => o.Inline(Html.Awe().DatePicker("Date").ReadonlyInput().ChangeYear().ChangeMonth())),

          //new Column { Bind = "Chef.FirstName,Chef.LastName", ClientFormat = ".(ChefName)", Header = "Chef", MinWidth = 170 }
          //  .Mod(o => o.Inline(Html.Awe().Lookup("Chef").Controller("ChefLookup"), "ChefId")),

          //new Column { ClientFormat = ".(Meals)", Header = "Meals", MinWidth = 250 }
          //  .Mod(o => o.Inline(Html.Awe().AjaxCheckboxList("Meals").Multiselect().DataFunc("utils.getItems(meals)"), "MealsIds")),

          //new Column { Bind = "Organic", Width = 90, ClientFormat = ".(DispOrganic)" }
          //  .Mod(o => o.Inline(Html.Awe().CheckBox("Organic").Otoggl())),

          new Column { ClientFormat = GridUtils.InlineEditFormat(), Width = 80 },
        new Column { ClientFormat = Html.InlineDeleteFormatForGrid(gridIdExam), Width = 85 }));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AweRazorPages.Pages.InlineEdtModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
