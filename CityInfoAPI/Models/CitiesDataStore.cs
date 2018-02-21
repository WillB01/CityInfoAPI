﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI.Models
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "Lorrem lorem lorem"

                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "Lorrem lorem lorem"

                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "Lorrem lorem lorem"

                },
            };
        }
    }
}
