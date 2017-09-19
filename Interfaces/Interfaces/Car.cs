using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    abstract class Car
    {
        abstract public int Seats { get; set; }

        virtual public int Doors { get; set; }

        public bool AirCon()
        {
            return true;
        }

        abstract public int Wheels();

    }
}
