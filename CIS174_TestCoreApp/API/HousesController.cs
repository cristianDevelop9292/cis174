using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.API
{
    [Route("api/House")]
    public class HousesController : Controller
    {
        HouseViewModel _houseOne = new HouseViewModel()
        {
            id = 1,
            Bedrooms = 4,
            SquareFeet = 1854,
            DateBuilt = new DateTime(1973, 05, 28),
            Flooring = "Carpet"
        };

        HouseViewModel _houseTwo = new HouseViewModel()
        {
            id = 2,
            Bedrooms = 3,
            SquareFeet = 1675,
            DateBuilt = new DateTime(2015, 10, 17),
            Flooring = "Hardwood"
        };

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<HouseViewModel> Houses = new List<HouseViewModel>()
            {
            _houseOne, _houseTwo
            };

            return Ok(Houses);
        }


        [HttpPost("create")]
        public IActionResult Create([FromBody] HouseViewModel house)
        {
            return Ok(house);
        }
    }
}