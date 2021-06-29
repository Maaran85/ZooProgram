using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public abstract class ABSAnimal
    {
        private string name;
        private int count;
        private string gender;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Count
        {

            get
            {
                return this.count;
            }

            set
            {
                this.count = value;
            }
        }

        public string GenderType
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }



        public ABSAnimal()
        {
            //initializing the private fields
            name = "default-animal";
            count = 5;
            gender = "Male";
          
        }

        public abstract void Eat();

        public abstract void Eat(string food);

        public abstract void Eat(string food, string how);

        public void Reproduce()
        {            
        }

        public void Move()
        {
        }

    }

}
