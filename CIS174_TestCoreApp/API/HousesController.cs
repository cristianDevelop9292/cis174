using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.API
{
    public class HousesController : Controller
    {
        List<string> _one = new List<string>
        {
            "Bedrooms = 4",
            "SquareFeet = 1854",
            "DateBuilt = 05/28/1973",
            "Flooring = Carpet"
        };
        public IEnumerable<string> Index()
        {
            return _one;
        }
        public IActionResult View(int id)
        {
            if (id >= 0 && id < _one.Count)
            {
                return Ok(_one[id]);
            }
            return NotFound();
        }
    }

    public class HouseController : Controller
    {
        List<string> _two = new List<string>
        {
            "Bedrooms = 3",
            "SquareFeet = 1675",
            "DateBuilt = 10/17/2015",
            "Flooring = Hardwood"
        };
        public IEnumerable<string> Index()
        {
            return _two;
        }
        public IActionResult View(int id)
        {
            if (id >= 0 && id < _two.Count)
            {
                return Ok(_two[id]);
            }
            return NotFound();
        }
    }
}