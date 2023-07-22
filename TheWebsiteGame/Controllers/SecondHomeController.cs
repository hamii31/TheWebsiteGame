namespace TheWebsiteGame.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using TheWebsiteGame.Models;
    public class SecondHomeController : Controller
    {
        [HttpGet]
        public IActionResult TaskTwo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TaskTwo(TaskTwoViewModel model)
        {
            if (model.AnswerGiven.ToLower() != TaskTwoViewModel.Answer.ToLower())
            {
                return View(model);
            }
            else if (!this.ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                TaskTwoViewModel.TaskCompleted = true;
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
