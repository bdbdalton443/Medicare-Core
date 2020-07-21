#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditParent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e828bad63957a82f98eed6f58709b9fe2297a5dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GridInlineEditParent_Index), @"mvc.1.0.view", @"/Views/GridInlineEditParent/Index.cshtml")]
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
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditParent\Index.cshtml"
using AweCoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e828bad63957a82f98eed6f58709b9fe2297a5dc", @"/Views/GridInlineEditParent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_GridInlineEditParent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditParent\Index.cshtml"
  
    ViewBag.Title = "Grid Inline Editing Cascade using Parent";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n    var categories = ");
#nullable restore
#line 6 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditParent\Index.cshtml"
                Write(Html.Raw(DemoUtils.Encode(Db.Categories.Select(o => new KeyContent(o.Id, o.Name)))));

#line default
#line hidden
#nullable disable
            WriteLiteral(";    \r\n</script>\r\n<h2>Grid inline editing, cascade using parent</h2>\r\n\r\n");
#nullable restore
#line 10 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditParent\Index.cshtml"
   var gridId = "gridInlPar"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"bar\">\r\n    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 365, "\"", 415, 3);
            WriteAttributeValue("", 375, "$(\'#", 375, 4, true);
#nullable restore
#line 13 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditParent\Index.cshtml"
WriteAttributeValue("", 379, gridId, 379, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 386, "\').data(\'api\').inlineCreate()", 386, 29, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"awe-btn mbtn\">Create</button>\r\n</div>\r\n\r\n");
#nullable restore
#line 16 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditParent\Index.cshtml"
Write(Html.InitDeletePopupForGrid(gridId, "GridInlineEditDemo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 18 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridInlineEditParent\Index.cshtml"
Write(Html.Awe().Grid(gridId)
      .Mod(o => o.PageInfo().InlineEdit(Url.Action("Create"), Url.Action("Edit")))
      .Url(Url.Action("GridGetItems"))
      .Height(350)
      .Resizable()
      .Reorderable()
      .Columns(
          new Column { Bind = "Id", Width = 75 }
          .Mod(o => o.InlineId()),          
          
          new Column { Bind = "Category.Name", ClientFormat = ".CategoryName", Header = "Category" }
            .Mod(o => o.Inline(
                Html.Awe().AjaxRadioList("CategoryId")
                .Odropdown()
                .DataFunc("utils.getItems(categories)"))),
          
          new Column { Bind = "Meal.Name", ClientFormat = ".MealName", Header = "Meal" }
            .Mod(o => o.Inline(
                Html.Awe().AjaxRadioList("MealId")
                .Odropdown()
                .Url(Url.Action("GetMeals", "Data"))
                .ParentInline("CategoryId", "categories"))),

          new Column { ClientFormat = GridUtils.InlineEditFormat(), Width = 80 },
          new Column { ClientFormat = Html.InlineDeleteFormatForGrid(gridId), Width = 80 }));

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
