#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7cfbaa3c83388ee44c30ccf566badf10d9d46f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TreeGrid_Index), @"mvc.1.0.view", @"/Views/TreeGrid/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7cfbaa3c83388ee44c30ccf566badf10d9d46f4", @"/Views/TreeGrid/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_TreeGrid_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
  
    ViewBag.Title = "Tree Grid";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Tree Grid</h1>
<div class=""expl"">
    <p>
        Tree grid is achieved by setting the <code>GridModelBuilder.GetChildren</code>,
        this function should return an <code>IQueryable&lt;T&gt;</code> when the item is a node, or an <code>Awe.Lazy</code> when it is a lazy node.
    </p>
    <p>
        For lazy loading <code>GridModelBuilder.GetItem</code> also needs to be set, it will be executed in the lazy request, GetItem is also used by the api.updateItem.
        In the constructor of the <code>GridModelBuilder</code> collection of only the root items are passed.
    </p>
</div>

<div class=""example"">
    <h3>Tree grid, basic features</h3>
    simple tree grid, without lazy loading
");
            WriteLiteral("    ");
#nullable restore
#line 21 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
Write(Html.Awe().Grid("TreeGrid1")
          .Url(Url.Action("SimpleTree", "TreeGrid"))
          .Columns(
              new Column { Bind = "Name" },
              new Column { Bind = "Id", Width = 100 })
          .Persistence(Persistence.View)
          .Groupable(false)
          .PageSize(3)
          .Height(400));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <div class=\"tabs code\">\r\n        <div data-caption=\"view\">");
#nullable restore
#line 33 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
                            Write(Html.Source("TreeGrid/Index.cshtml", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div data-caption=\"controller\">");
#nullable restore
#line 34 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
                                  Write(Html.Code("Demos/Grid/TreeGridController.cs").Action("SimpleTree"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n<div class=\"example\">\r\n    <h3>Lazy loading Nodes, Tree Grid</h3>\r\n");
            WriteLiteral("    ");
#nullable restore
#line 40 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
Write(Html.Awe().Grid("LazyTreeGrid")
          .Url(Url.Action("LazyTree", "TreeGrid"))
          .Columns(
              new Column { Bind = "Name" },
              new Column { Bind = "Id", Width = 100 })
          .Persistence(Persistence.View)
          .ColumnsPersistence(Persistence.Session)
          .PageSize(3)
          .Height(400));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <div class=\"tabs code\">\r\n        <div data-caption=\"view\">");
#nullable restore
#line 52 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
                            Write(Html.Source("TreeGrid/Index.cshtml", 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div data-caption=\"controller\">");
#nullable restore
#line 53 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
                                  Write(Html.Code("Demos/Grid/TreeGridController.cs").Action("LazyTree"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n<div class=\"example\">\r\n    <h3>Tree Grid with CRUD operations</h3>\r\n\r\n");
#nullable restore
#line 60 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
      
        var crudgrid = "CrudTreeGrid";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
#nullable restore
#line 63 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
Write(Html.Awe().InitPopupForm()
          .Name("createNode")
          .Height(200)
          .Group("tree")
          .Url(Url.Action("Create", "TreeGrid"))
          .Success("nodeCreated"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 70 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
Write(Html.Awe().InitPopupForm()
          .Name("editNode")
          .Height(200)
          .Group("tree")
          .Url(Url.Action("Edit", "TreeGrid"))
          .Success("nodeUpdated"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 77 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
Write(Html.Awe().InitPopupForm()
          .Name("deleteNode")
          .Height(200)
          .Modal()
          .Group("tree")
          .Url(Url.Action("Delete", "TreeGrid"))
          .Success("nodeDeleted")
          .OnLoad("utils.delConfirmLoad('CrudTreeGrid')")
          .Parameter("gridId", crudgrid));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <script>
        // needed to handle crud when search criteria is present
        // (e.g. if you add a child and update the node it might not show up because of the search criteria)
        var nodesAdded = [];
        $(function () {
            var $grid = $('#");
#nullable restore
#line 92 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
                        Write(crudgrid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n            $grid.on(\'aweload\', function () {\r\n                nodesAdded = [];\r\n            });\r\n        });\r\n\r\n        function nodeCreated(res) {\r\n            var $grid = $(\'#");
#nullable restore
#line 99 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
                        Write(crudgrid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');
            nodesAdded.push(res.Node.Id);

            //update parent if present of reload the grid with empty sorting and grouping rules
            if (res.ParentId) {
                var xhr = $grid.data('api').update(res.ParentId, { nodesAdded: nodesAdded });
                $.when(xhr).done(function () {
                    if (res.Node) {
                        awe.flash($(""#");
#nullable restore
#line 107 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
                                  Write(crudgrid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""").data('api').select(res.Node.Id)[0]);
                    }
                });
            } else {
                var row = $grid.data('api').renderRow(res.Node, 1);// render row as lvl 1 (root)
                $grid.find('.awe-tbody').prepend(row);
            }
        }

        function nodeUpdated(res) {
            var api = $('#");
#nullable restore
#line 117 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
                      Write(crudgrid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"').data('api');
            var xhr = api.update(res.Id);
            $.when(xhr).done(function () {
                var $row = api.select(res.Id)[0];
                awe.flash($row);
            });
        }

        // remove the deleted node and its children
        function nodeDeleted(res) {
            var rows = $('#");
#nullable restore
#line 127 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
                       Write(crudgrid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"').data('api').select(res.Id);
            var duration = rows.length > 3 ? 1000 : 500;
            var promises = $.map(rows, function (row, i) {
                return $.Deferred(function (dfd) {
                    row.fadeOut(duration - Math.min(700, i * 50), function () {
                        row.remove();
                        dfd.resolve();
                    });
                });
            });

            $.when.apply($, promises).done(function () {
                // reload grid when page empty
                if (!$('#");
#nullable restore
#line 140 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
                     Write(crudgrid);

#line default
#line hidden
#nullable disable
            WriteLiteral(" .awe-row\').length)\r\n                    $(\'#");
#nullable restore
#line 141 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
                    Write(crudgrid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').data(\'api\').load();\r\n\r\n                // update parent node, if there is one\r\n                if (res.ParentId) {\r\n                    $(\'#");
#nullable restore
#line 145 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
                    Write(crudgrid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"').data('api').update(res.ParentId, { nodesAdded: nodesAdded });
                }
            });
        }
    </script>

    <div class=""bar"">
        <button type=""button"" class=""awe-btn mbtn"" style=""float: left;"" onclick=""awe.open('createNode')"">add root</button>
        <div style=""text-align: right;"">
            ");
#nullable restore
#line 154 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
       Write(Html.Awe().TextBox("txtname").Placeholder("search...").CssClass("searchtxt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 158 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
Write(Html.Awe().Grid(crudgrid)
          .Url(Url.Action("CrudTree", "TreeGrid"))
          .Columns(
              new Column { Bind = "Name" },
              new Column { Bind = "Id", Width = 100 },
              new Column { ClientFormat = GridUtils.AddChildFormat(), Width = 100 },
              new Column { ClientFormat = GridUtils.EditFormat("editNode"), Width = 55 },
              new Column { ClientFormat = GridUtils.DeleteFormat("deleteNode"), Width = 55 })
          .Resizable()
          .PageSize(3)
          .Parent("txtname", "name")
          .Height(400));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <div class=\"tabs code\">\r\n        <div data-caption=\"view\">");
#nullable restore
#line 173 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
                            Write(Html.Source("TreeGrid/Index.cshtml", 3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div data-caption=\"controller\">");
#nullable restore
#line 174 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
                                  Write(Html.Csource("Demos/Grid/TreeGridController.cs", 3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"example\">\r\n    <h3>Use as TreeView</h3>\r\n    The menu on the left is a TreeGrid with hidden footer and header.\r\n\r\n    <div class=\"tabs code\">\r\n        <div data-caption=\"view\">");
#nullable restore
#line 183 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
                            Write(Html.Source("Shared/Menu.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"example\">\r\n    ");
#nullable restore
#line 188 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\TreeGrid\Index.cshtml"
Write(await Html.PartialAsync("Demos/TreeGridCustomRender"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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