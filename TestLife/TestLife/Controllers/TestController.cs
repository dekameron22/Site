using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestLife.Models;

namespace TestLife.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        private TestsDbEntities ents;

        public TestController()
        {
            if (Session["user"] != null)
            {
                ents = new TestsDbEntities();
            }
        }

        public ActionResult Index()
        {
            var test = ents.TestsTables.First();

            return View(test);
        }

    }
}
