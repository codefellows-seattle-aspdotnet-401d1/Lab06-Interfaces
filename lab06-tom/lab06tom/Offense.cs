using System;
using System.Collections.Generic;
using System.Text;

namespace lab06tom
{
    class Offense : Character, IShoot, IAbilities
    {
        public Offense(string name, int age) : base(name, age)
        {

        }

        public void AbilityOne()
        {
            Console.WriteLine("Offense characters have an Ability 1");
        }

        public void AbilityTwo()
        {
            Console.WriteLine("Offense characters have an Ability 2");

        }

        public void Aim()
        {
            Console.WriteLine("Aiming...");
        }

        public void Fire()
        {
            Console.WriteLine("Pew pew pew!");
        }

        public void Primary()
        {
            Console.WriteLine("Offense characters have a Primary Fire");
        }

        public void Reload()
        {
            Console.WriteLine("Reloading!");
        }

        public void Ultimate()
        {
            Console.WriteLine("Offense characters have an Ultimate Ability");
        }
    }
}
