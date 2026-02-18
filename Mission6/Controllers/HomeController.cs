using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission6.Models;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private MovieEntryContext _context;
        public HomeController(MovieEntryContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        public IActionResult MovieList()
        {
            var movies = _context.Movies
                .Include(x => x.Category)
                .OrderBy(x => x.Title).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult MovieEntry()
        {
            ViewBag.Categories = _context.Categories
               .OrderBy(x => x.CategoryName)
               .ToList();

            return View("EnterMovies", new Movie());
        }

        [HttpPost]
        public IActionResult MovieEntry(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); //Add record to database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Majors = _context.Categories
                    .OrderBy(x => x.CategoryName)
                    .ToList();

                return View(response);
            }

        }
    }
}
