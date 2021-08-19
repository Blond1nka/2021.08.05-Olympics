using Microsoft.AspNetCore.Mvc;
using Olympics.Models;
using Olympics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympics.Controllers
{
    public class CountryController : Controller
    {
        private readonly CountryDBService _countryDBService;

        public CountryController(CountryDBService countryDBService)
        {
            _countryDBService = countryDBService;
        }

        public IActionResult Index()
        {
            List<CountryModel> data = _countryDBService.Read();
            return View(data);
        }

        public IActionResult Submit(CountryModel model)
        {
            _countryDBService.Create(model);
            List<CountryModel> data = _countryDBService.Read();
            return View("Index", data);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
