#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\CrudInLookup\DinnerLookup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "631be28b62d90053d88d4f9cb9dca87d83cdd3c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CrudInLookup_DinnerLookup), @"mvc.1.0.view", @"/Views/CrudInLookup/DinnerLookup.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"631be28b62d90053d88d4f9cb9dca87d83cdd3c3", @"/Views/CrudInLookup/DinnerLookup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_CrudInLookup_DinnerLookup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AweCoreDemo.ViewModels.Input.Lookup.LookupPopupInput>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\CrudInLookup\DinnerLookup.cshtml"
 using (Html.Awe().BeginContext())
{
    var gridId = "DinnersGrid";

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\CrudInLookup\DinnerLookup.cshtml"
Write(Html.InitCrudPopupsForGrid(gridId, "DinnersGridCrud"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"bar\">\r\n        <div style=\"float: right;\">\r\n            ");
#nullable restore
#line 10 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\CrudInLookup\DinnerLookup.cshtml"
       Write(Html.Awe().TextBoxFor(o => o.Search).Placeholder("search...").CssClass("searchtxt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        ");
#nullable restore
#line 12 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\CrudInLookup\DinnerLookup.cshtml"
   Write(Html.CreateButtonForGrid(gridId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 15 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\CrudInLookup\DinnerLookup.cshtml"
Write(Html.Awe().Grid(gridId)
      .Mod(o => o.PageInfo().ColumnsSelector().KeyNav().ColumnsAutohide())
      .Url(Url.Action("GridGetItems", "DinnersGridCrud"))
      .Parent(o => o.Search, "search")
      .Selectable(SelectionType.Single)
      .Height(350)
      .Columns(
          new Column { Bind = "Id", Width = 55 },
          new Column { Bind = "Name" },
          new Column { Bind = "Date" },
          new Column { Bind = "Chef.FirstName,Chef.LastName", ClientFormat = ".ChefName", Header = "Chef" },
          new Column { ClientFormat = ".Meals", Header = "Meals" },
          new Column { ClientFormat = Html.EditFormatForGrid(gridId, nofocus: true), Width = 50 }.Mod(o => o.Nohide()),
          new Column { ClientFormat = Html.DeleteFormatForGrid(gridId, nofocus: true), Width = 50 }.Mod(o => o.Nohide())));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\CrudInLookup\DinnerLookup.cshtml"
                                                                                                                          
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AweCoreDemo.ViewModels.Input.Lookup.LookupPopupInput> Html { get; private set; }
    }
}
#pragma warning restore 1591
