using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AweCoreDemo.Models;
using AweCoreDemo.Utils;
using AweCoreDemo.ViewModels.Input.Wizard;

namespace AweCoreDemo.Controllers.Demos.Misc
{
    public class WizardDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StartWizard()
        {
            var wizardModel = new WizardModel { Id = Guid.NewGuid().ToString() };
            wizardModel.Step1 = new Step1Model { WizardId = wizardModel.Id };
            wizardModel.Step2 = new Step2Model { WizardId = wizardModel.Id };

            Cache.Set(wizardModel.Id, wizardModel);

            return RedirectToAction("WizardStep1", new { WizardId = wizardModel.Id });
        }

        public IActionResult WizardStep1(string wizardId)
        {
            var wiz = Cache.Get(wizardId);

            Check.NotNull(wiz, "wizard");
            var model = (WizardModel)wiz;

            return PartialView(model.Step1);
        }

        [HttpPost]
        public IActionResult WizardStep1(Step1Model step1Model)
        {
            if (!ModelState.IsValid)
            {
                return View(step1Model);
            }

            // all good
            // set model for step1 and redirect to step2
            var wizardModel = (WizardModel)Cache.Get(step1Model.WizardId);
            wizardModel.Step1 = step1Model;

            var oldCategoryId = wizardModel.Step2.CategoryId;

            // set category for next step
            wizardModel.Step2.CategoryId = step1Model.CategoryId.Value;

            // clear selected meals when we go gack from Step2 to Step1 and change the category
            if (oldCategoryId != 0 && wizardModel.Step2.CategoryId != oldCategoryId)
            {
                wizardModel.Step2.MealIds = null;
            }

            // go to next step
            return RedirectToAction("WizardStep2", new { WizardId = wizardModel.Id });
        }

        public IActionResult WizardStep2(string wizardId)
        {
            var wiz = Cache.Get(wizardId);

            Check.NotNull(wiz, "wizard");
            var model = (WizardModel)wiz;

            return PartialView(model.Step2);
        }

        [HttpPost]
        public IActionResult WizardStep2(Step2Model step2Model)
        {
            var wizardModel = (WizardModel)Cache.Get(step2Model.WizardId);
            step2Model.CategoryId = wizardModel.Step2.CategoryId;

            if (!ModelState.IsValid)
            {
                return View(step2Model);
            }

            wizardModel.Step2 = step2Model;

            return RedirectToAction("WizardFinish", new { WizardId = wizardModel.Id });
        }

        public IActionResult WizardFinish(string wizardId)
        {
            var model = (WizardModel)Cache.Get(wizardId);
            var finishModel = new WizardFinishModel();

            finishModel.WizardId = model.Id;
            finishModel.Name = model.Step1.Name;

            var category = Db.Categories.SingleOrDefault(o => o.Id == model.Step1.CategoryId);
            if (category != null)
            {
                finishModel.Category = category.Name;
            }

            finishModel.Meals = Db.Meals.Where(o => model.Step2.MealIds.Contains(o.Id)).Select(o => o.Name).ToArray();

            return PartialView(finishModel);
        }

        [HttpPost]
        public IActionResult WizardFinish(WizardConfirmModel confirmModel)
        {
            // wizard input confirmed
            var model = (WizardModel)Cache.Get(confirmModel.WizardId);

            // do something with model

            // clear session
            Cache.Remove(model.Id);
            var meals = Db.Meals.Where(o => model.Step2.MealIds.Contains(o.Id)).Select(o => o.Name).ToArray();

            return Json(new { Message = string.Format("Thank you {0} with meals: {1} was saved", model.Step1.Name, string.Join(",", meals)) });
        }
    }
}