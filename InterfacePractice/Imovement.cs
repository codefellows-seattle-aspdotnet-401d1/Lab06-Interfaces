using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    interface IMovement
    {
        double Speed { get; set; }
        void MoveForward();
        void MoveBackward();
        void MoveLeft();
        void MoveRight();
        void RotateLeft();
        void RotateRight();
    }
}
