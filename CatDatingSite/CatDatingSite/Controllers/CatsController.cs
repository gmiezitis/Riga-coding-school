﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatDatingSite.Controllers

{
    using System.Data.Entity.Migrations;
     using CatDatingSite.Models;
    using System.Net;
    public class CatsController : Controller
    {
        // GET: Cats
        public ActionResult Index()
        {
            using (var catDb = new catDb())
            {
                var catList = catDb.CatProfiles.ToList();
                return View(catList);
            }
        }

        public ActionResult AddCat()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCat(CatProfile userCreatedCat)
        {
            if (ModelState.IsValid == false)
            {
                return RedirectToAction("Index");
            }
            // izveido savienojumu ar datu bazi
            using (var catDb = new catDb())
            {
                catDb.CatProfiles.Add(userCreatedCat);
                catDb.SaveChanges();
                return RedirectToAction("Index");
            }



        }
        public ActionResult DeleteCats(int catId)


        {
            using (var catDb = new catDb())
            {
                //atrast kaki, kam pieder noraditais idenfikators
                var deleteableCat = catDb.CatProfiles.First(catProfile => catProfile.CatId == catId);
                // izdzēst šo kaki no tabulas 
                catDb.CatProfiles.Remove(deleteableCat);
                //saglab'at veikt'as izmai'nas
                catDb.SaveChanges();
            }
            //japievieno using system.net
            //atgriezam rezultatu kad darbiba ir veiksmiga
            // liekam browserim atgriezties index lapā (t.i parlādēt to )
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult EditCat(int editableCatId)
        {
            using (var catDb = new catDb()) 
            {
                var editableCat = catDb.CatProfiles.First(catProfile => catProfile.CatId == editableCatId);
                return View("EditCat");
            }
        }
        public ActionResult EditCat(CatProfile catProfile)
        {
            using (var catDb = new catDb())
            {
                // japievieno using Sysrem data .... 
                catDb.CatProfiles.AddOrUpdate(catProfile);
                catDb.SaveChanges();
            }
            return RedirectToAction("Index");
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