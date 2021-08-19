using Microsoft.AspNetCore.Mvc;
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
    }
}
