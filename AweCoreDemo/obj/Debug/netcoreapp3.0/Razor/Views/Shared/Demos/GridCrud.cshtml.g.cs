#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\GridCrud.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31cf4475076e9f4dd35b423c22d90d76b440dada"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Demos_GridCrud), @"mvc.1.0.view", @"/Views/Shared/Demos/GridCrud.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31cf4475076e9f4dd35b423c22d90d76b440dada", @"/Views/Shared/Demos/GridCrud.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Demos_GridCrud : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2 data-u=\"");
#nullable restore
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\GridCrud.cshtml"
       Write(Url.Action("Index","GridCrudDemo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Grid CRUD</h2>\r\n\r\n");
#nullable restore
#line 4 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\GridCrud.cshtml"
Write(Html.InitCrudPopupsForGrid("DinnersGrid", "DinnersGridCrud"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"bar\">\r\n    <div style=\"float: right;\">\r\n        ");
#nullable restore
#line 8 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\GridCrud.cshtml"
   Write(Html.Awe().TextBox("txtSearch").Placeholder("search...").CssClass("searchtxt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 11 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\GridCrud.cshtml"
Write(Html.Awe().Button()
          .Text("Create")
          .OnClick(Html.Awe().OpenPopup("createDinnersGrid")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 16 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\GridCrud.cshtml"
Write(Html.Awe().Grid("DinnersGrid")
    .Mod(o => o.ColumnsSelector().ColumnsAutohide().PageInfo())
    .Url(Url.Action("GridGetItems", "DinnersGridCrud"))
    .Parent("txtSearch", "search")
    .Attr("data-syncg", "dinner")
    .Height(350)
    .Columns(
        new Column { Bind = "Id", Width = 55 },
        new Column { Bind = "Name" }.Mod(o => o.Nohide()),
        new Column { Bind = "Date" },
        new Column { Bind = "Chef.FirstName,Chef.LastName", ClientFormat = ".(ChefName)", Header = "Chef" },
        new Column { ClientFormat = ".(Meals)", Header = "Meals" },
        new Column { ClientFormat = Html.EditFormatForGrid("DinnersGrid"), Width = 55 }.Mod(o => o.Nohide()),
        new Column { ClientFormat = Html.DeleteFormatForGrid("DinnersGrid"), Width = 55 }.Mod(o => o.Nohide())));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""tabs code"">
    <div data-caption=""description"" class=""expl"">
        Grid crud, built using the Grid and PopupForm helpers.
        <br />
        There are three PopupForms for create, edit and delete, they are initialized via InitCrudPopupsForGrid custom helper, 
        each PopupForm has Success js function assigned.<br/>
        Create post action returns the grid model for the new Item so the js func will render and append it.<br />
        Edit post action returns the item's Id and the js func is using grid.api.update to update the row (api.update will call GridModelBuilder.GetItem).<br />
        Delete PopupForm has OnLoad js func used to animate the row that is about to be deleted, and the post action will delete the item and return the item's Id,
        the js func will use grid.api.select to select and remove the row, if there's no rows left grid.api.load will be called.
    </div>
    <div data-caption=""view"">");
#nullable restore
#line 43 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\GridCrud.cshtml"
                        Write(Html.Source("Shared/Demos/GridCrud.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div data-caption=\"controller\">");
#nullable restore
#line 44 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\GridCrud.cshtml"
                              Write(Html.Code("Demos/Grid/DinnersGridCrudController.cs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div data-caption=\"create view\">");
#nullable restore
#line 45 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Shared\Demos\GridCrud.cshtml"
                               Write(Html.Source("DinnersGridCrud/Create.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("</div>");
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
