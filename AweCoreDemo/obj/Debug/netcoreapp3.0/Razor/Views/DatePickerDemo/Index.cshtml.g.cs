#pragma checksum "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "853aa7f1607ec29c7a5d56f3bfa7edc589076254"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DatePickerDemo_Index), @"mvc.1.0.view", @"/Views/DatePickerDemo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"853aa7f1607ec29c7a5d56f3bfa7edc589076254", @"/Views/DatePickerDemo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be622e01f8f56f0dd36faab0a36e6216511e344", @"/Views/_ViewImports.cshtml")]
    public class Views_DatePickerDemo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AweCoreDemo.ViewModels.Input.DatePickerDemoInput>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
  
    ViewBag.Title = "DatePicker Demo";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>DatePicker</h1>\r\n\r\n<div class=\"efield\">\r\n    <div class=\"elabel\">\r\n        Date:\r\n    </div>\r\n    <div class=\"einput\">\r\n");
            WriteLiteral("        ");
#nullable restore
#line 13 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
   Write(Html.Awe().DatePickerFor(o => o.Date).Value(new DateTime(2017, 11, 1)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n\r\n    ");
#nullable restore
#line 17 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
Write(Html.Source("DatePickerDemo/Index.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<h2>Inline Calendar</h2>\r\n<div class=\"efield\">\r\n    <div class=\"elabel\">\r\n        Date inline:\r\n    </div>\r\n    <div class=\"einput\">\r\n");
            WriteLiteral("        ");
#nullable restore
#line 26 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
   Write(Html.Awe().DatePickerFor(o => o.DateInline).InlineCalendar(true, true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n\r\n    ");
#nullable restore
#line 30 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
Write(Html.Source("DatePickerDemo/Index.cshtml", "inl"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<h2>With ChangeMonth and ChangeYear</h2>\r\n<div class=\"efield\">\r\n    <div class=\"elabel\">\r\n        Date:\r\n    </div>\r\n    <div class=\"einput\">\r\n");
            WriteLiteral("        ");
#nullable restore
#line 40 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
    Write(Html.Awe().DatePickerFor(o => o.Date2)
                    .ChangeMonth()
                    .ChangeYear());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n\r\n    ");
#nullable restore
#line 46 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
Write(Html.Source("DatePickerDemo/Index.cshtml", "1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n<h2>Number of months, Min, max, default date, clear button </h2>\r\n<div class=\"efield\">\r\n    <div class=\"elabel\">\r\n        Date:\r\n    </div>\r\n    <div class=\"einput\">\r\n");
            WriteLiteral("        ");
#nullable restore
#line 56 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
    Write(Html.Awe().DatePickerFor(o => o.Date3)
              .NumberOfMonths(3)
              .MinDate(DateTime.Now.AddDays(1))
              .MaxDate(DateTime.Now.AddMonths(7))
              .DefaultDate(DateTime.Now.AddDays(4))
              .ClearButton());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n\r\n    ");
#nullable restore
#line 65 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
Write(Html.Source("DatePickerDemo/Index.cshtml", "2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<h2>Date range</h2>\r\n<div class=\"efield\">\r\n");
            WriteLiteral("    <div class=\"elabel\">\r\n        From:\r\n    </div>\r\n    <div class=\"einput\">\r\n        ");
#nullable restore
#line 75 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
    Write(Html.Awe().DatePickerFor(o => o.DateFrom).NumberOfMonths(2).ChangeMonth().ChangeYear());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"elabel\">\r\n        To:\r\n    </div>\r\n    <div class=\"einput\">\r\n        ");
#nullable restore
#line 81 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
    Write(Html.Awe().DatePickerFor(o => o.DateTo).NumberOfMonths(2));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <script>
        $(function () {
            var from = $('#DateFrom');
            var to = $('#DateTo');

            from.change(function () {
                to.data('o').p.min = from.val();
            });

            to.change(function () {
                from.data('o').p.max = to.val();
            });
        });
    </script>
");
            WriteLiteral("    ");
#nullable restore
#line 98 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
Write(Html.Source("DatePickerDemo/Index.cshtml", "range", true));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<h2>Disable certain dates, change weekend days color</h2>
<div class=""expl"">
    If you need to disable certain dates, for example holidays, weekends, or just a specific period, you can use the <code>DayFunc</code> 
    to set a custom js function where you can set <code>opt.dsb</code> to disable a date or add an additional css class to <code>opt.cls</code>.
</div>
");
            WriteLiteral(@"<script>
    function dayf(opt) {
        var date = opt.d.getDate();
        var dayw = opt.d.getDay();

        if (date >= 15 && date <= 20) {
            opt.dsb = 1;
        }

        if (dayw == 0 || dayw == 6) {
            opt.cls += ' weekend';
        }
    }
</script>

<style>
    .weekend {
        color: orangered;
             }
</style>

<div class=""efield"">
    <div class=""elabel"">
        Date:
    </div>
    <div class=""einput"">
        ");
#nullable restore
#line 133 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
   Write(Html.Awe().DatePicker("DateWeekend").DayFunc("dayf"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 137 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
Write(Html.Source("DatePickerDemo/Index.cshtml", "w", true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Right to left </h2>\r\n\r\n");
            WriteLiteral("<div class=\"einput\" style=\"direction: rtl;\">\r\n    ");
#nullable restore
#line 143 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
Write(Html.Awe().DatePickerFor(o => o.Date4).ChangeMonth().ChangeYear());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 147 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
Write(Html.Source("DatePickerDemo/Index.cshtml", "3"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Datepicker Api</h2>\r\n<div class=\"efield\">\r\n    <div class=\"elabel\">\r\n        Datepicker:\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"einput\">\r\n        ");
#nullable restore
#line 156 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
   Write(Html.Awe().DatePicker("DateApi"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <br />
    <br />
    <div>
    <button type=""button"" class=""awe-btn"" onclick=""setToday()"">set today</button>
    <button type=""button"" class=""awe-btn"" onclick=""nextDay()"">next day</button>
    <button type=""button"" class=""awe-btn"" onclick=""getDate()"">get date</button>
    <button type=""button"" class=""awe-btn"" onclick=""formatNow()"">format now as dd-mm-yy</button>
    <button type=""button"" class=""awe-btn"" onclick=""parseToDate()"">parse 31-01-2012 to date</button>

        <div id=""apilog""></div>
    </div>
    <script>
        var log = $('#apilog');
        var dtp = $('#DateApi');

        function getDate() {
            var date = dtp.data('api').getDate();
            var sval = date ? dtp.data('api').getDate().toString() : '';
            awe.flash(log.html(sval));
        }

        function setToday() {
            dtp.data('api').setDate(new Date());
        }

        function nextDay() {
            var date = dtp.data('api').getDate() || new Date();
     ");
            WriteLiteral(@"       date.setDate(date.getDate() + 1);
            dtp.data('api').setDate(date);
        }

        function formatNow() {
            var str = awem.formatDate('dd-mm-yy', new Date());
            awe.flash(log.html(str));
        }

        function parseToDate() {
            var date = awem.parseDate('dd-mm-yy', '31-01-2012');
            awe.flash(log.html(date.toString()));
        }
    </script>
");
            WriteLiteral(@"    <br />
    
    <div class=""tabs"">
        <div class=""expl"" data-caption=""description"">
            DatePicker api can be called to get or set date, or if you just need to parse or format a date.<br />
            <code>$('#id').data('api')</code> - get datepicker api<br />
            <code>api.getDate()</code> - get datepicker value as Date object<br />
            <code>api.setDate(date)</code> - set datepicker value with a Date type parameter<br />
            <code>awem.formatDate(format, val)</code> - format Date value to string using provided format<br />
            <code>awem.parseDate(format, strval)</code> - parse string value to Date type
        </div>
        <div data-caption=""view"">
            ");
#nullable restore
#line 212 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
       Write(Html.Source("DatePickerDemo/Index.cshtml", "api"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    \r\n</div>\r\n\r\n<h2>TimePicker</h2>\r\n\r\n");
#nullable restore
#line 221 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
Write(Html.Awe().TimePicker("tmp1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 224 "D:\Tutorials\ASP Core Tables\AweCoreDemo\AweCoreDemo\AweCoreDemo\Views\DatePickerDemo\Index.cshtml"
Write(Html.Source("DatePickerDemo/Index.cshtml", "4"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AweCoreDemo.ViewModels.Input.DatePickerDemoInput> Html { get; private set; }
    }
}
#pragma warning restore 1591