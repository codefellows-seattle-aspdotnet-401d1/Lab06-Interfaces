using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class SUV : Family
    {
        public bool AllWheelDrive
        {
            get
            {
                return true;
            }
            set
            {

            }
        }

        public int GroundClearance { get; set; }
        public override int Seats { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int Wheels()
        {
            throw new NotImplementedException();
        }
    }
}
