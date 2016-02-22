using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    class Dog : Animal
    {
        public Dog(double weight):base(weight)
        {
            
        }

        public override void Eat(Animal animalToEat)
        {
            this.Weight += 0.9 * animalToEat.Weight;
            animalToEat.MakeDeathScream();
            animalToEat.Weight = 0.1 * animalToEat.Weight;
            
        }

        public override void MakeDeathScream()
        {
            Console.WriteLine("HOWL");
        }
    }
}
