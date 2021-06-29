using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZooProgram.Models;
using Framework;

namespace ZooProgram.Controllers
{
    public class PetAnimalsController : Controller
    {
        // GET: PetAnimals
        public ActionResult Index()
        {
            Dog dog = new Dog("Rajapalayam",5,"Male");
            Cat cat = new Cat("Country Cat",8,"Female");

            List<AnimalsViewModel> obj = new List<AnimalsViewModel>();
            obj.Add(new AnimalsViewModel(dog.Name,dog.Count,dog.GenderType));
            obj.Add(new AnimalsViewModel(cat.Name, cat.Count, cat.GenderType));
            return View(obj);
        }
    }
}