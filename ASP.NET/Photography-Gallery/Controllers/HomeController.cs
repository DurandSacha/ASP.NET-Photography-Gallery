using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Photography_Gallery.Models;


namespace Photography_Gallery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // var from controllers to view
            ViewData["titleApplication"] = "ASP Photo Gallery";
            ViewData["Username"] = Environment.UserName;

           // Create Photography Lists
           Photographies photographies = new Photographies();
            ViewData["Photographies"] = photographies.GetAllPhotographies();
            return View("Index");
        }

        [Authorize]
        [Route("Home/About")]
        public ActionResult About()
        {
            return View("About");
        }
    }

}