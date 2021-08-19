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
        private SqlConnection _connection;
        public AthleteDBService(SqlConnection connection)
        {
            _connection = connection;
        }

        public AthleteModel GetAthletes()
        {
            AthleteModel athlete = new();

            _connection.Open();
            var command = new SqlCommand("SELECT * FROM Athlete;", _connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                athlete.Id = (int)reader.GetValue(0);
                athlete.Name = (string)reader.GetValue(1);
                athlete.Surname = (string)reader.GetValue(2);
                athlete.CountryId = (int)reader.GetValue(3);
                athlete.CountryName = (string)reader.GetValue(4);
                athlete.Sports = new List<int>();
                athlete.SportsNames = new List<string>();
            }

            _connection.Close();

            athlete = AddSportsToAthlete(athlete);

            return athlete;
        }

        public void CreateAthlete(AthleteModel athleteModel)
        {
            _connection.Open();
            using var command = new SqlCommand($"INSERT into dbo.Athletes (Name, Surname, CountryId) values ('{athleteModel.Name}', '{athleteModel.Surname}', '{athleteModel.CountryId}');", _connection);
            command.ExecuteReader();

            _connection.Close();
        }

        public AthleteModel AddSportsToAthlete(AthleteModel athlete)
        {
            _connection.Open();
            var command = new SqlCommand("SELECT * FROM Sports;", _connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                athlete.Sports.Add((int)reader.GetValue(0));
                athlete.SportsNames.Add((string)reader.GetValue(1));
            }

            return athlete;
        }



    }
}
