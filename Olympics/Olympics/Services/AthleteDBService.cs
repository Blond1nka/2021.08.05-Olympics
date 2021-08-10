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

        public List<AthleteModel> AllAthletes()
        {
            _connection.Open();

            List<AthleteModel> athletes = new();

            using var command = new SqlCommand("SELECT * FROM Athlete;", _connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                AthleteModel athlete = new()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Surname = reader.GetString(2),
                    CountryId = reader.GetInt32(3)
                };

                athletes.Add(athlete);
            }

            _connection.Close();

            return athletes;
        }
    }
}
