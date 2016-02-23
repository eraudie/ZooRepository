using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ZooDemo
{
    abstract class Animal : IEatable
    {
        public Animal(double weight)
        {
            Weight = weight;
        }
        public virtual void Eat(IEatable thingToEat)
        {
            this.Weight += thingToEat.Weight;
            thingToEat.MakeEatenSound();
            thingToEat.Weight = 0;
        }
        public abstract void MakeEatenSound();
        public double Weight { get; set; }
    }
}