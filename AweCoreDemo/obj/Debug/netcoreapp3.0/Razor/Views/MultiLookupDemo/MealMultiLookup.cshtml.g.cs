#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\MealMultiLookup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25148e04975a3b502ed56703f311bfb2c79d4168"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MultiLookupDemo_MealMultiLookup), @"mvc.1.0.view", @"/Views/MultiLookupDemo/MealMultiLookup.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25148e04975a3b502ed56703f311bfb2c79d4168", @"/Views/MultiLookupDemo/MealMultiLookup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_MultiLookupDemo_MealMultiLookup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AweCoreDemo.ViewModels.Input.Lookup.LookupPopupInput>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\MealMultiLookup.cshtml"
 using (Html.Awe().BeginContext())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"bar\">\r\n        ");
#nullable restore
#line 5 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\MealMultiLookup.cshtml"
   Write(Html.Awe().TextBoxFor(o => o.Search).Placeholder("search..."));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div style=\"max-width: 900px\">\r\n        ");
#nullable restore
#line 8 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\MealMultiLookup.cshtml"
    Write(Html.Awe().Grid("MealsGrid1")
              .Mod(o => o.PageInfo().KeyNav().MovableRows(x => x.DropOn("MealsGrid1").DropOn("MealsGrid2")))
              .CssClass("awe-srl")
              .Parent(o => o.Search, "name")
              .Columns(
                  new Column { Bind = "Id", Width = 120, ClientFormat = GridUtils.MoveBtn() + " .(Id)"},
                  new Column { Bind = "Name", Width = 150 }.Mod(o => o.Nohide()),
                  new Column { Bind = "Description", CssClass = "txtlim" }.Mod(o => o.Autohide()))
              .Url(Url.Action("MealsGridSearch", "Data"))
              .Groupable(false)
              .Height(350));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 20 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\MealMultiLookup.cshtml"
    Write(Html.Awe().Grid("MealsGrid2")
              .Mod(o => o.PageInfo().KeyNav().MovableRows(x => x.DropOn("MealsGrid1").DropOn("MealsGrid2")))
              .CssClass("awe-sel")
              .Columns(
                  new Column { Bind = "Id", Width = 120, ClientFormat = GridUtils.MoveBtn() + " .(Id)" },
                  new Column { Bind = "Name", Width = 150 }.Mod(o => o.Nohide()),
                  new Column { Bind = "Description", CssClass = "txtlim" }.Mod(o => o.Autohide()))
              .Url(Url.Action("MealsGridSelected", "Data"))
              .Groupable(false)
              .Paging(false)
              .Height(350));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 32 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\MealMultiLookup.cshtml"
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