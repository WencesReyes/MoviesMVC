using MoviesMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesMVC.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        [HttpGet]
        public ActionResult Random()
        {
            var movie = new Movie { Id = 1, Name = "Shrek!" };
            return View(movie);
        }
    }
}