using System;
using System.Collections.Generic;
using System.Text;

namespace lab06tom
{
    class Defense : Character, IShoot, IAbilities
    {
        public Defense(string name, int age) : base(name, age)
        {
        }

        public void AbilityOne()
        {
            Console.WriteLine("Defense characters have an Ability 1");
        }

        public void AbilityTwo()
        {
            Console.WriteLine("Defense characters have an Ability 2");

        }

        public void Aim()
        {
            Console.WriteLine("Target acquired!");
        }

        public void Fire()
        {
            Console.WriteLine("Light them up!");
        }

        public void Primary()
        {
            Console.WriteLine("Defense characters have a Primary Fire");
        }

        public void Reload()
        {
            Console.WriteLine("Out of ammo!");
        }

        public void Ultimate()
        {
            Console.WriteLine("Defense characters have an Ultimate Ability");
        }
    }
}
