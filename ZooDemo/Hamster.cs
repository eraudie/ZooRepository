using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    class Hamster : Animal
    {
        public Hamster():base(1)
        {

        }

        public override void MakeDeathScream()
        {
            Console.WriteLine("SQUEAK");
        }
    }
}
