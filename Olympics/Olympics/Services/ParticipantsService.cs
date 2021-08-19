using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Olympics.Services
{
    public class ParticipantsService
    {
        private readonly SqlConnection _connection;
        private AthleteDBService _athleteDBService;
        private CountryDBService _countryDBService;
        private SportDBService _sportDBService;
        public ParticipantsService(SqlConnection connection, 
                                   AthleteDBService athleteDBService, 
                                   CountryDBService countryDBService, 
                                   SportDBService sportDBService)
        {
            _connection = connection;
            _athleteDBService = athleteDBService;
            _countryDBService = countryDBService;
            _sportDBService = sportDBService;
        }
    }
}
