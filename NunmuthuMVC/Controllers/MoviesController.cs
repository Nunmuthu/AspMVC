using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NunmuthuMVC.Models;

namespace NunmuthuMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Aladdin" };
            return View(movie);
        }

    }

}