namespace TheWebsiteGame.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using System.Diagnostics;
	using TheWebsiteGame.Models;
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult TaskOne()
		{
			return View();
		}
		[HttpPost]
		public IActionResult TaskOne(TaskOneViewModel model)
		{
			if (model.AnswerGiven != model.Answer)
			{
                return View(model);
            }
			else if(!this.ModelState.IsValid)
			{
				return View(model);
			}
			else
			{
				TaskOneViewModel.TaskCompleted = true;
				return RedirectToAction("Index");
			}
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}