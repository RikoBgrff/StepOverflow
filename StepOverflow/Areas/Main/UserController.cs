using Microsoft.AspNetCore.Mvc;

namespace StepOverflow.Areas.Main
{
	public class UserController : Controller
	{
		public IActionResult User()
		{
			return View();
		}
	}
}
