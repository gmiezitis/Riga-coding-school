using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatDatingSite.Controllers
{
    using CatDatingSite.Models;
    using System.Net;
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

       

