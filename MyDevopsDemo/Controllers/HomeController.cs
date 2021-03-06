﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyDevopsDemo.Models;

namespace MyDevopsDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            var x = "This is test string";
            _logger = logger;
            var y = "This is after logging";
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string HelloWorld(string message)
        {
            return "Hello world from the Home Controller : " + message;
        }

        public string HelloWorldNewMethod(string message)
        {
            var x = "THis is change in the feature branch";
            var y = "Again added one more variable";
            var z = "This is 3rd statement";
            return "Hello world from the Home Controller : " + message;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
