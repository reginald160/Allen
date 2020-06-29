using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeBitesAcademyEFC.Controllers
{
    public class TesterController : Controller
    {
        // GET: TesterController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TesterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TesterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TesterController/Create
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

        // GET: TesterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TesterController/Edit/5
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

        // GET: TesterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TesterController/Delete/5
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
