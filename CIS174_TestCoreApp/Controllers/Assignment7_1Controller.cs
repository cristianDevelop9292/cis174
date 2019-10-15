using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class Assignment7_1Controller : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new Assignment7_1ViewModel
            {

            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(Assignment7_1ViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index", "Assignment7_1");
        }
    }
}