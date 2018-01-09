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
                //iegut kaku sarakstu no kaku datubazes tabulas
                var catList = catDb.CatProfiles.Include(catProf => catProf.ProfilePicture).ToList();
                //izveidot skatu tam ieksa padodot kaku sarakstu
                return View(catList);
            }
        }

        public ActionResult AddCat()
        {
            return View();
        }
        public ActionResult GetCatProfilePicture(int catProfilePictureId)
        {
            using (var db = new catDb())
            {
                var profilePic = db.Files.First(rec => rec.FileId == catProfilePictureId);
                return File(profilePic.Content, profilePic.ContentType);
            }
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


       


        [HttpPost]
        public ActionResult EditCat(CatProfile catProfile, HttpPostedFileBase uploadedPicture)
        {
            if (ModelState.IsValid == false)
            {
                return View(catProfile);
            }

            using (var catDb = new catDb())
            {
                // ja ir pievienota profila bilde
                if (uploadedPicture != null)
                {
                    // atrodam šobrīdējo bildi, ja tāda ir
                    var currentPic = catDb.Files.FirstOrDefault(fileRecord => fileRecord.CatProfileId == catProfile.CatId);
                    if (currentPic != null)
                    {
                        catDb.Files.Remove(currentPic);
                    }

                    // izveidojam jaunu profila bildes datubāzes eksemplāru, ko ierakstīsim datubāzē
                    var profilePic = new Models.File();

                    // saglabājam bildes faila nosaukumu
                    profilePic.FileName = Path.GetFileName(uploadedPicture.FileName);

                    // saglabājam bildes tipu
                    profilePic.ContentType = uploadedPicture.ContentType;

                    // izmantojam BinaryReader lai pārvērstu bildi baitos
                    using (var reader = new BinaryReader(uploadedPicture.InputStream))
                    {
                        // saglabājam baitus datubāzes ierakstā
                        profilePic.Content = reader.ReadBytes(uploadedPicture.ContentLength);
                    }

                    // pasakam profila bildei, kurš kaķa profils ir kaķa profils, kam šī bilde pieder
                    profilePic.CatProfileId = catProfile.CatId;
                    profilePic.CatProfile = catProfile;

                    // pievienojam profila bildes datubāzes ierakstu Files tabulai
                    catDb.Files.Add(profilePic);

                    // paskam kaķu profilam, kas ir viņa profila bilde
                    catProfile.ProfilePicture = profilePic;
                }

                // pievienot using System.Data.Entity;
                catDb.Entry(catProfile).State = EntityState.Modified;
                catDb.SaveChanges();
            }

            // pavēlam browserim atgriezties Index lapā (t.i. pārlādēt to)
            return RedirectToAction("Index");
        }

        public ActionResult EditCat(int editableCatId)
        {
            using (var catDb = new catDb())
            {
                var editableCat = catDb.CatProfiles.Include(catRecord => catRecord.ProfilePicture).First(catProfile => catProfile.CatId == editableCatId);
                return View("EditCat", editableCat);
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