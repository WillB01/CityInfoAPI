using System;
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
                    Description = "Lorrem lorem lorem",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "Lorem Lorem"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "Lorem Lorem"
                        }
                    }
                    

                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "Lorrem lorem lorem",
                     PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Cathedral of Our Lady",
                            Description = "Lorem Lorem"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Antwerp Central park",
                            Description = "Lorem Lorem"
                        }
                    }

                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "Lorrem lorem lorem",
                     PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Eiffel Tower",
                            Description = "Lorem Lorem"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "The Louvre",
                            Description = "Lorem Lorem"
                        }
                    }

                },
            };
        }
    }
}
