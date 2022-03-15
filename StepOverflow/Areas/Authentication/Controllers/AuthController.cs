using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StepOverflow.Areas.Register.Models;
using StepOverflow.Entities;
using System;
using System.Threading.Tasks;

namespace StepOverflow.Areas.Register.Controllers
{
    [Area("Authentication")]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppRole> roleManager;
        private readonly SignInManager<AppUser> signInManager;

        public AuthController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel model)
        {
            try
            {
                var user = await userManager.FindByNameAsync(model.Username);
                if (user == null)
                {
                    TempData["msg"] = "<script>alert('Check Your Username Again');</script>";
                }
                if (user != null)
                {
                    var result = await userManager.CheckPasswordAsync(user, model.Password);
                    if (result)
                    {
                        var response = await signInManager.PasswordSignInAsync(user, model.Password, true, true);
                        if (response.Succeeded)
                        {
                            return RedirectToAction("Index", "Home", new { area = "Main" });
                        }
                        if (!result)
                        {
                            TempData["msg"] = "<script>alert('Check Your Password Again');</script>";
                        }
                    }

                }
            }
            catch (System.Exception)
            {
                TempData["msg"] = "<script>alert('Check Your Username and Password Again');</script>";
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View(new SignUpViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel model)
        {

            try
            {
                if (model == null)
                {

                }

                if (model != null)
                {
                    var user = new AppUser()
                    {
                        UserName = model.Username,
                        Email = model.Email,
                        CreatedTime = DateTime.Now
                    };
                    var role = await roleManager.FindByNameAsync("Admin");
                    if (role == null)
                    {
                        AppRole role2 = new AppRole();
                        role2.Name = "Admin";
                        await roleManager.CreateAsync(role2);
                    }
                    var result = await userManager.CreateAsync(user, model.Password);
                    var response = await userManager.AddToRoleAsync(user, "Admin");
                    if (result.Succeeded)
                    {
                        return RedirectToAction("SignIn", "Auth");
                    }
                }
            }
            catch (System.Exception)
            {
                TempData["msg"] = "<script>alert('Enter your username, email and password');</script>";
            }
            return View();
        }
    }
}
