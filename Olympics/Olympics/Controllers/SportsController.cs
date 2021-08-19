using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Olympics.Controllers
{
    public class SportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
