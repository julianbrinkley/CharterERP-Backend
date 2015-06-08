using CharterERP.Backend.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace CharterERP.Backend.WebUI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Logout()
        {
            WebSecurity.Logout();
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel data)
        {

            //if model is valid take user to their destination page or to the home/index if no destination page exists
            if (ModelState.IsValid)
            {
                if(WebSecurity.Login(data.Username, data.Password))
                {
                    string returnUrl = Request.QueryString["ReturnUrl"];
                    if (returnUrl == null)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        Response.Redirect(returnUrl);
                    }
                }
                else
                {
                    //else generate error
                    ModelState.AddModelError("", "Sorry, the username or passsword is invalid");
                }

            }

            //return view with error data
            return View(data);

        }



        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel data)
        {
            //if view model is valid
            if(ModelState.IsValid)
            {
                try 
                {
                    WebSecurity.CreateUserAndAccount(data.Username, data.Password, new { FirstName = data.FirstName, LastName = data.LastName, Email = data.Username });
                    return RedirectToAction("Index", "Home");
                }
                catch(System.Web.Security.MembershipCreateUserException x)
                {
                    //else generate error
                    ModelState.AddModelError("", "User already exists");

                }
            }

            //return view with error data
            return View(data);

        }
    }
}