using Microsoft.AspNetCore.Mvc;
using Olympics.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Olympics.Services
{
    public class ParticipantsService
    {
        private readonly AthleteDBService _athleteDBService;
        private readonly CountryDBService _countryDBService;
        private readonly SportDBService _sportDBService;
        public ParticipantsService(AthleteDBService athleteDBService, 
                                   CountryDBService countryDBService, 
                                   SportDBService sportDBService)
        {
            _athleteDBService = athleteDBService;
            _countryDBService = countryDBService;
            _sportDBService = sportDBService;
        }
        public ParticipantsModel GetParticipantsDBData()
        {
            ParticipantsModel model = new();
            model.Athletes = _athleteDBService.Read();
            model.Countries = _countryDBService.Read();
            model.Sports = _sportDBService.Read();

            return model;
        }
    }
}
