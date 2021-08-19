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
    
        private readonly AthleteDBService _athleteDBService;
        private readonly ParticipantsService _participantsService;


        public AthleteController(AthleteDBService athleteDBService, ParticipantsService viewsParticipantsService)
        {
            _athleteDBService = athleteDBService;
            _participantsService = viewsParticipantsService;

        }

        public IActionResult Index()
        {
            ParticipantsModel data = _participantsService.GetParticipantsDBData();
            return View(data);
        }

     
        public IActionResult Create()
        {
            ParticipantsModel data = _participantsService.GetParticipantsDBData();
            return View(data);
        }

        [HttpPost]
        public IActionResult Create(List<AthleteModel> athlete)
        {
            _athleteDBService.CreateAthlete(athlete[0]);

            return RedirectToAction("Index");
        }

        
    }
}
