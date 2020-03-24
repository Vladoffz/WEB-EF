﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Gundarchuk.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Gundarchuk.Models;
using Microsoft.EntityFrameworkCore;

namespace Gundarchuk.Controllers
{
    public class HomeController : Controller
    {
       GundarchukContext dbo = new GundarchukContext(new DbContextOptions<GundarchukContext>());
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View(dbo.Player);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}