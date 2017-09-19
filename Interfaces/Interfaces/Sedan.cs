using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Sedan : Sport
    {
        public override int Doors { get => 4; set => base.Doors = value; }

        public bool autoMaticTrunk { get; set; }
        public override int Seats { get { return 4; } set {} }

        public override int Wheels()
        {
            return 4;
        }
    }
}
