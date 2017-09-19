using System;
using System.Collections.Generic;
using System.Text;

namespace GameJobs
{
    class Paladin : Player, IOneHandedWeapons, ITwoHandedWeapons, ISpellcasting
    {
        public void IsDivine()
        {
            Console.WriteLine($"{Name} is full of holy power.");
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with righteous fury.");
        }

        public void HasKnowledge()
        {
            Console.WriteLine($"{Name} knows much about the gods.");
        }

        public void HasIntelligence()
        {
            Console.WriteLine($"{Name} has read some books.");
        }

        public void HasStrength()
        {
            Console.WriteLine($"{Name} can lift a person with ease.");
        }

        public void HasTwoHandedSkill()
        {
            Console.WriteLine($"{Name} can swing two-handed weapons with ease and skill.");
        }

        public void HasDexterity()
        {
            Console.WriteLine($"{Name} won't get their fingers twisted up doing fine work.");
        }

        public void HasOneHandedSkill()
        {
            Console.WriteLine($"{Name} is an expert duelist.");
        }
    }
}
