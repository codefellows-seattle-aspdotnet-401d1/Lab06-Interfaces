using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IMotor
    {
        bool OilChange();

        int NumberCylindars { get; set; }

    }
}
