#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41f694dfe49d00a0b269ab23a60856bb35236e95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PopupFormDemo_Index), @"mvc.1.0.view", @"/Views/PopupFormDemo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f694dfe49d00a0b269ab23a60856bb35236e95", @"/Views/PopupFormDemo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_PopupFormDemo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
  
    ViewBag.Title = "ASP.net MVC Awesome Popup Form Demos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>PopupForm - used to load and post a form in a popup</h1>
<div class=""expl"">
    It can be initialized using <code>Html.Awe().InitPopupForm</code> and opened using <code>awe.open</code> js function or <code>Html.Awe().OpenPopup</code> helper.
    It loads the content from the <code>.Url(string)</code> provided and when the user clicks ok, the form will be posted, if the result of the post is view/string (usually when ModelState not valid) the content of the popup will be replaced with the post result,
    when the result is a json object the popup will close, if the PopupForm has a success function defined the json object will be passed that function.
</div>
<br/>
You can see the PopupForm being used in all of the Crud demos (<a");
            BeginWriteAttribute("href", " href=\"", 816, "\"", 859, 1);
#nullable restore
#line 11 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
WriteAttributeValue("", 823, Url.Action("Index", "GridCrudDemo"), 823, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Grid</a>, <a");
            BeginWriteAttribute("href", " href=\"", 873, "\"", 911, 1);
#nullable restore
#line 11 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
WriteAttributeValue("", 880, Url.Action("Index", "Dinners"), 880, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">AjaxList</a>), \r\nalso in the <a");
            BeginWriteAttribute("href", " href=\"", 944, "\"", 984, 1);
#nullable restore
#line 12 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
WriteAttributeValue("", 951, Url.Action("Index","WizardDemo"), 951, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Wizard Demo</a>. 
In most Crud demos the call to Html.Awe().InitPopupForm is being wrapped in a custom helper Html.InitCrudPopupsForGrid which calls this helper multiple times (for Create, Edit, Delete).

<div class=""example"">
    <h2>PopupForm with Success function assigned</h2>
");
            WriteLiteral("    ");
#nullable restore
#line 18 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
Write(Html.Awe().InitPopupForm()
          .Name("createDinner")
          .Height(400)
          .Url(Url.Action("Create", "DinnersGridCrud"))
          .Success("created"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 24 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
Write(Html.Awe().Button().Text("Create").OnClick(Html.Awe().OpenPopup("createDinner")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        function created(result, popup) {\r\n            alert(\'dinner created\');\r\n        }\r\n    </script>\r\n");
            WriteLiteral("\r\n    <div class=\"tabs code\">\r\n        <div data-caption=\"view\">");
#nullable restore
#line 34 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
                            Write(Html.Source("PopupFormDemo/Index.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div data-caption=\"controller\">");
#nullable restore
#line 35 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
                                  Write(Html.Code("Demos/Grid/DinnersGridCrudController.cs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div data-caption=\"popup view\">");
#nullable restore
#line 36 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
                                  Write(Html.Source("DinnersGridCrud/Create.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
    </div>
</div>
<div class=""example"">
    <h2>Sending client side parameters to server on content load</h2>

    Value sent to the server action that returns the popup's content:
    <input type=""text"" id=""txtParam1"" value=""textbox text xyz"" />
    <br />

");
            WriteLiteral("\r\n    ");
#nullable restore
#line 48 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
Write(Html.Awe().InitPopupForm()
          .Name("PopupFormParams")
          .Url(Url.Action("PopupWithParameters"))
          .Button("Help", "helpClick")
          .Parent("txtParam1")
          .Parameter("p1", 15)
          .ParameterFunc("setParams"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 56 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
Write(Html.Awe().Button().Text("Open Popup")
          .OnClick(Html.Awe().OpenPopup("PopupFormParams").Params(new { Id = 123 })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <script>\r\n        function setParams() {\r\n            return { a: \"hi\", b: \"how are you\" };\r\n        }\r\n\r\n        function helpClick() {\r\n            awe.flash($(this).find(\'.msg1\').html(\'help clicked\'));\r\n        }\r\n    </script>\r\n");
            WriteLiteral("    <div class=\"code tabs\">\r\n        <div data-caption=\"view\">");
#nullable restore
#line 70 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
                            Write(Html.Source("PopupFormDemo/Index.cshtml", "4"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div data-caption=\"controller\">");
#nullable restore
#line 71 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
                                  Write(Html.Csource("Demos/Helpers/PopupFormDemoController.cs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div data-caption=\"popup view\">");
#nullable restore
#line 72 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
                                  Write(Html.Source("PopupFormDemo/PopupWithParameters.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n<div class=\"example\">\r\n    <h2>Submit confirmation using OnLoad func</h2>\r\n");
            WriteLiteral("    ");
#nullable restore
#line 78 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
Write(Html.Awe().InitPopupForm()
          .Name("confirmedPopup")
          .Height(200)
          .Url(Url.Action("PopupConfirm"))
          .UseDefaultButtons(true)
          .OnLoad("regConfirm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 85 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
Write(Html.Awe().Button().Text("Open popup").OnClick(Html.Awe().OpenPopup("confirmedPopup")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <script>
        function regConfirm() {
            var $popup = this.p.d;
            var $form = $popup.find('form');
            $form.on('submit', function (e) {
                if (!$form.valid() || !confirm(""Are you sure ?"")) {
                    return false;
                }
            });
        }
    </script>
");
            WriteLiteral("    <div class=\"code tabs\">\r\n        <div data-caption=\"view\">");
#nullable restore
#line 100 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
                            Write(Html.Source("PopupFormDemo/Index.cshtml", "cs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"example\">\r\n    <h2>Confirm close</h2>\r\n");
            WriteLiteral("    ");
#nullable restore
#line 107 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
Write(Html.Awe().InitPopupForm()
          .Name("confirmClosePopup")
          .Height(200)
          .PopupClass("needConfirm")
          .Success("logConfClose")
          .Url(Url.Action("PopupConfirm")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 114 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
Write(Html.Awe().Button().Text("Open confirm close popup").OnClick(Html.Awe().OpenPopup("confirmClosePopup")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div id=""logConfClose""></div>
    <script>
        function logConfClose(res) {
            $('#logConfClose').html(res.Name);
        }

        $(document).on('awebfclose', function(e, opt) {
            var pdiv = $(e.target);
            
            // opt.post = close popup after successful form post
            if (!pdiv.closest('.needConfirm').length || opt.post || opt.force) return;
            opt.noclose = true;

            var pp = pdiv.data('o').p;
            aweui.initPopup({
                id: 'confirmClose',
                title: 'Confirm close',
                content: 'Are you sure you want to close this popup ?',
                height: 200,
                width: 500,
                modal: true,
                btns: [
                    {
                        text: ""Yes"",
                        action: function () {
                            $(this).data('api').close();
                            pp.api.close({ force: true });
               ");
            WriteLiteral(@"         }
                    },
                    {
                        text: ""No"",
                        action: function () {
                            $(this).data('api').close();
                        }
                    }
                ]
            });

            awe.open('confirmClose');
        });
    </script>
");
            WriteLiteral("    <div class=\"code tabs\">\r\n        <div data-caption=\"view\">");
#nullable restore
#line 158 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
                            Write(Html.Source("PopupFormDemo/Index.cshtml", "cc"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n<p>\r\n    Note: besides the features shown on this page the PopupForm also inherits the features of the <a");
            BeginWriteAttribute("href", " href=\"", 6227, "\"", 6266, 1);
#nullable restore
#line 162 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\PopupFormDemo\Index.cshtml"
WriteAttributeValue("", 6234, Url.Action("Index","PopupDemo"), 6234, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Popup</a>\r\n</p>");
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
