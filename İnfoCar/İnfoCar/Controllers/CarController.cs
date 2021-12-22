using İnfoCar.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İnfoCar.Controllers
{
    public class CarController:Controller
    {
        private List<Cars> _cars;
        public CarController()
        {
             _cars = new List<Cars>
            {
                new Cars{Id=1, Brand="BMW", Model="X5", Average="140000 Km", Year=2016, Price= 75000},
                new Cars{Id=2, Brand="Khazar", Model="Lx", Average="45000 Km", Year=2019, Price= 12000},
                new Cars{Id=3, Brand="Mercedes", Model="Mybach", Average="10000 Km", Year=2020, Price= 640000},
                new Cars{Id=4, Brand="Vaz", Model="2107", Average="200000 Km", Year=2013, Price= 9200},
            };
        }
        public IActionResult Index()
        {
            
            return View(_cars);
        }

        public IActionResult Detail(int id)
        {
           Cars car= _cars.Find(x => x.Id == id);
            if (car == null)
            {
                return RedirectToAction("Error");
            }
            return View(car);
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
