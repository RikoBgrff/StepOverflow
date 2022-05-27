using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using StepOverflow.Areas.Register.Models;
using StepOverflow.Entities;
using System;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;

namespace StepOverflow.Areas.Register.Controllers
{
    [Area("Authentication")]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppRole> roleManager;
        private readonly SignInManager<AppUser> signInManager;
        //private readonly Logger<AppUser> logger;

        public AuthController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            //this.logger = logger;
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
                        CreatedTime = DateTime.Now,
                        Biography = model.Biography,
                        Location = model.Location,
                        PhoneNumber = model.PhoneNumber,
                        ReputationCount = 0,
                        Resume = "",
                        AnswersCount = 0,
                        QuestionsCount = 0,
                        
                    };
                    var role = await roleManager.FindByNameAsync("User");
                    if (role == null)
                    {
                        AppRole role2 = new AppRole();
                        role2.Name = "User";
                        await roleManager.CreateAsync(role2);
                    }
                    var result = await userManager.CreateAsync(user, model.Password);
                    var response = await userManager.AddToRoleAsync(user, "User");
                    if (result.Succeeded)
                    {
                       await signInManager.SignInAsync(user, isPersistent: false);
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
        //public async Task<IActionResult> OnPostAsync(SignUpViewModel model, string returnUrl = null)
        //{
        //    returnUrl = returnUrl ?? Url.Content("~/");
        //    var ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync())
        //                                          .ToList();
        //    if (ModelState.IsValid)
        //    {
        //        var user = new AppUser()
        //      {
        //          UserName = model.Username,
        //          Email = model.Email,
        //          CreatedTime = DateTime.Now,
        //          Biography = model.Biography,
        //          Location = model.Location,
        //          PhoneNumber = model.PhoneNumber,
        //          ReputationCount = 0,
        //          Resume = "",
        //          AnswersCount = 0,
        //          QuestionsCount = 0,
        //          
        //      };
    //        var result = await userManager.CreateAsync(user, model.Password);
    //        if (result.Succeeded)
    //        {
    //           //BURANI LOGLA KI USER YARADILDI  

    //            var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
    //            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

    //            //await _emailSender.SendEmailAsync(model.Email, "Confirm your email",
    //                //$"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

    //            if (userManager.Options.SignIn.RequireConfirmedAccount)
    //            {
    //                return RedirectToPage("RegisterConfirmation",
    //                                      new { email = model.Email });
    //            }
    //            else
    //            {
    //                await signInManager.SignInAsync(user, isPersistent: false);
    //                return LocalRedirect(returnUrl);
    //            }
    //        }
    //        foreach (var error in result.Errors)
    //        {
    //            ModelState.AddModelError(string.Empty, error.Description);
    //        }
    //    }

    //    // If we got this far, something failed, redisplay form
    //    return View();
    //}
}
}
