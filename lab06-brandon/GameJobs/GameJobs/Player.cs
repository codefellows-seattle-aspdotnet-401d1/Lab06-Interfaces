using System;
using System.Collections.Generic;
using System.Text;

namespace GameJobs
{
    abstract class Player
    {
        public string Name { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int Defense { get; set; }

        public abstract void Attack();
    }
}
