using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    interface IEatable
    {
        double Weight { get; set; }
        void MakeEatenSound();
    }
}
