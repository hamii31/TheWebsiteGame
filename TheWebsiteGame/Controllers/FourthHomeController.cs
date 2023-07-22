namespace TheWebsiteGame.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using TheWebsiteGame.Models;
    public class FourthHomeController : Controller
    {
        [HttpGet]
        public IActionResult TaskFour()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TaskFour (TaskFourViewModel model)
        {
            if (model.AnswerGiven != TaskFourViewModel.Answer)
            {
                return View(model);
            }
            else if (!this.ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                TaskFourViewModel.TaskCompleted = true;
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
