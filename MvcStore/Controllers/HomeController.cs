﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcStore.Controllers
{
    public class HomeController : Controller
    {
          //GET: Home
        public ActionResult Index()
       {
           return View();
       }



        //public string index()
        //{
        //    return "Hola Mi gente";
        //}



    }
}