﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace newHR.Controllers
{
    public class LeaveController : Controller
    {
        // GET: Leave
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }
    }
}