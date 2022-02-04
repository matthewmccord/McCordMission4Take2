using McCordMission4Take2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        
        private MovieData MovieContext { get; set; }

        public HomeController(MovieData randoName)
        {
            MovieContext = randoName;
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
            ViewBag.Movies = MovieContext.Categories.ToList();
            
            return View();
        }

        [HttpPost]
        public IActionResult MovieEntry(MovieAdd movie)
        {
            ViewBag.Movies = MovieContext.Categories.ToList();
            if (ModelState.IsValid == true) {
                MovieContext.Add(movie);
                MovieContext.SaveChanges();
                return View("Complete", movie);
            }
            else { return View(movie); }
        }

        public IActionResult MovieList()
        {
            ViewBag.Movies = MovieContext.Categories.ToList();

            var movies = MovieContext.MovieAdds
                .Include(x => x.Category)
                .Where(x => x.Lent_To == null)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Movies = MovieContext.Categories.ToList();

            var mv = MovieContext.MovieAdds.Single(x => x.MovieID == movieid);
            
            return View("MovieEntry", mv);
        }

        [HttpPost]
        public IActionResult Edit(MovieAdd ma)
        {
            MovieContext.Update(ma);
            MovieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var mv = MovieContext.MovieAdds.Single(x => x.MovieID == movieid);
            return View(mv);
        }
        [HttpPost]
        public IActionResult Delete(MovieAdd ma)
        {
            MovieContext.MovieAdds.Remove(ma);
            MovieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
