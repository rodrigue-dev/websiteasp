using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace finalMVC.Controllers
{
    public class FormationsController : Controller
    {
        // GET: Base/FormationsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FormationsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FormationsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FormationsController/Create
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

        // GET: FormationsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FormationsController/Edit/5
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

        // GET: FormationsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FormationsController/Delete/5
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
