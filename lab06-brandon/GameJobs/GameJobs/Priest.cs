using System;
using System.Collections.Generic;
using System.Text;

namespace GameJobs
{
    class Priest : Player, IStaves, ISpellcasting
    {
        public Priest(string name, int maxHp, int defense)
        {
            Name = name;
            MaxHP = maxHp;
            CurrentHP = maxHp;
            Defense = defense;
        }

        public void IsHealy()
        {
            Console.WriteLine($"{Name} heals their allies with holy light.");
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} smites their foes with holy fire.");
        }

        public void HasKnowledge()
        {
            Console.WriteLine($"{Name} knows much about the divine.");
        }

        public void HasIntelligence()
        {
            Console.WriteLine($"{Name} is well read and often consumes texts.");
        }

        public void HasWisdom()
        {
            Console.WriteLine($"{Name} often displays common sense.");
        }
    }
}
