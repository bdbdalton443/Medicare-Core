#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCheckboxesDemo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6506c61ebda3e1449f5b0389396ccf3187dd7aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GridCheckboxesDemo_Index), @"mvc.1.0.view", @"/Views/GridCheckboxesDemo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6506c61ebda3e1449f5b0389396ccf3187dd7aa", @"/Views/GridCheckboxesDemo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_GridCheckboxesDemo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCheckboxesDemo\Index.cshtml"
  
    ViewBag.Title = "Grid with checkboxes on each row, and in header to check/uncheck all";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"example\">\r\n    <h2>Grid with checkboxes</h2>\r\n");
            WriteLiteral("    ");
#nullable restore
#line 7 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCheckboxesDemo\Index.cshtml"
Write(Html.Awe().Grid("GridChk")
          .PageSize(7)
          .Columns(
              new Column
              {
                  Width = 40,
                  ClientFormat = Html.Awe().CheckBox("Id")
                                    .Ochk()
                                    .Prefix("c.Id")
                                    .HtmlAttributes(null, new { data_val = ".Id" })
                                    .ToString(),
                  Header = Html.Awe().CheckBox("ChkAll").Ochk().SyncScript().ToString()
              },
              new Column { Bind = "Person" },
              new Column { Bind = "Food" },
              new Column { Bind = "Location" })
          .Url(Url.Action("GetItems", "LunchGrid")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <br />
    <button class=""awe-btn"" id='btnGetSelection1'>get selection</button>
    <span id=""log1""></span>
    <script>
        $(function () {
            gridCheckboxes('GridChk');

            // get selection
            $('#btnGetSelection1').click(function () {
                var arr = $('#GridChk [name=Id]').filter(function () {
                    return $(this).val() == 'true';
                }).map(function () {
                    return $(this).data('val');
                }).get();

                $('#log1').html(JSON.stringify(arr));
            });
        });

        function gridCheckboxes(gridId) {
            // select/unselect all
            var $grid = $('#' + gridId);
            $grid.on('change', '#ChkAll', function () {
                $grid.find('[name=Id]').val($(this).val()).change();
            });
        }
    </script>
");
            WriteLiteral("    <div class=\"code\">\r\n        ");
#nullable restore
#line 53 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCheckboxesDemo\Index.cshtml"
   Write(Html.Source("GridCheckboxesDemo/Index.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"example\">\r\n    <h2>Grid with checkboxes that persist state when paging</h2>\r\n");
            WriteLiteral("    ");
#nullable restore
#line 60 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCheckboxesDemo\Index.cshtml"
Write(Html.Awe().Grid("GridChkPersistent")
        .Columns(
            new Column
            {
                Width = 40,
                ClientFormat = Html.Awe().CheckBox("Id")
                                .Ochk()
                                .Prefix("cpers.Id")
                                .SyncScript()
                                .HtmlAttributes(null, new { data_val = ".Id" })
                                .ToString(),
                Header = Html.Awe().CheckBox("ChkAll").Ochk().Prefix("pers").SyncScript().ToString()
            },
            new Column { Bind = "Person" },
            new Column { Bind = "Food" },
            new Column { Bind = "Location" })
        .PageSize(7)
        .Url(Url.Action("GetItems", "LunchGrid")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <br />
    <button class=""awe-btn"" id='btnGetSelection'>get page selection</button>
    <button class=""awe-btn"" id='btnGetAllSelection'>get selection (all pages)</button>
    <span id=""log""></span>

    <script>
        $(function () {
            gridPersistentCheckboxes(""GridChkPersistent"", ""Id"");

            // get selection
            $('#btnGetSelection').click(function () {
                var arr = $('#GridChkPersistent [name=Id]').filter(function () {
                    return $(this).val() == 'true';
                }).map(function () {
                    return $(this).data('val');
                }).get();

                $('#log').html(JSON.stringify(arr));
            });

            // get all selection (including checkboxes on other pages)
            $('#btnGetAllSelection').click(function () {
                var checks = $('#GridChkPersistent').data('checks');
                var keys = [];
                for (var k in checks) {
                    key");
            WriteLiteral(@"s.push(k);
                }

                $('#log').html(JSON.stringify(keys));
            });
        });

        function gridPersistentCheckboxes(gridId, chkName) {
            var sel = '[name=' + chkName + ']';
            var allSel = '[name=ChkAll]';
            $(document).on('aweload', '#' + gridId, function () {
                var $grid = $(this);
                var checks = $grid.data('checks');
                var allChecked = false;
                if (checks) {
                    allChecked = true;
                    $grid.find('.awe-row').each(function () {
                        if (checks[$(this).data('k')]) {
                            $(this).find(sel).val(true).data('api').render();
                        } else {
                            allChecked = false;
                        }
                    });
                } else {
                    $grid.data('checks', {});
                }

                $grid.find(allSel).val(allChecked).d");
            WriteLiteral(@"ata('api').render();
            });

            // check/uncheck all
            $(document).on('change', '#' + gridId + ' ' + allSel, function () {
                var val = $(this).val();
                var isChecked = val == 'true';
                var $grid = $(this).closest('.awe-grid');
                var checks = $grid.data('checks');

                $grid.find('.awe-row').each(function () {
                    var $row = $(this);
                    $row.find(sel).val(val).data('api').render();
                    if (isChecked) checks[$row.data('k')] = 1;
                    else delete checks[$row.data('k')];
                });

                $grid.data('checks', checks);
            });

            $(document).on('change', '#' + gridId + ' ' + sel, function () {
                var $this = $(this);
                var $grid = $this.closest('.awe-grid');
                var checks = $grid.data('checks');
                var isChecked = $this.val() == 'true';
       ");
            WriteLiteral("         var key = $this.closest(\'.awe-row\').data(\'k\');\r\n                if (isChecked) checks[key] = 1;\r\n                else delete checks[key];\r\n                $grid.data(\'checks\', checks);\r\n            });\r\n        }\r\n\r\n    </script>\r\n");
            WriteLiteral("    <div class=\"code\">\r\n        ");
#nullable restore
#line 166 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCheckboxesDemo\Index.cshtml"
   Write(Html.Source("GridCheckboxesDemo/Index.cshtml", "pers"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"example\">\r\n    <h2>Grid with checkboxes, simple checkbox</h2>\r\n");
            WriteLiteral("    ");
#nullable restore
#line 173 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCheckboxesDemo\Index.cshtml"
Write(Html.Awe().Grid("GridChksc")
        .PageSize(5)
        .Columns(
            new Column
            {
                Width = 40,
                ClientFormat = "<input type='checkbox' name='id' value='.Id'/>",
                Header = "<input type='checkbox' name='chkAll' />"
            },
            new Column { Bind = "Person" },
            new Column { Bind = "Food" },
            new Column { Bind = "Location" })
        .Url(Url.Action("GetItems", "LunchGrid")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <br />
    <button class=""awe-btn"" id='btnGetSelection1sc'>get selection</button>
    <span id=""log1sc""></span>

    <script>
        $(function () {
            gridCheckboxesSc('GridChksc');

            //get selection
            $('#btnGetSelection1sc').click(function () {
                var arr = $('#GridChksc [name=id]:checked').map(function () {
                    return $(this).val();
                }).get();

                $('#log1sc').html(JSON.stringify(arr));
            });
        });

        function gridCheckboxesSc(gridId) {
            //select/unselect all
            var $grid = $('#' + gridId);
            $grid.on('click', '[name=chkAll]', function () {
                var isChecked = $(this).prop('checked');
                $grid.find('[name=id]').prop('checked', isChecked);
            });
        }
    </script>
    <style>
        input[type=checkbox] {
            zoom: 1.3;
            margin: 0;
            vertical-align: middle;
   ");
            WriteLiteral("     }\r\n    </style>\r\n");
            WriteLiteral("    <div class=\"code\">\r\n        ");
#nullable restore
#line 223 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCheckboxesDemo\Index.cshtml"
   Write(Html.Source("GridCheckboxesDemo/Index.cshtml", "sc"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"example\">\r\n    <h2>Tree grid with checkboxes</h2>\r\n");
            WriteLiteral("    ");
#nullable restore
#line 230 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCheckboxesDemo\Index.cshtml"
Write(Html.Awe().Grid("TreeGrid1")
        .Url(Url.Action("SimpleTree", "TreeGrid"))
        .Columns(
            new Column { Bind = "Name", ClientFormat = "<input class='awe-nonceb' type='checkbox' name='id' value='.Id'/> .Name" },
            new Column { Bind = "Id", Width = 100 })
        .Persistence(Persistence.View)
        .Groupable(false)
        .PageSize(3)
        .Height(400));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <br />
    <button class=""awe-btn"" id='btnGetSelectionTree'>get selection</button>
    <span id=""logtree""></span>

    <script>
        $(function () {
            //get selection
            $('#btnGetSelectionTree')
                .click(function () {
                    var arr = $('#TreeGrid1 [name=id]:checked')
                        .map(function () {
                            return $(this).val();
                        })
                        .get();

                    $('#logtree').html(JSON.stringify(arr));
                });
        });
    </script>
");
            WriteLiteral("    <div class=\"code\">\r\n        ");
#nullable restore
#line 261 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\GridCheckboxesDemo\Index.cshtml"
   Write(Html.Source("GridCheckboxesDemo/Index.cshtml", "tree"));

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
