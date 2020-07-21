#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\WizardDemo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28625d7b808b2e9e97c7292847e0939348675b27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WizardDemo_Index), @"mvc.1.0.view", @"/Views/WizardDemo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28625d7b808b2e9e97c7292847e0939348675b27", @"/Views/WizardDemo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_WizardDemo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\WizardDemo\Index.cshtml"
  
    ViewBag.Title = "Wizard built using PopupForm";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Wizard Demo</h1>\r\n");
#nullable restore
#line 6 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\WizardDemo\Index.cshtml"
Write(Html.Awe().InitPopupForm()
        .Name("wizard1")
        .Url(Url.Action("StartWizard"))
        .Success("wizardFinish")
        .UseDefaultButtons(false)
        .Modal());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<button type=""button"" onclick=""awe.open('wizard1')"" class=""awe-btn mbtn"">click here to start wizard</button>
<br />
<br />

<script type=""text/javascript"">
    function wizardFinish(res) {
        awe.flash(awem.notif(res.Message));
    }
</script>
");
            WriteLiteral(@"
<div class=""tabs"">
    <div data-caption=""description"" class=""expl"">
        <p>
            In this demo a Wizard is built using the PopupForm helper. 
        We're not using the default Ok and Cancel buttons instead a submit button is placed on the bottom center of the form.
        <br />
            Stepping forward is done by submitting the form, the successful submit will redirect to another action which will return a view (html), 
        when the popupform receives html/string it replaces its content with that html.<br />
            Stepping back is performed by submitting a separate form to the needed step, the form uses method get.
        (The popup form will handle any form that is being submitted inside of it, and make it an ajax request).<br />
        </p>
    </div>
    <div data-caption=""view"">");
#nullable restore
#line 35 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\WizardDemo\Index.cshtml"
                        Write(Html.Source("WizardDemo/Index.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div data-caption=\"controller\">");
#nullable restore
#line 36 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\WizardDemo\Index.cshtml"
                              Write(Html.Csource("Demos/Misc/WizardDemoController.cs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div data-caption=\"step1 view\">");
#nullable restore
#line 37 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\WizardDemo\Index.cshtml"
                              Write(Html.Source("WizardDemo/WizardStep1.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div data-caption=\"step2 view\">");
#nullable restore
#line 38 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\WizardDemo\Index.cshtml"
                              Write(Html.Source("WizardDemo/WizardStep2.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div data-caption=\"finish view\">");
#nullable restore
#line 39 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\WizardDemo\Index.cshtml"
                               Write(Html.Source("WizardDemo/WizardFinish.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>");
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