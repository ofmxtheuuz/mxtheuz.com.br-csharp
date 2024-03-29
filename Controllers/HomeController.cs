﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mxtheuz.com.br.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mxtheuz.com.br.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/home")]
        public IActionResult Index()
        {
            ViewData["Title"] = "Início | Mxtheuz";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
