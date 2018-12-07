using ActionAttribute.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionAttribute.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [ActionLength(5)]
        public ActionResult Index()
        {
            return View();
        }
    }
}