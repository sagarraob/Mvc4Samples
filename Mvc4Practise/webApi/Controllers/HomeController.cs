using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webApi.Controllers
{
    public class HomeController : Controller
    {
        public const string variable1 = "This is Test 1 second Attemp1";
        public ActionResult Index()
        {
            return View();
        }
    }
}
