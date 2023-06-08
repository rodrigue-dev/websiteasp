using Microsoft.AspNetCore.Mvc;

namespace finalMVC.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
