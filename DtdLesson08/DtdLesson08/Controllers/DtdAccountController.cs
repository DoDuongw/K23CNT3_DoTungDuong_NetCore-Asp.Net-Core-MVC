using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DtdLesson08.Controllers
{
    public class DtdAccountController : Controller
    {
        // GET: DtdAccountController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DtdAccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DtdAccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DtdAccountController/Create
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

        // GET: DtdAccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DtdAccountController/Edit/5
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

        // GET: DtdAccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DtdAccountController/Delete/5
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
