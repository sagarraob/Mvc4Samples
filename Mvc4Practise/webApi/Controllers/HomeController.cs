using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webApi.Controllers
{
    public class HomeController : Controller
    {
        public const string variable1 = "1";
        public ActionResult Index()
        {
            return View();
        }
    }
}
