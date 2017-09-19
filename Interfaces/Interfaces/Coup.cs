using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Coup : Sport, IMotor, ISafety
    {
        public override int Seats { get { return 2; } set { } }

        public int NumberCylindars { get { return 4; } set { } }
        public int NumberOfAirBags { get { return 2; } set { } }
        public bool BlindSpotWarning { get { return true; } set { } }

        public bool OilChange()
        {
            Console.WriteLine("If mileage since last oil change is more than 3000 miles");
            return true;
        }

        public void SeatBelt()
        {
            Console.WriteLine("CLICK IT OR TICKET!  Also, the annoying warning chime won't stop untill you buckle."); ;
        }

        public override int Wheels()
        {
            return 4;
        }
    }
}
