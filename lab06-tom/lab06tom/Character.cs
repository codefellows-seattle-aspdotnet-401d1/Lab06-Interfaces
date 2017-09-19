using System;
using System.Collections.Generic;
using System.Text;

namespace lab06tom
{
    abstract class Character
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public Character(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }

}
