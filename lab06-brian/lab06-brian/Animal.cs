using System;

namespace lab06_brian
{
    internal abstract class Animal
    {
        internal void Eat(string whatIEat)
        {
            Console.WriteLine($"I really love to eat {whatIEat}");
        }
    }
}
