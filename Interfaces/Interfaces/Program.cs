using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's build a Honda");

            Minivan odessy = new Minivan();
            odessy.AirCon();
            odessy.BlindSpotWarning = true;
            odessy.Doors = 5;
            Console.WriteLine("Odessy has "+ odessy.Doors + " doors");
            Console.WriteLine("Odessy has "+ odessy.NumberCylindars + " cylindar engine.");

            Coup civic = new Coup();
            civic.AirCon();
            Console.WriteLine("Civic has turbo: " + civic.Turbo);
            Console.WriteLine("Civic has " + civic.Seats + " seats");
            civic.SeatBelt();

            Console.Read();
        }
    }
}
