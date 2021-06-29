using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Tiger : ABSAnimal
    {
        public Tiger(string name, int count, string gender)
        {
            Name = name;
            Count = count;
            GenderType = gender;
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void Eat(string food)
        {
            throw new NotImplementedException();
        }

        public override void Eat(string food, string how)
        {
            throw new NotImplementedException();
        }
    }
}
