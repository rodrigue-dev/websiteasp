using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace finalMVC.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Dashboard()
        {
            return View();
        }
        [Authorize]
        protected String GetBaseAppUser()
        {
            var identity = User.Identity as System.Security.Claims.ClaimsIdentity;
            if (identity != null)
            {
                return identity.Name;
            }
            else
            {
                return String.Empty;
            }
        }

        // Used for XSRF protection when adding external logins
        private const string XsrfKey = "XsrfId";


        protected void AddErrors(params string[] result)
        {
            foreach (var error in result)
            {
                ModelState.AddModelError("", error);
            }
        }

        protected ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction("Index", "Home");
        }

     
            public string LoginProvider { get; set; }
            public string RedirectUri { get; set; }
            public string UserId { get; set; }

    
}
}
