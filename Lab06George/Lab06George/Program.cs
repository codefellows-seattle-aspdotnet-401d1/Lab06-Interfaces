using System;

namespace Lab06George
{
    class Program
    {
        static void Main(string[] args)
        {
            Lilly lilly = new Lilly();
            Gabby gabby = new Gabby();
            George george = new George();

            Oven oven = new Oven();
            Cooktop cooktop = new Cooktop();

            Console.WriteLine("IBake interface");
            oven.Bake(lilly);
            Console.WriteLine();
            Console.WriteLine("ICook interface");
            cooktop.Fry(gabby);
            Console.WriteLine();
            Console.WriteLine("ICook and Ibake interfaces");
            cooktop.Fry(george);
            oven.Bake(george);
            Console.WriteLine();
            Console.Read();
        }
    }
}
