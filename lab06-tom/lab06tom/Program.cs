using System;

namespace lab06tom
{
    class Program
    {
        static void Main(string[] args)
        {
            Offense Tracer = new Offense("Lena Oxton", 26);
            Console.WriteLine($"{Tracer.Name} aka Tracer is an offense character and is {Tracer.Age} years old! Here are some things she can do:");

            Tracer.Aim(); //implemented from IShoot interface
            Tracer.Fire(); //implemented from IShoot interface
            Tracer.Reload(); //implemented from IShoot interface
            Tracer.Primary(); //implemented from IAbilities interface
            Tracer.Ultimate();

            Console.WriteLine();

            Defense Junkrat = new Defense("Jamison Fawkes", 25);
            Console.WriteLine($"{Junkrat.Name} aka Junkrat is a defense character and is {Junkrat.Age} years old! Here are some things he can do:");
            Junkrat.Aim(); //implemented from IShoot interface
            Junkrat.Fire(); //implemented from IShoot interface
            Junkrat.Reload(); //implemented from IShoot interface
            Junkrat.AbilityOne(); //implemented from IAbilities interface
            Junkrat.AbilityTwo(); //implemented from IAbilities interface


            Console.Read();

        }
    }
}
