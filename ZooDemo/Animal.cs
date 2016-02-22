using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    abstract class Animal
    {
        public Animal(double weight)
        {
            Weight = weight;
        }

        public virtual void Eat(Animal animalToEat)
        {
            this.Weight += animalToEat.Weight;
            animalToEat.MakeDeathScream();
            animalToEat.Weight = 0;
        }
        public abstract void MakeDeathScream();
        public double Weight { get; set; }

        
    }
}
