using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestLife.Models;
using TestLife.Filters;

namespace TestLife.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        [AuthIgnore]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
                if (isValidAccount(model))
                {
                    try
                    {
                        LogIn(model);
                    }
                    catch (Exception ex)
                    {
                        Session["Error"] = ex.Message;
                    }
                    Session["Error"] = null;
                }
                else
                {
                    Session["Error"] = "Incorrect pasword";

                }
            return RedirectToAction("index", "home");
        }

        private bool isValidAccount(LoginModel model)
        {
            return (model.Login == "admin" && model.Password == "123");
        }

        public ActionResult LogOut()
        {
            var cookie = new HttpCookie("auth", null);
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);

            cookie = new HttpCookie("sign", null);
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);

            Session.Clear();

            return RedirectToAction("Index", "Home");
        }

        
        private void LogIn(LoginModel model)
        {
            if (model.Remember)
            {
                var cookie = new HttpCookie("auth", model.Login);
                cookie.Expires = DateTime.Now.AddDays(10);
                Response.Cookies.Add(cookie);

                cookie = new HttpCookie("sign", model.Login + "wrdasf");
                cookie.Expires = DateTime.Now.AddDays(10);
                Response.Cookies.Add(cookie);
            }


            Session["user"] = model.Login;
        }
    }
}
