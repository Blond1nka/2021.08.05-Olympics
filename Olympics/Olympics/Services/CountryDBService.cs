using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Olympics.Services
{
    public class CountryDBService
    {
        private readonly SqlConnection _connection;

        public CountryDBService(SqlConnection connection)
        {
            _connection = connection;
        }
    }
}
