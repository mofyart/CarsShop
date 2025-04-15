using Microsoft.AspNetCore.Mvc;
using Site_1.Data.interfaces;
using Site_1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site_1.Controllers
{
    public class OneCartController : Controller
    {
        private readonly IAllCars _caRep;
        public OneCartController(IAllCars a)
        {
            _caRep = a;
         
        }
        [Route("Car/List/cart/{id}")]
        public ViewResult OneCar(int id)
        {
            var obj = new OneCarViewModel();
            foreach (var v in _caRep.Cars)
            {
                if (v.id == id)
                {
                    obj.OneCar = v;
                    break;
                }
            }
            return View(obj);

        }


    }
}
