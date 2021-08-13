using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Olympics.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Olympics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string connectionString = "Server=.;Database=OndatoCacheDatabase;Integrated Security=SSPI;";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            using var command = new SqlCommand("SELECT * FROM Olympics;", connection);
            using var reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
            }

            connection.Close();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
