using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ZooDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat( 2.5);
            var dog = new Dog( 10);
            var hamster = new Hamster();
            cat.Eat(hamster);
            dog.Eat(cat);
            var topDog = new Dog(1.5);
            topDog.Eat(dog);
            Console.WriteLine(dog.Weight);
            Console.WriteLine(dog.Weight);
            Console.WriteLine(cat.Weight);
            Console.WriteLine(hamster.Weight);
            Console.WriteLine(topDog.Weight);
            //var animals = new List<Animal>();
            //animals.Add(cat);
            //animals.Add(dog);
        }
    }
} 