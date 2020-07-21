using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;

using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Awesome.Grid
{
    /*begin*/
    public class CustomFormatGridController : Controller
    {
        public IActionResult GetItems(GridParams g)
        {
            return Json(new GridModelBuilder<Lunch>(Db.Lunches.AsQueryable(), g)
                {
                    Map = o => new
                    {
                        o.Id,
                        o.Person,
                        o.Price,
                        o.Food,
                        Date = o.Date.ToString("dd MMMM yyyy"),
                        o.Location,
                        o.Organic,
                        RowClass = o.Price > 90 ? "pinkb" : o.Price < 30 ? "greenb" : string.Empty
                    },
                    MakeHeader = gr =>
                        {
                            var value = AweUtil.GetColumnValue(gr.Column, gr.Items.First()).Single();
                            var strVal = gr.Column == "Date" ? ((DateTime)value).ToString("dd MMMM yyyy") :
                                         gr.Column == "Price" ? value + " GBP" : value.ToString();
                        
                            return new GroupHeader {Content = gr.Header + " - " + strVal};
                        } }.Build());
        }
    }
    /*end*/
}