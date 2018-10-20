﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreCourse.Spyshop.Web.Controllers
{
    public class HomeController : Controller 
    {

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult SearchByKey(string searchkey)
        {
            ViewData["SearchMethod"] = "Text";
            ViewData["SearchSubject"] = searchkey;
            return View("SearchResults");
        }

        public IActionResult SearchById(long id)
        {
            ViewData["SearchMethod"] = "Numerical ID";
            ViewData["SearchSubject"] = id;
            return View("SearchResults");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
