namespace TheWebsiteGame.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using TheWebsiteGame.Models;
    public class ThirdHomeController : Controller
    {
        [HttpGet]
        public IActionResult TaskThree()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TaskThree(TaskThreeViewModel model) 
        {
            if (model.AnswerGiven != TaskThreeViewModel.Answer)
            {
                return View(model);
            }
            else if (!this.ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                TaskThreeViewModel.TaskCompleted = true;
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
