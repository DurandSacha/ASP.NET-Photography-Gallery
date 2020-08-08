using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Authentication;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;
using Photography_Gallery.Context;
using Photography_Gallery.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System.Web.UI.WebControls;
using Photography_Gallery.Models;

namespace Photography_Gallery.Controllers
{
    public class AuthConfig
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/login")
            });
        }
    }

    public class SecurityController : Controller
    {
        // GET: Security

        public BddContext bdd = new BddContext();
        //public HttpContext context = HttpContext.Current;

        [Route("register")]
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
                    // HttpContext.SignInAsync(new ClaimsPrincipal(new ClaimsIdentity(claims, "Cookies", "user", "role")));
                    return RedirectToAction("Index", "Home");
                }
            }
            return View("registerForm");
        }

        private bool ValidateUser(string Email, string Password)
        {
            User User = bdd.User.FirstOrDefault(u => u.Email == Email && u.Password == Password);
            if (User.Password == Password)
            {
                //return Email == Password;
                return true;
            }
            return false;
        }

        [Route("login")]
        //[HttpPost]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public ActionResult loginForm(User model, string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;

            if (Request.HttpMethod == "POST")
            {
                if (!ValidateUser(model.Email, model.Password))
                {
                    //ViewData["dump"] = "erreur validate user function";
                    ModelState.AddModelError(string.Empty, "Le nom d'utilisateur ou le mot de passe est incorrect.");
                    return View(model);
                }

                //ViewData["dump"] = "authentification success";
                // L'authentification est réussie
                var loginClaim = new Claim(ClaimTypes.NameIdentifier, model.Email);
                var claimsIdentity = new ClaimsIdentity(new[] { loginClaim }, DefaultAuthenticationTypes.ApplicationCookie);
                var ctx = Request.GetOwinContext();
                var authenticationManager = ctx.Authentication;
                authenticationManager.SignIn(claimsIdentity);

                return RedirectToAction("Index", "Home");
            }

            // Rediriger vers l'URL d'origine :
            /*
            if (Url.IsLocalUrl(ViewBag.ReturnUrl))
                return Redirect(ViewBag.ReturnUrl);
            */
            // Par défaut, rediriger vers la page d'accueil :
            //return View("registerForm");
            return View("loginForm");
            //return RedirectToAction("loginForm", "Security");
        }

        [HttpGet]
        public ActionResult Logout()
        {
            var ctx = Request.GetOwinContext();
            var authenticationManager = ctx.Authentication;
            authenticationManager.SignOut();

            // Rediriger vers la page d'accueil :
            return RedirectToAction("Index", "Home");
        }
    }
}