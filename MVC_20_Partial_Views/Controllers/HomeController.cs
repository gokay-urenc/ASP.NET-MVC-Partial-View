using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_20_Partial_Views.Controllers
{
    using Models;
    public class HomeController : Controller
    {
        List<Car> cars = new List<Car>()
        {
            new Car(){ ID = 1, Marka = "Lincoln", Model = "Navigator" },
            new Car(){ ID = 2, Marka = "Mercedes", Model = "E 200" },
            new Car(){ ID = 3, Marka = "BMW", Model = "Navigator" }
        };

        public ActionResult Index()
        {
            ViewBag.Categories = new string[] { "Station", "Hatchback", "Sedan" };
            return View(cars);
        }

        public ActionResult _ArabalarPartial(int id)
        {
            return PartialView(cars.Where(x => x.ID == id));
        }
    }
}