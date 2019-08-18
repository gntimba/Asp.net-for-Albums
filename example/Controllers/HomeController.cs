using example.Models;
using example.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace example.Controllers
{
    public class HomeController : Controller
    {
        private  AlbumContext db= new AlbumContext();
    
        public ActionResult Index()
        {
            return View(db.albums.ToList());
        }

        public ActionResult Edit( Guid? id)
        {
            Album album = db.albums.Find(id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (album == null)
            {
                return HttpNotFound();
            }

            return View(album);
        }

        public ActionResult AddAlbum()
        {
          

            return View();
        }
        public ActionResult Reviews(Guid? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            var record = from r in db.reviews.ToList()
                         join a in db.albums.ToList()
                        on r.albumID equals a.id
                         where r.albumID == id
                         select new viewReviewsModel
                         {
                             album=a,
                             Reviews=r  
                         };
            foreach (var s in record)
            {
                Console.WriteLine(s.album.albumName);
            }
            return View(record);
        }

        [HttpPost]
        public ActionResult AddReview()
        {
           
                var rev = new reviews
                {
                    id = Guid.NewGuid(),
                    albumID = Guid.Parse(Request.Form["id"]),
                    isActive = true,
                    date_created = DateTime.UtcNow,
                    name = Request.Form["name"],
                    review = Request.Form["review"]
                };

                db.reviews.Add(rev);
            try
            {
                db.SaveChanges();
                var result = new
                {
                    review = "Review succesfully added"
                };
                return Json(result);

            }
            catch(Exception e)
            {
                var result = new
                {
                    review = e.ToString()
                };
                return Json(result);
            }


        

           


            
        }
    }
}