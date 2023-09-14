using MvcStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Details(int id)
        {

            var album = new Album { Title = "Album " + id };
           return View(album);
        }

        public ActionResult Index()   
        {
            var genres = new List<Genre>
           {
            new Genre {Name = "Disco"},
            new Genre {Name = "Jazz"},
            new Genre {Name = "Rock"}


           };

            return View(genres);


        }

        //public string Browse()
        //{
        //    return "Hello from Store Browser";

        //}

        //public string Details(int id)
        //{
        //    //return "Hello from Store Details";

        //    string message = "Detalle del item: " + id;
        //    return message;


        //}

        public ActionResult Browse(string genero)
        {

            var genreModel = new Genre { Name = genero };
            return View(genreModel);
        }


    }
}