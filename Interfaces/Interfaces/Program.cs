using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A fresh World of warcraft raid group");
            Console.WriteLine("");

            Group team1 = new Group();
            team1.DpsBoss(); //Implimented from IRaiders
            Console.WriteLine("");

            team1.HealingTank(); //Implimented from IRaiders
            Console.WriteLine("");

            team1.TankingBoss(); //Implimented from IRaiders
            Console.WriteLine("");

            team1.StandInFire(); //Implimented from IRaiders
            Console.WriteLine("");
            Console.WriteLine("");

            Raid karazhan = new Raid();
            Console.WriteLine("Charging into battle");


            karazhan.MaterialFarming();
            Console.WriteLine("");
            karazhan.RaidTime(); //Implimented from IBosses

            Console.WriteLine("");
            karazhan.AttackPlayers(); //Implimented from IBosses

            Console.WriteLine("");
            karazhan.TauntsPlayers(); //Implimented from IBosses

            Console.WriteLine("");
            karazhan.ThrowsFire(); //Implimented from IBosses
            
            Console.WriteLine("");
            karazhan.StandInFire(); //Implimented from IBosses

            Console.WriteLine("");
            karazhan.TankingBoss(); //Implimented from IRaiders

            Console.WriteLine("");
            karazhan.HealingTank(); //Implimented from IRaiders

            Console.WriteLine("");
            karazhan.DpsBoss(); //Implimented from IRaiders

            Console.WriteLine("");
            karazhan.DropItems(); //Implimented from IBosses

            Console.Read();
        }
    }
}
