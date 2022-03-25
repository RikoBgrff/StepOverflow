using Microsoft.AspNetCore.Mvc;

namespace StepOverflow.Areas.Main.Controllers
{
[Area("Main")]
	public class QuestionsController : Controller
	{
		public IActionResult Questions()
		{
			return View();
		}
	}
}
