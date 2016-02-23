using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ZooDemo
{
    class Cat : Animal
    {
        public Cat(double weight):base(weight)
        {
        }
        public override void MakeEatenSound()
        {
            Console.WriteLine("MJAAAUUU");
        }
    }
}