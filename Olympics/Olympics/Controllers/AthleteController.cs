using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Olympics.Controllers
{
    public class AthleteController : Controller
    {
        // GET: AthleteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AthleteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AthleteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AthleteController/Create
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

        // GET: AthleteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AthleteController/Edit/5
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

        // GET: AthleteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AthleteController/Delete/5
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
