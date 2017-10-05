using System;

namespace lab06_erik
{
    class Program
    {
        static void Main(string[] args)
        {
            MountainBike mybike = new MountainBike();
            Person player1 = new Person("Erik");

            Console.WriteLine($"{player1.Name} is getting ready to got on a bike ride..");

            Console.WriteLine($"first we check if the bike has {mybike.Wheels()} wheels");
            player1.Helmet();
            mybike.Ride(player1);

            Console.Read();

        }
    }
}
