using System;

namespace lab06_brian
{
    internal class Simba : Wild, IPrideLeader
    {
        public string Name { get; set; }
        public void IsPrideLeader()
        {
            Console.WriteLine($"My name is {this.Name}");
        }
    }
}
