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
        public IActionResult EnterMovies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieEntry(Movie response)
        {
            _context.Movies.Add(response); //Add record to database
            _context.SaveChanges();

            return View("Confirmation", response);
        }
    }
}
