using System;
using System.Collections.Generic;
using System.Text;

namespace GameJobs
{
    class Paladin : Player
    {
        public void IsDivine()
        {
            Console.WriteLine($"{Name} is full of holy power.");
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with righteous fury.");
        }
    }
}
