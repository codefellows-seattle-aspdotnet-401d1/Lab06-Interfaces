using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    class Dragon : Player, IFlying
    {
        public override void MoveBackward()
        {
            Console.WriteLine("Spyro moves backward.");
        }

        public override void MoveForward()
        {
            Console.WriteLine("Spyro moves forward.");

        }

        public override void RotateLeft()
        {
            Console.WriteLine("Spyro rotates left.");

        }

        public override void RotateRight()
        {
            Console.WriteLine("Spyro rotates right.");

        }

        public override void Run()
        {
            Console.WriteLine("Spyro's speed increases to a run.");

        }

        public override void Shoot()
        {
            Console.WriteLine("Spyro humbly wreaks his molten vengeance upon his foes.");

        }

        public void DecreaseAlt()
        {
            Console.WriteLine("Spyro decreases altitude.");
        }

        public void IncreaseAlt()
        {
            Console.WriteLine("Spyro increases altitude.");

        }

        public void TakeOff()
        {
            Console.WriteLine("Spyro takes flight!");

        }
    }
}
