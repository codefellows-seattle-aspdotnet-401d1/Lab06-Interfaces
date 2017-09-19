using System;

namespace Lab06George
{
    abstract class Person
    {
        internal abstract string Name { get; }
        internal void Ruin() => Console.WriteLine("I can ruin the food.");
    }
}
