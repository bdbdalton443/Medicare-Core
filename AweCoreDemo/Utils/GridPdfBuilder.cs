using System;
using System.Collections.Generic;
using System.Linq;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Layout.Element;
using iText.Layout.Properties;
using Omu.Awem.Export;
using Omu.AwesomeMvc;

namespace AweCoreDemo.Utils
{
    public class GridPdfBuilder
    {
        private readonly PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
        private ExpColumn[] columns;

        public GridPdfBuilder(ExpColumn[] expColumns)
        {
            columns = expColumns;
        }

        public GridExpParams ExpParams
        {
            set
            {
                if (value != null)
                {
                    var visNames = value.GetVisNames();
                    columns = columns.Where(o => visNames.Contains(o.Name)).ToArray();
                }
            }
        }

        public Table Build<T>(GridModel<T> gridModel)
        {
            var relWidths = columns.Select(o => o.Width).ToArray();
            var table = new Table(relWidths);

            table.SetWidth(UnitValue.CreatePercentValue(100));

            // create table header
            foreach (var col in columns)
            {
                AddCell(table, col.Header);
            }

            if (gridModel.Data.Groups != null)
            {
                foreach (var groupView in gridModel.Data.Groups)
                {
                    BuildGroup(table, groupView);
                }
            }
            else if (gridModel.Data.Items != null)
            {
                BuildItems(table, gridModel.Data.Items);
            }

            if (gridModel.Data.Footer != null)
            {
                BuildFooter(table, gridModel.Data.Footer);
            }

            return table;
        }

        private void BuildGroup(Table table, GroupView groupView)
        {
            if (groupView.Header != null)
            {
                var cell = new Cell(1, columns.Length).Add(new Paragraph(groupView.Header.Content).SetFont(font));
                table.AddCell(cell);
            }

            if (groupView.Groups != null)
            {
                foreach (var groupViewx in groupView.Groups)
                {
                    BuildGroup(table, groupViewx);
                }
            }
            else if (groupView.Items != null)
            {
                BuildItems(table, groupView.Items);
            }

            if (groupView.Footer != null)
            {
                BuildFooter(table, groupView.Footer);
            }
        }

        private void BuildItems(Table table, IList<object> dataItems)
        {
            foreach (var item in dataItems)
            {
                RenderRow(table, item);
            }
        }

        private void BuildFooter(Table table, object fitem)
        {
            RenderRow(table, fitem);
        }

        private void RenderRow(Table table, object item)
        {
            foreach (var col in columns)
            {
                AddCell(table, GetVal(col, item));
            }
        }

        private void AddCell(Table table, string val)
        {
            table.AddCell(new Cell().Add(new Paragraph(val)).SetFont(font).SetFontSize(10));
        }

        private string GetVal(ExpColumn column, object item)
        {
            if (column.ClientFormatFunc != null)
            {
                return column.ClientFormatFunc(item, column.Name);
            }

            var prop = item.GetType().GetProperty(column.Name);

            if (prop == null) return string.Empty;

            var value = prop.GetValue(item, null);
            if (prop.PropertyType == typeof(DateTime))
            {
                return ((DateTime)value).ToShortDateString();
            }

            return value.ToString();
        }
    }
}