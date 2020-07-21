using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;
using AweCoreDemo.ViewModels.Input;
using Omu.Awem.Scheduler;
using Omu.AwesomeMvc;
 
namespace AweCoreDemo.Controllers.Demos.Grid
{
    public class SchedulerDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ScheduleGetItems(GridParams g, int minutesOffset, DateTime? date, SchedulerView? viewType, SchedulerHour? hoursType, int? hourStep, string cmd)
        {
            var model = new SchedulerModelBuilder(g)
                {
                    GetEvents = (startUtc, endUtc) => 
                        Db.Meetings.Where(o => o.Start < endUtc && o.End >= startUtc)
                        .Select(o => new SchedulerEvent
                        {
                            AllDay = o.AllDay,
                            Color = o.Color,
                            Id = o.Id,
                            Start = o.Start,
                            End = o.End,
                            Title = o.Title,
                            Notes = o.Notes
                        }),
                    Cmd = cmd,
                    Date = date,
                    HourStep = hourStep,
                    HoursType = hoursType,
                    MinutesOffset = minutesOffset,
                    ViewType = viewType
                }.Build();

            return Json(model);
        }

        public IActionResult GetViewTypes()
        {
            return Json(SchedulerModelBuilder.GetViewTypes());
        }

        public IActionResult GetHoursTypes()
        {
            return Json(SchedulerModelBuilder.GetHoursTypes());
        }

        public IActionResult GetHourSteps()
        {
            return Json(SchedulerModelBuilder.GetHourSteps());
        }

        public IActionResult Create(int minutesOffset, long? ticks, bool? allDay)
        {
            var start = (ticks.HasValue ? new DateTime(ticks.Value) : DateTime.UtcNow).AddMinutes(-minutesOffset);
            start = start.AddMinutes(5 - start.Minute % 5);
            var end = start.AddMinutes(15);

            var input = new MeetingInput
                {
                    Start = start,
                    StartTime = start,
                    AllDay = allDay.HasValue && allDay.Value,
                    End = end,
                    EndTime = end,
                    Color = "#5484ED"
                };

            return PartialView(input);
        }

        [HttpPost]
        public IActionResult Create(MeetingInput input, int minutesOffset)
        {
            if (!ModelState.IsValid) return PartialView(input);

            //get date
            var start = input.Start.Value.Date;
            var end = input.End.Value.Date;

            //add time
            if (!input.AllDay)
            {
                start += input.StartTime.TimeOfDay;
                end += input.EndTime.TimeOfDay;
            }

            start = start.AddMinutes(minutesOffset);
            end = end.AddMinutes(minutesOffset);

            if (!input.AllDay && end <= start || end < start)
            {
                ModelState.AddModelError("Start", "end date and time should be greater than start date and time");
                return PartialView(input);
            }

            var meeting = new Meeting
            {
                Title = input.Title,
                Start = start,
                End = end,
                Location = input.Location,
                Notes = input.Notes,
                AllDay = input.AllDay,
                Color = input.Color
            };

            Db.Insert(meeting);

            return Json(new { });
        }

        public IActionResult Edit(int id, int minutesOffset)
        {
            var meeting = Db.Get<Meeting>(id);
            var start = meeting.Start.AddMinutes(-minutesOffset);
            var end = meeting.End.AddMinutes(-minutesOffset);

            var input = new MeetingInput
                {
                    Id = id,
                    Title = meeting.Title,
                    Location = meeting.Location,
                    Start = start,
                    StartTime = start,
                    End = end,
                    EndTime = end,
                    Notes = meeting.Notes,
                    AllDay = meeting.AllDay,
                    Color = meeting.Color
                };

            return PartialView("Create", input);
        }

        [HttpPost]
        public IActionResult Edit(MeetingInput input, int minutesOffset)
        {
            if (!ModelState.IsValid) return PartialView("Create", input);

            var start = input.Start.Value.Date;
            var end = input.End.Value.Date;

            if (!input.AllDay)
            {
                start += input.StartTime.TimeOfDay;
                end += input.EndTime.TimeOfDay;
            }

            start = start.AddMinutes(minutesOffset);
            end = end.AddMinutes(minutesOffset);

            if (!input.AllDay && end <= start || end < start)
            {
                ModelState.AddModelError("Start", "end date and time should be greater than start date and time");
                return PartialView("Create", input);
            }

            var meeting = new Meeting
            {
                Id = input.Id,
                Title = input.Title,
                Start = start,
                End = end,
                Location = input.Location,
                Notes = input.Notes,
                AllDay = input.AllDay,
                Color = input.Color
            };

            Db.Update(meeting);

            return Json(new { });
        }

        public IActionResult Delete(int id)
        {
            var purchase = Db.Get<Meeting>(id);

            return PartialView(new DeleteConfirmInput
            {
                Id = id,
                Name = purchase.Title
            });
        }

        [HttpPost]
        public IActionResult Delete(DeleteConfirmInput input)
        {
            Db.Delete<Meeting>(input.Id);
            return Json(new { input.Id });
        }
    }
}