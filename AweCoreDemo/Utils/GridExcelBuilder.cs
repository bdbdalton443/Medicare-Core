using System;
using System.Collections.Generic;
using System.Linq;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using Omu.Awem.Export;
using Omu.AwesomeMvc;

namespace AweCoreDemo.Utils
{
    public class GridExcelBuilder
    {
        private ExpColumn[] columns;

        public GridExcelBuilder(ExpColumn[] expColumns)
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

        public HSSFWorkbook Build<T>(GridModel<T> gridModel, string[] headers = null)
        {
            var workbook = new HSSFWorkbook();
            var sheet = workbook.CreateSheet("sheet1");
            var headerRow = sheet.CreateRow(0);

            // create header
            for (int i = 0; i < columns.Length; i++)
            {
                var cell = headerRow.CreateCell(i);
                cell.SetCellValue(columns[i].Header);
            }

            var currentRow = 0;

            if (gridModel.Data.Groups != null)
            {
                foreach (var groupView in gridModel.Data.Groups)
                {
                    BuildGroup(sheet, ref currentRow, groupView);
                }
            }
            else if (gridModel.Data.Items != null)
            {
                BuildItems(sheet, ref currentRow, gridModel.Data.Items);
            }

            if (gridModel.Data.Footer != null)
            {
                BuildFooter(sheet, ref currentRow, gridModel.Data.Footer);
            }

            return workbook;
        }

        private void BuildGroup(ISheet sheet, ref int currentRow, GroupView groupView)
        {
            if (groupView.Header != null)
            {
                currentRow++;
                var row = sheet.CreateRow(currentRow);
                var cell = row.CreateCell(0);
                cell.SetCellValue(groupView.Header.Content);
            }

            if (groupView.Groups != null)
            {
                foreach (var groupViewx in groupView.Groups)
                {
                    BuildGroup(sheet, ref currentRow, groupViewx);
                }
            }
            else if (groupView.Items != null)
            {
                BuildItems(sheet, ref currentRow, groupView.Items);
            }

            if (groupView.Footer != null)
            {
                BuildFooter(sheet, ref currentRow, groupView.Footer);
            }
        }

        private void BuildItems(ISheet sheet, ref int currentRow, IEnumerable<object> items)
        {
            foreach (var item in items)
            {
                currentRow++;
                var row = sheet.CreateRow(currentRow);

                for (int columnIndex = 0; columnIndex < columns.Length; columnIndex++)
                {
                    var cell = row.CreateCell(columnIndex);
                    CellSetValue(cell, columns[columnIndex], item);
                }
            }
        }

        private void BuildFooter(ISheet sheet, ref int currentRow, object footer)
        {
            currentRow++;
            var row = sheet.CreateRow(currentRow);
            for (int columnIndex = 0; columnIndex < columns.Length; columnIndex++)
            {
                var cell = row.CreateCell(columnIndex);
                CellSetValue(cell, columns[columnIndex], footer);
            }
        }

        private void CellSetValue(ICell cell, ExpColumn column, object item)
        {
            if (column.ClientFormatFunc != null)
            {
                var value = column.ClientFormatFunc(item, column.Name);
                cell.SetCellValue(value);
                return;
            }
            
            var prop = item.GetType().GetProperty(column.Name);

            if (prop != null)
            {
                var value = prop.GetValue(item, null);

                if (prop.PropertyType == typeof(DateTime))
                {
                    cell.SetCellValue(((DateTime)value).ToShortDateString());
                }
                else if (prop.PropertyType == typeof(int))
                {
                    cell.SetCellValue(Convert.ToDouble(value));
                }
                else
                {
                    cell.SetCellValue(value.ToString());
                }
            }
        }
    }
}