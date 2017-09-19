using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Raid : Guild, IBosses, IRaiders
    {

        public override void RaidTime()
        {
            Console.WriteLine("Raid time is 6:00pm come prepared!");
        }

        public override void MaterialFarming()
        {
            Console.WriteLine("Spend all my spare time farming herbs and making potions");
        }

        public void AttackPlayers()
        {
            Console.WriteLine("The Dragon charges forward");
        }

        public void TauntsPlayers()
        {
            Console.WriteLine("Dragon says puny mortals!");
        }

        public void ThrowsFire()
        {
            Console.WriteLine("Dragon fills the room with fire");
        }

        public void DpsBoss()
        {
            Console.WriteLine("Im a firin mah lazar!!");
        }

        public void TankingBoss()
        {
            Console.WriteLine("This Dragon keeps hitting my face!!");
        }

        public void HealingTank()
        {
            Console.WriteLine("Healing is a pain too many noobs stand in fire!");
        }

        public void StandInFire()
        {
            Console.WriteLine("The rogue stood in fire?");
           
        }

        public void DropItems()
        {
            Console.WriteLine("Epic loot drops we all roll need!!");
        }
    }

}
