﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shop.Data.Models;
namespace shop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> getAllCars { get; set; }
        public string currCategory { get; set; }
    }
}
