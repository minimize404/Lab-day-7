using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_6
{
    class Animal
    {
        public void PrintAnimal()
        {
            Console.WriteLine("I am an animal.");
        }
    }

    class Dog : Animal
    {
        public void PrintLegs()
        {
            Console.WriteLine("I have four legs.");
        }
    }
}
