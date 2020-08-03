using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Photography_Gallery.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Security
        public ActionResult register()
        {
            return View("registerForm");
        }

        public ActionResult login()
        {
            return View("loginForm");
        }
    }
}