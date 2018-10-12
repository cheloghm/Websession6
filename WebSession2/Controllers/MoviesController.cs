using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSession2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewMovies()
        {
            return View();
        }

        public ActionResult RandomMovies()
        {
            return View();
        }
    }
}