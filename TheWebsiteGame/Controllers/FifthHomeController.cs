namespace TheWebsiteGame.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using TheWebsiteGame.Models;

    public class FifthHomeController : Controller
    {
        [HttpGet]
        public IActionResult TaskFive()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TaskFive(TaskFiveViewModel model) 
        {
            if (model.AnswerGiven.ToLower() != TaskFiveViewModel.AnswerA.ToLower() && model.AnswerGiven.ToLower() != TaskFiveViewModel.AnswerB.ToLower())
            {
                return View(model);
            }
            else if (!this.ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                if (model.AnswerGiven.ToLower() == TaskFiveViewModel.AnswerA.ToLower())
                {
                    TaskFiveViewModel.Message = "Not yet";
                }
                if (model.AnswerGiven.ToLower() == TaskFiveViewModel.AnswerB.ToLower())
                {
                    TaskFiveViewModel.Message = "I don't like liars";
                }
                TaskFiveViewModel.TaskCompleted = true;
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
