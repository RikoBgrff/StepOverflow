using Microsoft.AspNetCore.Mvc;

namespace StepOverflow.Areas.Main.Controllers
{
	[Area("Main")]
	public class JobsController : Controller
	{
		public IActionResult Jobs()
		{
			return View();
		}
	}
}
