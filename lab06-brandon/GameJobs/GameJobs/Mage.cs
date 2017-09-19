using System;
using System.Collections.Generic;
using System.Text;

namespace GameJobs
{
    class Mage : Player
    {

        public void IsMystical()
        {
            Console.WriteLine($"{Name} vibrates with mystical power.");
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with arcane energy.");
        }
    }
}
