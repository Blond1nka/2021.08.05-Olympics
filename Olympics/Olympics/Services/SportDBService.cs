using Microsoft.AspNetCore.Mvc;
using Olympics.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Olympics.Services
{
    public class SportDBService
    {
        private readonly SqlConnection _connection;

        public SportDBService(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<SportModel> Read()
        {
            List<SportModel> items = new();
            SportModel sportModel = new();

            _connection.Open();

            using var command = new SqlCommand("SELECT Id, SportName, TeamActivity FROM dbo.Sports;", _connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                items.Add(
                new SportModel
                {
                    Id = reader.GetInt32(0),
                    SportName = reader.GetString(1),
                    TeamActivity = reader.GetBoolean(2),
                });
            }

            _connection.Close();

            return items;
        }

        public void Create(SportModel model)
        {
            _connection.Open();

            using var command = new SqlCommand($"INSERT into dbo.Sports (SportName, TeamActivity) values ('{model.SportName}', '{model.TeamActivity}');", _connection);
            command.ExecuteNonQuery();

            _connection.Close();
        }

    }
}
