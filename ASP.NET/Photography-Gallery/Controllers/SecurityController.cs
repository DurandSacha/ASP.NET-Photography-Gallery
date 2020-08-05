using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;
using Photography_Gallery.Context;
using Photography_Gallery.Models;
using System.Net.Http;

namespace Photography_Gallery.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Security

        public BddContext bdd = new BddContext();

        [Route("Register")]
        public ActionResult Register()
        {
            if (Request.HttpMethod == "POST")
            {
                if (ModelState.IsValid)
                {
                    bdd.User.Add(new User { Nom = Request.Form["Nom"], Email = Request.Form["Email"], Password = Request.Form["Password"] });
                    // TODO : Crypt Password
                    bdd.SaveChanges();
                    // TODO : Connect this User 
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        public ActionResult login()
        {
            if (Request.HttpMethod == "POST")
            {
                // TODO : Verify Form and connect the user 
            }

                /*
                string motDePasseEncode = EncodeMD5(motDePasse);
                User user = new User { nom = nom, MotDePasse = motDePasseEncode, Email = email };
                bdd.Utilisateurs.Add(utilisateur);
                bdd.SaveChanges();
                return utilisateur.Id;
                */

                return View("loginForm");
        }
    }
}