using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;
using AweCoreDemo.Utils;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using NPOI.HSSF.UserModel;
using Omu.Awem.Export;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class GridExportToExcelDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetItems(GridParams g)
        {
            return Json(BuildGridModel(g).ToDto());
        }

        private GridModel<Lunch> BuildGridModel(GridParams g)
        {
            return new GridModelBuilder<Lunch>(Db.Lunches.AsQueryable(), g)
            {
                KeyProp = o => o.Id,
                Map = o => new
                {
                    o.Id,
                    o.Person,
                    o.Food,
                    o.Location,
                    o.Price,
                    Date = o.Date.ToShortDateString(),
                    CountryName = o.Country.Name,
                    ChefName = o.Chef.FirstName + " " + o.Chef.LastName
                },
                MakeFooter = gi =>
                    {
                        if (gi.Level == 0)
                        {
                            return new
                            {
                                Id = "Total",
                                Price = "Min: " + gi.Items.Min(o => o.Price),
                                Date = "Max: " + gi.Items.Max(o => o.Date).ToShortDateString()
                            };
                        }

                        return new
                        {
                            Price = "Min: " + gi.Items.Min(o => o.Price),
                            Date = "Max: " + gi.Items.Max(o => o.Date).ToShortDateString()
                        };
                    }
            }.BuildModel();
        }

        private ExpColumn[] getExpColumns()
        {
            var expColumns = new[]
            {
                new ExpColumn { Name = "Id", Width = 1.5f },
                new ExpColumn { Name = "Person", Width = 2.5f },
                new ExpColumn { Name = "Food", Width = 3 },
                new ExpColumn { Name = "Date", Width = 2.2f },
                new ExpColumn
                {
                    Name = "Price", 
                    Width = 2, 
                    // if you don't specify ClientFormatFunc the builder (xls/pdf/txt) will use model[Name] to get the cell value
                    ClientFormatFunc = (lunch, property) =>
                    {
                        var value = lunch.GetType().GetProperty("Price")?.GetValue(lunch).ToString();
                        if (!string.IsNullOrEmpty(value))
                        {
                            value += " USD";
                        }

                        return value;
                    }
                },
                new ExpColumn { Name = "CountryName", Width = 3, Header = "Country" },
                new ExpColumn { Name = "ChefName", Width = 3.2f, Header = "Chef" },
                new ExpColumn { Name = "Location", Width = 2.7f }
            };

            return expColumns;
        }

        [HttpPost]
        public IActionResult ExportGridToExcel(GridParams g, GridExpParams expParams, bool? allPages)
        {
            if (allPages.HasValue && allPages.Value)
            {
                g.Paging = false;
            }

            var gridModel = BuildGridModel(g);

            var workbook = new GridExcelBuilder(getExpColumns())
            {
                // adding ExpParams so the hidden columns won't get exported
                ExpParams = expParams
            }.Build(gridModel);

            using (var stream = new MemoryStream())
            {
                workbook.Write(stream);
                stream.Close();
                return File(stream.ToArray(), "application/vnd.ms-excel", "lunches.xls");
            }
        }

        [HttpPost]
        public IActionResult ExportGridToTxt(GridParams g, GridExpParams expParams, bool? allPages)
        {
            if (allPages.HasValue && allPages.Value)
            {
                g.Paging = false;
            }

            var gridModel = BuildGridModel(g);

            var res = new GridTxtBuilder(getExpColumns())
            {
                // adding ExpParams so the hidden columns won't get exported
                ExpParams = expParams
            }.Build(gridModel);
            
            using (var memoryStream = new MemoryStream())
            {
                using (var writer = new StreamWriter(memoryStream))
                {
                    writer.WriteLine(res);
                }

                return File(memoryStream.GetBuffer(), "text/plain", "lunches.txt");
            }
        }

        [HttpPost]
        public IActionResult ExportGridToPdf(GridParams g, GridExpParams expParams, bool? allPages)
        {
            if (allPages.HasValue && allPages.Value)
            {
                g.Paging = false;
            }

            var gridModel = BuildGridModel(g);

            var builder = new GridPdfBuilder(getExpColumns())
            {
                // adding ExpParams so the hidden columns won't get exported
                ExpParams = expParams
            };

            var workStream = new MemoryStream();
            var writer = new PdfWriter(workStream);
            var pdf = new PdfDocument(writer);
            var document = new Document(pdf);

            document.Add(new Paragraph("Hello World!"));
            document.Add(new Paragraph("Export to pdf example (using iText7)"));
            document.Add(new Paragraph(new Text("\n")));
            
            var table = builder.Build(gridModel);
            document.Add(table);
            writer.SetCloseStream(false);
            document.Close();

            var byteInfo = workStream.ToArray();
            workStream.Write(byteInfo, 0, byteInfo.Length);
            workStream.Position = 0;

            return File(workStream, "application/pdf", "lunches.pdf"); 
        }

        /// <summary>
        /// Demonstrates the simplest way of creating an excel workbook 
        /// it exports all the lunches records, without taking into account any sorting/paging that is done on the client side
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ExportAllToExcel()
        {
            var workbook = new HSSFWorkbook();
            var sheet = workbook.CreateSheet("sheet1");

            var items = Db.Lunches.Select(
                o => new
                {
                    o.Id,
                    o.Person,
                    o.Food,
                    o.Location,
                    CountryName = o.Country.Name,
                    ChefName = o.Chef.FirstName + " " + o.Chef.LastName
                }).ToList();

            var properties = new[] { "Id", "Person", "Food", "CountryName", "ChefName", "Location" };
            var headers = new[] { "Id", "Person", "Food", "Country", "Chef", "Location" };

            var headerRow = sheet.CreateRow(0);

            // create header
            for (int i = 0; i < properties.Length; i++)
            {
                var cell = headerRow.CreateCell(i);
                cell.SetCellValue(headers[i]);
            }

            // fill content 
            for (int i = 0; i < items.Count; i++)
            {
                var rowIndex = i + 1;
                var row = sheet.CreateRow(rowIndex);

                for (int j = 0; j < properties.Length; j++)
                {
                    var cell = row.CreateCell(j);
                    var o = items[i];
                    cell.SetCellValue(o.GetType().GetProperty(properties[j]).GetValue(o, null).ToString());
                }
            }

            using (var stream = new MemoryStream())
            {
                workbook.Write(stream);
                stream.Close();
                return File(stream.ToArray(), "application/vnd.ms-excel", "lunches.xls");
            }
        }
    }
}