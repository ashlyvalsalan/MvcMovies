﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovies.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
       public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name , int ID = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.Id = ID;
            return View();
        }
    }
}