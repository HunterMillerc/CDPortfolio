using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CDPortfolio.Models;

namespace CDPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(AddedCDs.AddCDresponses);
        }

        [HttpGet]
        public ViewResult AddCDForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddCDForm(CD response)
        {
            AddedCDs.AddCD(response);
            return View("Index", AddedCDs.AddCDresponses);
        }
    }
}