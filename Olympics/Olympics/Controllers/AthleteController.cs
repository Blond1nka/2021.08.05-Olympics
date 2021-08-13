using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Olympics.Models;
using Olympics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Olympics.Controllers
{
    public class AthleteController : Controller
    {
        // GET: AthleteController
        private AthleteDBService _athleteDB;

        public AthleteController(AthleteDBService athleteDB)
        {
            _athleteDB = athleteDB;
        }

        public ActionResult Index()
        {
            return View(_athleteDB.AllAthletes());
        }

        // GET: AthleteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AthleteController/Create
        public ActionResult Create()
        {
            var participantsModel = new ParticipantsModel();
            return View(participantsModel);
        }

        // POST: AthleteController/Create
        [HttpPost]
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
