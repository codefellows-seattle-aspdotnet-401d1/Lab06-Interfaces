using System;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Player Player1 = new Player();
            Player1.MoveForward();
            Player1.MoveBackward();
            Player1.RotateLeft();
            Player1.RotateRight();
            Player1.Crouch();
            Player1.Jump();
            Player1.Run();
            Player1.Shoot();
            Player1.Interact();
            Dragon Spyro = Player1.RideDragon();
            Spyro.MoveBackward();
            Spyro.RotateLeft();
            Spyro.RotateRight();
            Spyro.MoveForward();
            Spyro.Run();
            Spyro.TakeOff();
            Spyro.IncreaseAlt();
            Spyro.DecreaseAlt();
            Spyro.Shoot();
            Console.ReadLine();
       
    }
    }
}
