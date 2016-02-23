using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ZooDemo
{
    class Vegetable : IEatable
    {
        public double Weight { get; set; }
        public void MakeEatenSound()
        {
            Console.WriteLine("CRUNCH");
        }
    }
}