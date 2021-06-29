using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZooProgram.Models;
using Framework;

namespace ZooProgram.Controllers
{
    public class AquaticAnimalsController : Controller
    {
        // GET: PetAnimals
        public ActionResult Index()
        {
            Fish fish = new Fish("Blue Whale",5,"Male");
            Crocodile crocodile = new Crocodile("Crocodile Name",8,"Female");

            List<AnimalsViewModel> obj = new List<AnimalsViewModel>();
            obj.Add(new AnimalsViewModel(fish.Name, fish.Count, fish.GenderType));
            obj.Add(new AnimalsViewModel(crocodile.Name, crocodile.Count, crocodile.GenderType));
            return View(obj);
        }
    }
}