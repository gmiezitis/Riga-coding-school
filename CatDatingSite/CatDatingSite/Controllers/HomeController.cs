using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatDatingSite.Controllers
{
    using CatDatingSite.Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
        

                //izveido kaki
                var catFromDB = new CatProfile();
            catFromDB.CatName = "Reinis";
            catFromDB.CatAge = 15;
            catFromDB.CatImage = "http://s4.thingpic.com/images/Yx/zFbS5iJFJMYNxDp9HTR7TQtT.png";

            //pievieno kakji kaku sarakstam
           

            var anothercatFromDB = new CatProfile();
            anothercatFromDB.CatName = "Second Reinis";
            anothercatFromDB.CatAge = 16;
            anothercatFromDB.CatImage = "http://www.stickpng.com/assets/images/580b57fbd9996e24bc43bb8e.png";

            using (var catDb = new catDb())
            {
                //catDb.CatProfiles.Add(anothercatFromDB);
               // catDb.CatProfiles.Add(catFromDB);
               // saglabat datu bāze veiktās izmaiņas
               // catDb.SaveChanges();

                // iegut kaku sarakstu no kaku datubazes
                var catListFromDb = catDb.CatProfiles.ToList();

                //izveido skatu , tam iekšā iedodot kaku sarakstu
                return View(catListFromDb); 
            }
            
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