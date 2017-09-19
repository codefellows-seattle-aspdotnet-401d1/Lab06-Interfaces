using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    class Player : GameCharacter, IMovement, IActions
    {
        public double Speed { get => 1; set { } }
        public int Input { get => 0; set  { } }

        public void Crouch()
        {
            Console.WriteLine("Player pops a squat.");
        }

        public void Interact()
        {
            Console.WriteLine("Player interacts with the da kine.");
        }

        public void Jump()
        {
            Console.WriteLine("Player jumps.");
        }

        public virtual void MoveBackward()
        {
            Console.WriteLine("Player moves backward.");
        }

        public virtual void MoveForward()
        {
            Console.WriteLine("Player moves forward.");

        }

        public void MoveLeft()
        {
            Console.WriteLine("Player moves left.");
        }

        public void MoveRight()
        {
            Console.WriteLine("Player moves Right.");
        }

        public void Reload()
        {
            Console.WriteLine("Player moves right.");

        }

        public virtual void RotateLeft()
        {
            Console.WriteLine("Player rotates left.");

        }

        public virtual void RotateRight()
        {
            Console.WriteLine("Player rotates right.");
   
        }

        public virtual void Run()
        {
            Console.WriteLine("Player's speed increases to a run.");

        }

        public virtual void Shoot()
        {
            Console.WriteLine("Player fires weapon.");
        }

        public Dragon RideDragon()
        {
            Console.WriteLine("Holy Carp! The player turned into a dragon!");
            return new Dragon();
        }
    }
}
