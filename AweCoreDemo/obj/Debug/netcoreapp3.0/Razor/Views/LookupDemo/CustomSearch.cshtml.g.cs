#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\LookupDemo\CustomSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c248f120d5c37acca6530d1e2612019080d6864"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LookupDemo_CustomSearch), @"mvc.1.0.view", @"/Views/LookupDemo/CustomSearch.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c248f120d5c37acca6530d1e2612019080d6864", @"/Views/LookupDemo/CustomSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_LookupDemo_CustomSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\LookupDemo\CustomSearch.cshtml"
  
    ViewBag.Title = "Lookup Custom Search Demo";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Lookup with Custom Search </h1>\r\n<div class=\"efield\">\r\n    <div class=\"elabel\">\r\n        Meal:\r\n    </div>\r\n    <div class=\"einput\">\r\n");
            WriteLiteral("        ");
#nullable restore
#line 11 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\LookupDemo\CustomSearch.cshtml"
   Write(Html.Awe().Lookup("MealCustomSearch").CustomSearch());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"    </div>
</div>
<br />
<div class=""expl"">
    Custom search is achieved by setting <code>.CustomSearch(true)</code> and adding a <code>SearchForm</code> action
    in the Lookup controller which will render the custom SearchForm view
</div>
<br />
<br />
<div class=""tabs"">
    <div data-caption=""view"">
        ");
#nullable restore
#line 24 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\LookupDemo\CustomSearch.cshtml"
   Write(Html.Source("LookupDemo/CustomSearch.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div data-caption=\"lookup controller\">\r\n        ");
#nullable restore
#line 27 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\LookupDemo\CustomSearch.cshtml"
   Write(Html.Csource("Awesome/Lookup/MealCustomSearchLookupController.cs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div data-caption=\"SearchForm view\">\r\n        ");
#nullable restore
#line 30 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\LookupDemo\CustomSearch.cshtml"
   Write(Html.Source("MealCustomSearchLookup/SearchForm.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
