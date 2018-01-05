using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatDatingSite.Controllers

{
     using System.Data.Entity;
     using CatDatingSite.Models;
      using System.Net;
    using System.IO;

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
                return View(userCreatedCat);
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

        public ActionResult EditCat(CatProfile catProfile, HttpPostedFileBase uploadedPicture)
        {
            
                if (ModelState.IsValid == false)
                {
                    return View(catProfile);
                }
                using (var catDb = new catDb())
            {
                var profilePic = new Models.File();
                //saglabajam bildes faila nosaukumu
                profilePic.FileName = Path.GetFileName(uploadedPicture.FileName);
                //saglabajam bildes tipu
                profilePic.ContentType = uploadedPicture.ContentType;
                //pasakam profila bildei, kurs kaka profils ir kaka profils kam si bilde pieder
                profilePic.CatProfileId = catProfile.CatId;
                profilePic.CatProfile = catProfile;
                //imantojam binary reader lai parvērstu bildi baitos
                using (var reader = new BinaryReader(uploadedPicture.InputStream))
                {
                    profilePic.Content = reader.ReadBytes(uploadedPicture.ContentLength);
                }
                //Pievieno profila bildes datubazes ierakstu files tabulai
                catDb.Files.Add(profilePic);
                //pasakam kaku profilam kas ir vina profila bilde
                catProfile.ProfilePicture = profilePic;
                // pievienot using system.DataEntity
                catDb.Entry(catProfile).State = EntityState.Modified;
                catDb.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult EditCat(int editableCatId)
        {
            using (var catDb = new catDb()) 
            {
                var editableCat = catDb.CatProfiles.First(catprofile => catprofile.CatId == editableCatId);
                return View("EditCat", editableCat);
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