﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Controllers
{
    public class EventDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
