using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ISafety
    {
        int NumberOfAirBags { get; set; }

        bool BlindSpotWarning { get; set; }

        void SeatBelt();
    }
}
