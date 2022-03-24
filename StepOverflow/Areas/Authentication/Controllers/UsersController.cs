using Microsoft.AspNetCore.Mvc;

namespace StepOverflow.Areas.Authentication.Controllers
{
    [Area("Main")]
    public class UsersController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }
    }
}
