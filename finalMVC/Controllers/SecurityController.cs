using System;
using finalMVC.Models;
using finalMVC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace finalMVC.Controllers
{
    public class SecurityController : Controller
    {
        private readonly ILogin _loginUser;
        private readonly ILogger _logger;

        public SecurityController(ILogin loginUser, ILogger<SecurityController> logger)
        {
            _loginUser = loginUser;
            _logger = logger;
        }
        public IActionResult Login()
        {
            return View();

        }
        public IActionResult Logout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SubmitPost(User model, IFormCollection form, string returnUrl)
        {
            var issuccess = _loginUser.AuthenticateUser(model.Email, model.Password);
            _logger.LogInformation("#################----------------");
            _logger.LogInformation(model.Email + "-****"+ model.Password);
            if (issuccess.Result != null)
            {
                ViewBag.username = string.Format("Successfully logged-in", model.Email);

                TempData["username"] = "Ahmed";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.username = string.Format("Login Failed ", model.Email);
              //  return View();
                return RedirectToAction("Login", "Security");
            }
        }
    }
}
