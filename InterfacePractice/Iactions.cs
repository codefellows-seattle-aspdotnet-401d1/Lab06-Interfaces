using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    interface IActions
    {
        int Input { get; set; }
        void Run();
        void Crouch();
        void Shoot();
        void Jump();
        void Interact();
        void Reload();

    }
}
