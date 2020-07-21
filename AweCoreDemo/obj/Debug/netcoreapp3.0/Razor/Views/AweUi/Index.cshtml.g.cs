#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef22f6e7745d88b2066edc712f9856f80c1d86ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AweUi_Index), @"mvc.1.0.view", @"/Views/AweUi/Index.cshtml")]
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
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
using AweCoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef22f6e7745d88b2066edc712f9856f80c1d86ac", @"/Views/AweUi/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_AweUi_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
  
    ViewBag.Title = "aweui.js ui components library";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>aweui.js ui components library</h1>\r\n<p class=\"expl\">\r\n    You can use the awesome controls without the use of server side html helpers by using the aweui.js library.\r\n</p>\r\n<div class=\"example\">\r\n    <h2>Grid remote data</h2>\r\n");
            WriteLiteral(@"    <div class=""bar"">
        <input type=""text"" placeholder=""search..."" id=""txtSearchGrid1"">
    </div>
    <div id=""grid1""></div>
    <script>
        $(function () {
            aweui.grid({
                id: 'grid1',
                dataFunc: getGridData,
                height: 350,
                columns: [
                    { bind: 'Id', width: 75, groupable: false },
                    { bind: 'Person' },
                    { bind: 'Food' },
                    { bind: 'CountryName', header: 'Country' },
                    { bind: 'Date', width: 120,  mod: { nohide: true } },
                    { bind: 'Location' },
                    { bind: ""ChefName"", header: ""Chef"" }
                ],
                parents: [
                    { id: 'txtSearchGrid1', name: 'search' }
                ],
                mod: {
                    pageSize: true,
                    columnsSelector: true,
                    pageInfo: true,
                    loading: true,
");
            WriteLiteral("                    columnsAutohide: true\r\n                }\r\n            });\r\n        });\r\n\r\n        function getGridData(sgp) {\r\n            return $.when($.get(\'");
#nullable restore
#line 45 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
                            Write(Url.Action("LunchesUi", "Data"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', sgp))
                .then(function (res) {
                    var gp = utils.getGridParams(sgp);

                    // build grid model
                    return utils.gridModelBuilder(
                        {
                            key: ""Id"",
                            gp: gp,
                            pageItems: res.items,
                            itemsCount: res.count
                        });
                });
        }
    </script>
");
            WriteLiteral(@"    <br />
    <div class=""tabs"">
        <div class=""expl"" data-caption=""description"">
            In this demo on the server side we query, order the data and select the items for the current page, while on the client we build the grid model.
            The <code>count</code> (total items count) is sent from the server so the grid would know how many pages there are in total.
        </div>
        <div data-caption=""view"">");
#nullable restore
#line 67 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
                            Write(Html.Source("Aweui/Index.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div data-caption=\"controller\">");
#nullable restore
#line 68 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
                                  Write(Html.Code("Awesome/DataController.cs").Action("LunchesUi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"example\">\r\n    <h2>Odropdown</h2>\r\n");
            WriteLiteral("    <input type=\"hidden\" id=\"mealOdd\">\r\n    <br />\r\n    <br />\r\n    <script>\r\n        $(function () {\r\n            aweui.radioList({\r\n                id: \'mealOdd\',\r\n                url: \'");
#nullable restore
#line 82 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
                 Write(Url.Action("GetAllMeals", "Data"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                odropdown: {\r\n                    autoSelectFirst: true\r\n                }\r\n            });\r\n        });\r\n    </script>\r\n");
            WriteLiteral("    <div class=\"tabs code\">\r\n        <div data-caption=\"view\">");
#nullable restore
#line 91 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
                            Write(Html.Source("Aweui/Index.cshtml", "odd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div data-caption=\"controller\">");
#nullable restore
#line 92 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
                                  Write(Html.Code("Awesome/DataController.cs").Action("GetAllMeals"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n<div class=\"example\">\r\n    <h2>RadioList, CheckboxList, Multiselect</h2>\r\n");
            WriteLiteral("    <div class=\"ib arl\">\r\n        <input type=\"hidden\" id=\"rdl1\"");
            BeginWriteAttribute("value", " value=\"", 3497, "\"", 3525, 1);
#nullable restore
#line 99 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
WriteAttributeValue("", 3505, Db.Categories[1].Id, 3505, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"ib arl\">\r\n        <input type=\"hidden\" id=\"chkl1\">\r\n    </div>\r\n    <div class=\"ib arl\">\r\n        <input type=\"hidden\" id=\"multi1\"");
            BeginWriteAttribute("value", " value=\"", 3687, "\"", 3739, 5);
            WriteAttributeValue("", 3695, "[", 3695, 1, true);
#nullable restore
#line 105 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
WriteAttributeValue("", 3696, Db.Categories[1].Id, 3696, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3716, ",", 3716, 1, true);
#nullable restore
#line 105 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
WriteAttributeValue(" ", 3717, Db.Categories[2].Id, 3718, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3738, "]", 3738, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n\r\n    <script>\r\n        $(function() {\r\n            aweui.radioList({\r\n                id: \'rdl1\',\r\n                //url: \'");
#nullable restore
#line 112 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
                   Write(Url.Action("GetCategories", "Data"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                dataFunc: getCategories,
                ochk: true
            });

            aweui.checkboxList({
                id: 'chkl1',
                dataFunc: getCategories,
                ochk: true
            });

            aweui.checkboxList({
                id: 'multi1',
                dataFunc: getCategories,
                multiselect: true
            });

            var loadedItems = null;

            function getCategories() {
                if (!loadedItems) {
                    loadedItems = $.when($.get('");
#nullable restore
#line 133 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
                                           Write(Url.Action("GetCategories", "Data"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'))
                        .then(function(res) {
                            loadedItems = res;
                            return res;
                        });
                }

                return loadedItems;
            }
        });
    </script>
");
            WriteLiteral("    <div class=\"tabs code\">\r\n        <div data-caption=\"view\">");
#nullable restore
#line 146 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
                            Write(Html.Source("Aweui/Index.cshtml", "rdl"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div data-caption=\"controller\">");
#nullable restore
#line 147 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
                                  Write(Html.Code("Awesome/DataController.cs").Action("GetCategories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n<div class=\"example\">\r\n    <h2>Checkbox</h2>\r\n");
            WriteLiteral(@"    <label>ochk: <input type=""hidden"" id=""chk1"" value=""true""></label>
    <label>otoggl: <input type=""hidden"" id=""toggl1"" name=""toggl1"" value=""true""></label>
    <script>
        $(function () {
            aweui.chk({ id: 'chk1', ochk: true });
            aweui.chk({ id: 'toggl1', otoggl: true });
        });
    </script>
");
            WriteLiteral("    <div class=\"tabs code\">\r\n        <div data-caption=\"view\">");
#nullable restore
#line 163 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
                            Write(Html.Source("Aweui/Index.cshtml", "chk"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"example\">\r\n    <h2>Textbox</h2>\r\n");
            WriteLiteral(@"    <input type=""hidden"" id=""txt1"" value=""10"" />
    <script>
        $(function() {
            aweui.txt({
                id: 'txt1',
                numeric: {
                    max: 100
                }
            });
        });
    </script>
");
            WriteLiteral("    <div class=\"tabs code\">\r\n        <div data-caption=\"view\">");
#nullable restore
#line 183 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
                            Write(Html.Source("Aweui/Index.cshtml", "txt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n<div class=\"example\">\r\n    <h2>Popups</h2>\r\n");
            WriteLiteral(@"    <script>
        $(function() {
            aweui.initPopupForm({
                id: 'popupForm1',
                height: 200,
                setCont: function(sp, o) {
                    var str = '<form>' +
                        'name: <input type=""text"" name=""name"" />' +
                        '</form>';
                    o.scon.html(str);
                },
                postFunc: function(sp) {
                    var prm = utils.getParams(sp);
                    return { name: prm.name };
                },
                success: function(res) {
                    awem.notif('name = ' + res.name);
                }
            });
        });
    </script>
    <button type=""button"" class=""awe-btn"" onclick=""aweui.open('popupForm1', {}, event)"">open PopupForm</button>
");
            WriteLiteral("    <div class=\"tabs code\">\r\n        <div data-caption=\"view\">");
#nullable restore
#line 213 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
                            Write(Html.Source("Aweui/Index.cshtml", "pf"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral(@"<button type=""button"" class=""awe-btn"" id=""btnFrench"" onclick=""goFrench()"">change aweui to French</button>
<script>
    function goFrench() {
        $.ajax(document.root + '/js/awedict/awedict.fr.js',
            {
                dataType: ""script"",
                cache: true,
                success: function () {
                    aweui.init();
                    aweui.rebuildAll();
                }
            });
    }
</script>
");
            WriteLiteral("<div class=\"tabs code\">\r\n    <div data-caption=\"view\">");
#nullable restore
#line 234 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\AweUi\Index.cshtml"
                        Write(Html.Source("Aweui/Index.cshtml", "chl"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>\r\n<br />\r\n<br />\r\n<p>\r\n    For more aweui demos visit <a href=\"https://aweui.aspnetawesome.com\">aweui.aspnetawesome.com</a>\r\n</p>");
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