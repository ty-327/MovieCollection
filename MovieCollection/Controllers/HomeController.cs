using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieCollection.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieCollectionContext blahContext { get; set; }
        public HomeController(ILogger<HomeController> logger, MovieCollectionContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EnterMovies()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EnterMovies(EnterMovieModel model)
        {
            blahContext.Add(model); //get data from form and pass it into blahcontext variable
            blahContext.SaveChanges();
            return View(); //if I want to return a confirmation page after a user submits the form, just do "return View("Confirmation", model);" and make a Confirmation.cshtml view
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
