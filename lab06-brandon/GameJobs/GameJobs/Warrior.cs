using System;
using System.Collections.Generic;
using System.Text;

namespace GameJobs
{
    class Warrior : Player
    {
        public void IsStrong()
        {
            Console.WriteLine($"{Name} is strong and tough.");
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with strength and skill.");
        }
    }
}
