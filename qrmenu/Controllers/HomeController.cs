using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace qrmenu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Welcome()
        {
            return View();
        }

        public ActionResult Category()
        {

            return View();
        }

        public ActionResult MenuList()
        {
            return View();
        }
        public ActionResult MenuDetail()
        {
            return View();
        }
    }
}