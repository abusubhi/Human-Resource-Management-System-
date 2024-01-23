﻿using HRSMF.Data;
using HRSMF.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HRSMF.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //private readonly AppDbContext _context;
        //public EmployeeController(AppDbContext context)
        //{
        //    _context = context;
        //}


        public IActionResult Index()
        {

           
            return View();
        }
        public IActionResult Create()
        {
            return View();
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