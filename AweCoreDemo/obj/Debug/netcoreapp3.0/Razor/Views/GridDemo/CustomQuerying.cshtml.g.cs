#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\CustomQuerying.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be27825ab037a470a9b0463a2b61c782cdd101b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GridDemo_CustomQuerying), @"mvc.1.0.view", @"/Views/GridDemo/CustomQuerying.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be27825ab037a470a9b0463a2b61c782cdd101b9", @"/Views/GridDemo/CustomQuerying.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_GridDemo_CustomQuerying : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\CustomQuerying.cshtml"
  
    ViewBag.Title = "Grid control with Custom data querying for Sorting, Grouping and Paging";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Grid custom querying</h1>
<div class=""expl"">
    By default the GridModelBuilder will query the data (order and get page), but you can to that yourself and pass the ordered and paged data. 
    You might need to do that if you're using stored procedures, service calls, or any other data storage tech that doesn't support linq.
    <br />
    You might also want to load the data using <code>async/await</code> methods and only after that pass it to the GridModelBuilder, 
    and for this scenario the GridModelBuilder has methods to apply the OrderBy and Page on your query before you call your Async Load method, see examples below.
</div>
<div class=""example"">
    <h2>Manually ordering and paging data</h2>
");
            WriteLiteral("    ");
#nullable restore
#line 15 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\CustomQuerying.cshtml"
Write(Html.Awe().Grid("CustomQueryingGrid")
    .Url(Url.Action("GetItems", "CustomQueryingGrid"))
    .Height(300)
    .Columns(
    new Column { Bind = "Id", Groupable = false, Sortable = false, Width = 70 },
    new Column { Bind = "Person" },
    new Column { Bind = "Food" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"    <br />
    <div class=""tabs"">
        <div data-caption=""description"" class=""expl"">
            Here we are showing how we could query the data manually before passing it to the GridModelBuilder.
            One could also use something like Dynamic Linq or generate a sql script etc.
        </div>
        <div data-caption=""view"">");
#nullable restore
#line 29 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\CustomQuerying.cshtml"
                            Write(Html.Source("GridDemo/CustomQuerying.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div data-caption=\"controller\">");
#nullable restore
#line 30 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\CustomQuerying.cshtml"
                                  Write(Html.Code("Demos/Grid/CustomQueryingGridController.cs").Action("GetItems"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n<div class=\"example\">\r\n    <h2>Execute async query before building model</h2>\r\n");
            WriteLiteral("    ");
#nullable restore
#line 36 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\CustomQuerying.cshtml"
Write(Html.Awe().Grid("GridQuery2")
      .Url(Url.Action("GetEfAsyncItems", "CustomQueryingGrid"))
      .Height(300)
      .Columns(
          new Column { Bind = "Id", Groupable = false, Sortable = false, Width = 70 },
          new Column { Bind = "Person" },
          new Column { Bind = "Food" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"    <br />
    <div class=""tabs"">
        <div data-caption=""description"" class=""expl"">
            In this grid we are fetching the data before calling <code>GridModelBuilder.Build</code>, this way you could use an async call to fetch data,
            await for the call and after pass the items and count to the GridModelBuilder.
        </div>
        <div data-caption=""view"">");
#nullable restore
#line 50 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\CustomQuerying.cshtml"
                            Write(Html.Source("GridDemo/CustomQuerying.cshtml", 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div data-caption=\"controller\">");
#nullable restore
#line 51 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridDemo\CustomQuerying.cshtml"
                                  Write(Html.Code("Demos/Grid/CustomQueryingGridController.cs").Action("GetEfAsyncItems"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>");
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
