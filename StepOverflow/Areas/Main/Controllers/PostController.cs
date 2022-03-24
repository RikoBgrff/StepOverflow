using Microsoft.AspNetCore.Mvc;

namespace StepOverflow.Areas.Main.Controllers
{
    [Area("Main")]
    public class PostController : Controller
    {
        public IActionResult Post()
        {
            return View();
        }
    }
}
