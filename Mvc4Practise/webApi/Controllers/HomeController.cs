﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webApi.Controllers
{
    public class HomeController : Controller
    {
        public const string variable1 = "This is master 1 First Attemp1";
        public ActionResult Index()
        {
            return View();
        }
    }
}
