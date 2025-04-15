using Microsoft.AspNetCore.Mvc;
using Site_1.Data.interfaces;
using Site_1.Data.Models;
using Site_1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Site_1.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;


        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
               
        }
       
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            //string _category = category;
            IEnumerable<Car> cars = null;
            string currСategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("premium", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Премиум класса телефоны")).OrderBy(i => i.id);
                    currСategory = "Премиум класса телефоны";
                }
                else if (string.Equals("cheap", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Бюджетный телефоны")).OrderBy(i => i.id);
                    currСategory = "Бюджетный телефоны";
                }
                else if (string.Equals("new", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Новинки")).OrderBy(i => i.id);
                    currСategory = "Новинки";
                }
            }

            var carObj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = currСategory
            };

            ViewBag.title = "Страница об телефонах";

            return View(carObj);
        }
    }

    
}
