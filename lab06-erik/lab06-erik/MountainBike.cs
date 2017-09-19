using System;
using System.Collections.Generic;
using System.Text;

namespace lab06_erik
{
    class MountainBike : Bike, IRide
    {
        public void Ride(IRide person)
        {
            person.Peddel();
        }
    }
}
