using shop.Data.Interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car { 
                        name = "Tesla", 
                        shortDesc = "Современный вид транспорта", 
                        longDesc = "", 
                        img = "", 
                        price = 45000, 
                        isFavorite = true, 
                        avalible = true, 
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Lada",
                        shortDesc = "Современный вид транспорта",
                        longDesc = "",
                        img = "",
                        price = 4000,
                        isFavorite = true,
                        avalible = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set ; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
