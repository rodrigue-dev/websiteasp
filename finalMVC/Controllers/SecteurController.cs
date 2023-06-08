using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace finalMVC.Controllers
{
    public class SecteurController : Controller
    {
        // GET: SecteurController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SecteurController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SecteurController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SecteurController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SecteurController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SecteurController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SecteurController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SecteurController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
