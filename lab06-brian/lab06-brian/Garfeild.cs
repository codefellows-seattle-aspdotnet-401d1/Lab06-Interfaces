using System;

namespace lab06_brian
{
    internal class Garfeild : Domestic, ICanUseToilet, IPrideLeader
    {
        public string Name { get; set; }
        public void CanUseToilet()
        {
            Console.WriteLine("I can use a toliet, can a wild cat do that? .... The answer is no because they don't have the right interface!");
        }

        public void IsPrideLeader()
        {
            Console.WriteLine($"My name is {Name} and i'm the leader of my pride. John does all my bidding!");
        }
    }
}
