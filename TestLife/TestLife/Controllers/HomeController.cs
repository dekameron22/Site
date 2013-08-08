using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestLife.Filters;

namespace TestLife.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        [AuthIgnore]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Testing()
        {
            return View();
        }

        [AuthIgnore]
        public ActionResult Error(Exception ex)
        {
            ViewBag.Exception = ex;
            return View();
        }
    }
}
