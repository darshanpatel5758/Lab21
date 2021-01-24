using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab_21.Models.Movie;
using Microsoft.AspNetCore.Mvc;

namespace lab_21.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {


            return View();
        }

        public IActionResult MovieResult(MovieViewModel model)
        {

            return View(model.Title);
        }

    }
}
