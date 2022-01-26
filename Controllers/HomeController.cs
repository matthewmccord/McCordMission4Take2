using McCordMission4Take2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace McCordMission4Take2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieData AddAMovie { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieData randoName)
        {
            _logger = logger;
            AddAMovie = randoName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieEntry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieEntry(MovieAdd movie)
        {
            

            if (ModelState.IsValid == true) {
                AddAMovie.Add(movie);
                AddAMovie.SaveChanges();
                return View("Complete", movie);
            }
            else { return View(); }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
