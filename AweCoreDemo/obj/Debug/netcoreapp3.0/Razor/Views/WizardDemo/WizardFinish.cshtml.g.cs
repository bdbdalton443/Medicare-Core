#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\WizardDemo\WizardFinish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d5390cbfe3aa639b767c806cd13d7df8d10cb6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WizardDemo_WizardFinish), @"mvc.1.0.view", @"/Views/WizardDemo/WizardFinish.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d5390cbfe3aa639b767c806cd13d7df8d10cb6a", @"/Views/WizardDemo/WizardFinish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_WizardDemo_WizardFinish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AweCoreDemo.ViewModels.Input.Wizard.WizardFinishModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"wizardForm\">\r\n    <div id=\"wizardData\" style=\"height: 250px;\">\r\n");
#nullable restore
#line 4 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\WizardDemo\WizardFinish.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\WizardDemo\WizardFinish.cshtml"
       Write(Html.HiddenFor(o => o.WizardId));

#line default
#line hidden
#nullable disable
            WriteLiteral("Name :");
#nullable restore
#line 7 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\WizardDemo\WizardFinish.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
            WriteLiteral("Category:");
#nullable restore
#line 8 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\WizardDemo\WizardFinish.cshtml"
                              Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
            WriteLiteral("Meals:");
#nullable restore
#line 9 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\WizardDemo\WizardFinish.cshtml"
                            Write(string.Join(",", Model.Meals));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\WizardDemo\WizardFinish.cshtml"
                                                                
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div>\r\n        <div style=\"float: left; margin-right: -100px;\">\r\n");
#nullable restore
#line 15 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\WizardDemo\WizardFinish.cshtml"
             using (Html.BeginForm("WizardStep2", null, new { Model.WizardId }, FormMethod.Get))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"submit\" class=\"awe-btn mbtn\" style=\"width: 100px;\">Go back</button>\r\n");
#nullable restore
#line 18 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\WizardDemo\WizardFinish.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <div style=\"text-align: center;\">\r\n            <button type=\"submit\" class=\"awe-btn mbtn\" onclick=\"$(\'#wizardData form\').submit()\" style=\"width: 100px;\">Finish</button>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AweCoreDemo.ViewModels.Input.Wizard.WizardFinishModel> Html { get; private set; }
    }
}
#pragma warning restore 1591