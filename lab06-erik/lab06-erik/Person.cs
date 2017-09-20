using System;
using System.Collections.Generic;
using System.Text;

namespace lab06_erik
{
    class Person : IRide, ISafty
    {   
        public string Name { get; set; }

        public Person(string input)
        {
            Name = input;
        }

        public void Helmet()
        {
            Console.WriteLine("Helmet on");
        }

        public void Peddel()
        {
            Console.WriteLine("Golly! I'm riding a Bike!");
        }
    }
}
