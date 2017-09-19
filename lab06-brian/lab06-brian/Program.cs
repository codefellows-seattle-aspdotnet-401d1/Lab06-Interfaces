using System;

namespace lab06_brian
{

    class Program
    {
        static void Main(string[] args)
        {
            Simba simba = new Simba();
            simba.Name = "Simba";
            simba.IsPrideLeader();

            Garfeild garfeild = new Garfeild();
            garfeild.Name = "Garfeild";
            garfeild.IsPrideLeader();
            garfeild.CanUseToilet();
            Console.Read();
        }
    }
}
