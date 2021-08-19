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
    
        private AthleteDBService _athleteDBService;

        public AthleteController(AthleteDBService athleteDBService)
        {
            _athleteDBService = athleteDBService;
        }

        public IActionResult Index()
        {
            return View();
        }

     
        public IActionResult Create()
        {
            var participantsModel = new ParticipantsModel();

            return View(participantsModel);
        }

        [HttpPost]
        public IActionResult Create(List<AthleteModel> athlete)
        {
            _athleteDBService.CreateAthlete(athlete[0]);

            return RedirectToAction("Index");
        }

        //public IActionResult Edit(int id)
        //{
        //    //ParticipantsModel model = _participantsService.GetModelForEdit(id);

        //    return View(model);
        //}

        //[HttpPost]
        //public IActionResult Edit(List<AthleteModel> athletes)
        //{
        //    _athleteDBService.UpdateAthlete(athletes[0]);

        //    return RedirectToAction("Index");
        //}

        //public IActionResult Delete(int id)
        //{
        //    _athleteDBService.DeleteAthlete(id);

        //    return RedirectToAction("Index");
        //}
    }
}
