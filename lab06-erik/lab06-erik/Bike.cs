using System;
using System.Collections.Generic;
using System.Text;

namespace lab06_erik
{
    abstract class Bike
    {
        public virtual int Wheels()
        {
            int numWheels = 2;

            return numWheels;
        }
    }
}
