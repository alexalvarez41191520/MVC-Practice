﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_2.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Create()
        {
            return View();
        }
    }
}