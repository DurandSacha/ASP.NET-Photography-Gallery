using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Photography_Gallery.Models;


namespace Photography_Gallery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // init DB 
            /*
            IDatabaseInitializer<BddContext> init = new DropCreateDatabaseAlways<BddContext>();
            Database.SetInitializer(init);
            init.InitializeDatabase(new BddContext());
            */



            // var from controllers to view
            ViewData["titleApplication"] = "ASP Photo Gallery";

            // Create Photography Lists
            Photographies photographies = new Photographies();
            ViewData["Photographies"] = photographies.GetAllPhotographies(); //.FirstOrDefault();

            // return View("~/Views/Test/Essai.cshtml");
            return View("Index");
        }

        public ActionResult About()
        {
            return View("About");
        }
    }

}