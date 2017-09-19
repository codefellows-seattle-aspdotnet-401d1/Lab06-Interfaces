using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Group : IRaiders
    {
            public void DpsBoss()
            {
                Console.WriteLine("DPS thoughts");
                Console.WriteLine("Cares more about the meters");
            }

            public void HealingTank()
            {
                Console.WriteLine("Healer thoughts");
                Console.WriteLine("Dps do nothing but stand in fire");
            }

            public void TankingBoss()
            {
                Console.WriteLine("Tank thoughts");
                Console.WriteLine("Worship me as I play tank so that make me better than you");
            }

            public void StandInFire()
            {
                Console.WriteLine("Players forget all the times they stood in fire");
               
            }
        
    }
}
