using İnfoCar.Models;
using İnfoCar.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İnfoCar.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            List<Cars> cars = new List<Cars>
            {
                new Cars{Id=1, Brand="BMW", Model="X5", Average="140000 Km", Year=2016, Price= 75000},
                new Cars{Id=2, Brand="Khazar", Model="Lx", Average="45000 Km", Year=2019, Price= 12000},
                new Cars{Id=3, Brand="Mercedes", Model="Mybach", Average="10000 Km", Year=2020, Price= 640000},
                new Cars{Id=4, Brand="Vaz", Model="2107", Average="200000 Km", Year=2013, Price= 9200},
            };
            List<Brands> brands = new List<Brands>
            {
                new Brands{Id=1 , Name="BMW"},
                new Brands{Id=2 , Name="Khazar"},
                new Brands{Id=3 , Name="Mercedes"},
                new Brands{Id=4 , Name="Vaz"},
            };
            List<Model> models = new List<Model>
            {
                new Model{Id=1 , Name="X5"},
                new Model{Id=2 , Name="X6"},
                new Model{Id=3 , Name="F30"},
                new Model{Id=4 , Name="F10"},
            };

            HomeViewModels homeVM = new HomeViewModels
            {
                Cars = cars,
                Brands = brands,
                Model = models

            };
            return View(homeVM);
        }
    }
}
