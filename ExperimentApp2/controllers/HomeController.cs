using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExperimentApp2.models;

namespace ExperimentApp2.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Grades")]
        public IActionResult Grades()
        {
            return View();
        }

        [HttpPost("Grades")]
        public IActionResult Grades(GradesModel model)
        {
            return View();
        }
    }

    
}
