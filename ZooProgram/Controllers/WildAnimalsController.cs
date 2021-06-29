using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZooProgram.Models;
using Framework;

namespace ZooProgram.Controllers
{
    public class WildAnimalsController : Controller
    {
        // GET: PetAnimals
        public ActionResult Index()
        {
            Lion lion = new Lion("Lion Name", 6, "Male");
            Tiger tiger = new Tiger("Tiger Name", 4, "Female");
            Elephant elephant = new Elephant("Elephant Name", 9, "Female");
            Zebra zebra = new Zebra("Zebra Name",8,"Male");
            Monkey monkey = new Monkey("Monkey", 45, "Male");

            List<AnimalsViewModel> obj = new List<AnimalsViewModel>();
            obj.Add(new AnimalsViewModel(zebra.Name, zebra.Count, zebra.GenderType));
            obj.Add(new AnimalsViewModel(monkey.Name, monkey.Count, monkey.GenderType));
            obj.Add(new AnimalsViewModel(lion.Name, lion.Count, lion.GenderType));
            obj.Add(new AnimalsViewModel(tiger.Name, tiger.Count, tiger.GenderType));
            obj.Add(new AnimalsViewModel(elephant.Name, elephant.Count, elephant.GenderType));
            return View(obj);
        }

        public ActionResult sample()
        {
            return View();
        }
    }
}