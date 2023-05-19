using CW.Data;
using CW.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CW.Controllers
{ 
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly MyDbContext _db;


        public HomeController(ILogger<HomeController> logger, MyDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {



            // Retrieve all causes from the database
            var causes = _db.Causes.ToList();
            // Return the Index view with the causes
            return View(causes);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Account()
        {
            return View();
        }
        public IActionResult Causes()
        {
            // Retrieve all causes from the database
            var causes = _db.Causes.ToList();
            // Return the Index view with the causes
            return View(causes);
        }
        public IActionResult CreateCause()
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        // Define the Error action with ResponseCache attribute to prevent caching
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Return the Error view with the ErrorViewModel containing the RequestId
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
