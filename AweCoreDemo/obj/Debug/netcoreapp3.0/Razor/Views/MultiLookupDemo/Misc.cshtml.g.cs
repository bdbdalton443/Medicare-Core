#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\Misc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2a49d843b43a285d4610676b29e8c6197c7866b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MultiLookupDemo_Misc), @"mvc.1.0.view", @"/Views/MultiLookupDemo/Misc.cshtml")]
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
#line 2 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\Misc.cshtml"
using AweCoreDemo.Controllers.Awesome.MultiLookup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\Misc.cshtml"
using AweCoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2a49d843b43a285d4610676b29e8c6197c7866b", @"/Views/MultiLookupDemo/Misc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_MultiLookupDemo_Misc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AweCoreDemo.ViewModels.Input.MultiLookupDemoInput>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\Misc.cshtml"
  
    ViewBag.Title = "MultiLookup Demo Misc";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"example\">\r\n    <h3>MultiLookup Grid</h3>\r\n    <div class=\"efield\">\r\n        <div class=\"elabel\">\r\n            Meal:\r\n        </div>\r\n        <div class=\"einput\">\r\n");
            WriteLiteral("            ");
#nullable restore
#line 16 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\Misc.cshtml"
        Write(Html.Awe().MultiLookupFor(o => o.MealCustomPopup)
                  .MultiLookupGrid(Url.Action("MealMultiLookup"))
                  .Height(500)
                  .Width(500)
                  .Controller("MealsMultiLookup"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <br />\r\n    ");
#nullable restore
#line 26 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\Misc.cshtml"
Write(Html.Awe().Tabs().Add("description", 
item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("MultiLookup with grids inside the popup, done using the MultiLookupGrid mod that also uses PopupUrl extension.");
    PopWriter();
}
), "expl")
        .Add("view", Html.Source("MultiLookupDemo/Misc.cshtml"))
        .Add("multilookup controller", Html.Csource("Awesome/MultiLookup/MealsMultiLookupController.cs"))
        .Add("popup view", Html.Source("MultiLookupDemo/MealMultiLookup.cshtml")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"example\">\r\n    <h3>\r\n        MultiLookup with custom Items Layout\r\n    </h3>\r\n    <div class=\"efield\">\r\n        <div class=\"elabel\">\r\n            Meals:\r\n        </div>\r\n        <div class=\"einput\">\r\n");
            WriteLiteral("            ");
#nullable restore
#line 43 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\Misc.cshtml"
        Write(Html.Awe().MultiLookupFor(o => o.MealsCustomItem)
                  .Controller<MealsCustomItemMultiLookupController>()
                  .Mod(o => o.ShowHeader())
                  .CustomSearch()
                  .Height(700)
                  .HighlightChange());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n    <br />\r\n    ");
#nullable restore
#line 53 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\Misc.cshtml"
Write(Html.Awe().Tabs().Add("view", Html.Source("MultiLookupDemo/Misc.cshtml", "ci"))
                     .Add("controller", Html.Csource("Awesome/MultiLookup/MealsCustomItemMultiLookupController.cs"))
                     .Add("search form view", Html.Source("MealsCustomItemMultiLookup/SearchForm.cshtml"))
                     .Add("items view", Html.Source("MealsCustomItemMultiLookup/Items.cshtml")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"example\">\r\n    <h3>MultiLookup bound to many parents</h3>\r\n    <div class=\"efield\">\r\n        <div class=\"elabel\">\r\n            Parent Categories:\r\n        </div>\r\n        <div class=\"einput\">\r\n            ");
#nullable restore
#line 66 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\Misc.cshtml"
        Write(Html.Awe().MultiLookupFor(o => o.CategoriesData)
                          .Controller<CategoriesMultiLookupController>()
                          .ClearButton());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"efield\">\r\n        <div class=\"elabel\">\r\n            Parent Category:\r\n        </div>\r\n        <div class=\"einput\">\r\n            ");
#nullable restore
#line 76 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\Misc.cshtml"
       Write(Html.Awe().AjaxDropdownFor(o => o.Category).Url(Url.Action("GetCategories", "Data")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"efield\">\r\n        <div class=\"elabel\">\r\n            Child Meals:\r\n        </div>\r\n        <div class=\"einput\">\r\n            ");
#nullable restore
#line 84 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\Misc.cshtml"
        Write(Html.Awe().MultiLookupFor(o => o.ChildOfMany)
              .Parent(o => o.CategoriesData, "categories")
              .Parent(o => o.Category, "categories")
              .Controller<MealsCustomSearchMultiLookupController>()
            );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"example\">\r\n    <h3>Setting predefined parameters</h3>\r\n");
#nullable restore
#line 95 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\Misc.cshtml"
      
        var category1 = Db.Categories[0];
        var category2 = Db.Categories[1];
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"efield\">\r\n        <div class=\"elabel\">\r\n            Meals (categories =\r\n            ");
#nullable restore
#line 102 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\Misc.cshtml"
       Write(category1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("):\r\n        </div>\r\n        <div class=\"einput\">\r\n            ");
#nullable restore
#line 105 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\Misc.cshtml"
        Write(Html.Awe().MultiLookupFor(o => o.Meals2)
                          .Parameter("categories", new[] { category1.Id })
                          .Controller<MealsCustomSearchMultiLookupController>()
                          .ParameterFunc("giveParams"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <script>\r\n        function giveParams() {\r\n            return { categories: ");
#nullable restore
#line 113 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\MultiLookupDemo\Misc.cshtml"
                             Write(category2.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" };\r\n        }\r\n    </script>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AweCoreDemo.ViewModels.Input.MultiLookupDemoInput> Html { get; private set; }
    }
}
#pragma warning restore 1591