using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Photography_Gallery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewData["titleApplication"] = "ASP Photo Gallery";

            Photographies photographies = new Photographies();
            photography photography = Photographies.GetAllPhotographies();

            return View("Index");
        }
    }
}