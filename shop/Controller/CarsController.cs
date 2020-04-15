using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shop.Data.Interfaces;
using shop.ViewModels;
namespace shop.Controller
{
    public class CarsController: Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategiries;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategiries = iCarsCat;
        }
        public ViewResult List()
        {
            ViewBag.title = "страница с авто";
            CarsListViewModel obj = new CarsListViewModel();
            obj.getAllCars = _allCars.Cars;
            obj.currCategory = "авто";
            return View(obj);
        }
    }
}
