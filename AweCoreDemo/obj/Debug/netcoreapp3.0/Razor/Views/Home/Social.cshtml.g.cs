#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Home\Social.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f91345781036c4a8e938086d8822ea34fc67918b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Social), @"mvc.1.0.view", @"/Views/Home/Social.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91345781036c4a8e938086d8822ea34fc67918b", @"/Views/Home/Social.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Social : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Home\Social.cshtml"
  
    var url = "https://demo.aspnetawesome.com";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"example\">\r\n    <div class=\"awe-il\" style=\"margin-top: -12px;\">\r\n        <button type=\"button\" class=\"reddit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 176, "\"", 233, 3);
            WriteAttributeValue("", 186, "openw(\'https://www.reddit.com/submit?url=", 186, 41, true);
#nullable restore
#line 6 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Home\Social.cshtml"
WriteAttributeValue("", 227, url, 227, 4, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 231, "\')", 231, 2, true);
            EndWriteAttribute();
            WriteLiteral(">reddit</button>\r\n    </div>\r\n    <a href=\"https://twitter.com/share\" class=\"twitter-share-button\" data-url=\"");
#nullable restore
#line 8 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Home\Social.cshtml"
                                                                          Write(url);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
       data-text=""Awesome Demo"" data-count=""none"" data-hashtags=""aspnetawesome"">Tweet</a>
    <script src=""//platform.linkedin.com/in.js"" type=""text/javascript""></script>
    <div style=""position: relative; width: 59px; height: 20px; display: inline-block;"">
        <div style=""position: absolute;"">
            <script type=""IN/Share"" data-url=""");
#nullable restore
#line 13 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Home\Social.cshtml"
                                         Write(url);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n            </script>\r\n        </div>\r\n    </div>\r\n    <div class=\"awe-il\" style=\"vertical-align: top\">\r\n    <div class=\"fb-share-button\"\r\n         data-href=\"");
#nullable restore
#line 19 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\Home\Social.cshtml"
               Write(url);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
         data-layout=""button"">
    </div>
    <div class=""fb-like""
            data-href=""https://www.facebook.com/aspnetawesome""
            data-layout=""button_count""
            data-action=""like""
            data-show-faces=""false"">
    </div>
    </div>
</div>
<style>
    .fb-share-button, .fb-like {
        vertical-align: top;
    }

    .reddit
    {
        padding: 2px 10px;
        border: 1px solid #5f99cf;
        border-radius: 2px;
        background: #cee3f8;
        cursor: pointer;
        color: #369;
        font-weight: bold;
        font-family: normal x-small verdana, arial, helvetica, sans-serif;
    }
</style>
<div id=""fb-root""></div>
<script>!function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0]; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = ""//platform.twitter.com/widgets.js""; fjs.parentNode.insertBefore(js, fjs); } }(document, ""script"", ""twitter-wjs"");</script>
<script>
    (function (d, s, id) {
        var ");
            WriteLiteral(@"js, fjs = d.getElementsByTagName(s)[0];
        if (d.getElementById(id)) return;
        js = d.createElement(s); js.id = id;
        js.src = ""https://connect.facebook.net/en_US/sdk.js#xfbml=1&version=v3.0"";
        fjs.parentNode.insertBefore(js, fjs);
    }(document, 'script', 'facebook-jssdk'));

    function openw(url) {
        window.open(url);        
    }
</script>");
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
