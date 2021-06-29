using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZooProgram.Models
{
    public class AnimalsViewModel
    {

        public string AnimalName;
        public int Count;
        public string Gender;

        public AnimalsViewModel(string name,int count,string gender)
        {
            AnimalName = name;
            Count = count;
            Gender = gender;
        }
    }
}