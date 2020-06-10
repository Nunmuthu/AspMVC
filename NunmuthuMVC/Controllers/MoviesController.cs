﻿using System;
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

        public ActionResult Edit(int movieId)
        {
            return Content("id=" + movieId);
        }

        //movies
        public ActionResult Index(int? pageIndex, string  sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }

}