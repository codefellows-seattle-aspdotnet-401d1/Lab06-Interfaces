using System;
using System.Collections.Generic;
using System.Text;

namespace GameJobs
{
    class Priest : Player
    {

        public void IsHealy()
        {
            Console.WriteLine($"{Name} heals their allies with holy light.");
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} smites their foes with holy fire.");
        }
    }
}
