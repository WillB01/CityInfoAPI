using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfoAPI.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(CitiesDataStore.Current.Cities);
           
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var CityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if(CityToReturn == null)
            {
                return NotFound();
            }

            return Ok(CityToReturn);
                
        }


    }
}