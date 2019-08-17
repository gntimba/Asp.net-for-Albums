using example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public ActionResult Edit()
        {
           

            return View();
        }

        public ActionResult AddAlbum()
        {
          

            return View();
        }
    }
}