using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StepOverflow.Areas.Main.Models;
using StepOverflow.Context;
using System.Linq;
using System.Threading.Tasks;

namespace StepOverflow.Areas.Main.Controllers
{
    [Area("Main")]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext context;

        public UsersController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> UsersAsync()
        {
            var users = await context.Users.Select(i => new UsersViewModel
            {
                Id = i.Id,
                Username = i.UserName,
                Biography = i.Biography,
                JoinDate = i.CreatedTime,
                Location = i.Location,
                ReputationCount = i.ReputationCount,
                ProfilePicture = i.ProfilePicture,
            }).ToListAsync();
            return View(users);
        }
    }
}
