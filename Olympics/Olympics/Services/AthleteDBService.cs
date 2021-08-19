using Olympics.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympics.Services
{
    public class AthleteDBService
    {
        private readonly SqlConnection _connection;
        private readonly CountryDBService _countryDBService;
        private readonly SportDBService _sportDBService;

        public AthleteDBService(CountryDBService countryDBService, SportDBService sportDBService, SqlConnection connection)
        {
            _connection = connection;
            _countryDBService = countryDBService;
            _sportDBService = sportDBService;
        }

        public List<AthleteModel> Read()
        {
            List<AthleteModel> items = new();

            _connection.Open();

            using var command = new SqlCommand("SELECT dbo.AthletesWithCountries.Id, dbo.AthletesWithCountries.Name , dbo.AthletesWithCountries.Surname, dbo.AthletesWithCountries.CountryName, dbo.Sports.SportName, dbo.Sports.TeamActivity " +
                                                "FROM dbo.AthletesWithCountries " +
                                               "LEFT OUTER JOIN dbo.AthleteSports " +
                                                "ON dbo.AthletesWithCountries.Id = dbo.AthleteSports.AthleteId " +
                                               "LEFT OUTER JOIN dbo.Sports " +
                                                "ON dbo.AthleteSports.SportsId = dbo.Sports.Id;", _connection);

            using var reader = command.ExecuteReader();


            while (reader.Read())
            {
                items.Add(
                    new AthleteModel
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Surname = reader.GetString(2),
                        CountryName = reader.GetString(3),
                        SportsNames = reader.GetString(4),
                        TeamActivity = reader.GetBoolean(5)
                    });
               
            }

            _connection.Close();

            items = GetAthletes(items);

            return items;
        }

        public void CreateAthlete(AthleteModel athleteModel)
        {
            _connection.Open();
            using var command = new SqlCommand($"INSERT into dbo.Athletes (Name, Surname, CountryId) values ('{athleteModel.Name}', '{athleteModel.Surname}', '{athleteModel.CountryId}');", _connection);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        private List<AthleteModel> GetAthletes(List<AthleteModel> athletes)
        {
            Dictionary<int, AthleteModel> athletesDic = new Dictionary<int, AthleteModel>();

            foreach (AthleteModel athlete in athletes)
            {
                if(!athletesDic.ContainsKey(athlete.Id))
                {
                    athletesDic.Add(athlete.Id, athlete);
                }

                athletes = athletesDic.Select(x => x.Value).ToList();
            }
            return athletes;
        }



    }
}
