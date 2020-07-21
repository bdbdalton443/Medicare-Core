using System;
using System.Collections.Generic;
using System.Linq;
using Omu.Awem.Export;
using Omu.AwesomeMvc;

namespace AweCoreDemo.Utils
{
    public class GridTxtBuilder
    {
        private readonly string newline = Environment.NewLine;

        private ExpColumn[] columns;

        public GridTxtBuilder(ExpColumn[] expColumns)
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

        public string Build<T>(GridModel<T> gridModel)
        {
            var res = "";

            // create header
            for (var i = 0; i < columns.Length; i++)
            {
                res += (i > 0 ? ", " : "") + columns[i].Header;
            }

            res += newline;

            var currentRow = 0;

            if (gridModel.Data.Groups != null)
            {
                foreach (var groupView in gridModel.Data.Groups)
                {
                    res += BuildGroup(ref currentRow, groupView);
                }
            }
            else if (gridModel.Data.Items != null)
            {
                res += BuildItems(ref currentRow, gridModel.Data.Items);
            }

            if (gridModel.Data.Footer != null)
            {
                res += BuildFooter(ref currentRow, gridModel.Data.Footer);
            }

            return res;
        }

        private string BuildGroup(ref int currentRow, GroupView groupView)
        {
            var res = "";
            if (groupView.Header != null)
            {
                currentRow++;
                res = groupView.Header.Content + newline;
            }

            if (groupView.Groups != null)
            {
                foreach (var gv in groupView.Groups)
                {
                    res += BuildGroup(ref currentRow, gv);
                }
            }
            else if (groupView.Items != null)
            {
                res += BuildItems(ref currentRow, groupView.Items);
            }

            if (groupView.Footer != null)
            {
                res += BuildFooter(ref currentRow, groupView.Footer);
            }

            return res;
        }

        private string BuildItems(ref int currentRow, IEnumerable<object> items)
        {
            var res = "";

            // fill content 
            foreach (var item in items)
            {
                currentRow++;

                res += RenderRow(item) + newline;
            }

            return res;
        }

        private string BuildFooter(ref int currentRow, object footer)
        {
            currentRow++;
            return RenderRow(footer);
        }

        private string GetColValue(ExpColumn column, object item)
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

        private string RenderRow(object item)
        {
            var res = "";
            for (var i = 0; i < columns.Length; i++)
            {
                res += (i > 0 ? ", " : "") + GetColValue(columns[i], item);
            }

            return res;
        }
    }
}