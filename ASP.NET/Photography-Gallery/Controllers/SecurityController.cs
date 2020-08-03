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

            // if submit 
            /*
            string motDePasseEncode = EncodeMD5(motDePasse);
            Utilisateur utilisateur = new Utilisateur { Prenom = nom, MotDePasse = motDePasseEncode };
            bdd.Utilisateurs.Add(utilisateur);
            bdd.SaveChanges();
            return utilisateur.Id;
            */
        }

        public ActionResult login()
        {
            return View("loginForm");
        }


        // id user : HttpContext.User.Identity
        // user is connected ? : HttpContext.User.Identity.IsAuthenticated
        // HttpContext.User.Identity.Name
    }
}