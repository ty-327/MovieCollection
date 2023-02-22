using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private MovieCollectionContext blahContext { get; set; }
        public HomeController(MovieCollectionContext someName)
        {
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
            ViewBag.CategoriesList = blahContext.Categories.ToList();

            return View(); //return View(new EnterMovieModel());
        }
        [HttpPost]
        public IActionResult EnterMovies(EnterMovieModel model)
        {
            /*model.MovieID = 1;*/ //chatGPT added, maybe change
            if (ModelState.IsValid) //If valid
            {
                blahContext.Add(model); //get data from form and pass it into blahcontext variable
                blahContext.SaveChanges();
                return View("Confirmation", model); //if I want to return a confirmation page after a user submits the form, just do "return View("Confirmation", model);" and make a Confirmation.cshtml view
            }
            else //If invalid
            {
                ViewBag.CategoriesList = blahContext.Categories.ToList();

                return View();
            }

        }

        [HttpGet]
        public IActionResult SeeMovies()
        {
            var movies_list = blahContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movies_list);
        }
        [HttpGet]
        public IActionResult Edit(int movieID)
        {
            ViewBag.CategoriesList = blahContext.Categories.ToList();

            var movie = blahContext.Responses.Single(x => x.MovieID == movieID);

            return View("EnterMovies", movie);
        }

        [HttpPost]
        public IActionResult Edit(EnterMovieModel blah)
        {
            blahContext.Update(blah);
            blahContext.SaveChanges();
            return RedirectToAction("SeeMovies");
        }

        [HttpGet]
        public IActionResult Delete(int movieID)
        {
            var movie = blahContext.Responses.Single(x => x.MovieID == movieID);
            
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(EnterMovieModel model)
        {
            blahContext.Responses.Remove(model);
            blahContext.SaveChanges();

            return RedirectToAction("SeeMovies");
        }
        // on the get of the add:
        // return View(new EnterMovieModel()); 
    }
}
