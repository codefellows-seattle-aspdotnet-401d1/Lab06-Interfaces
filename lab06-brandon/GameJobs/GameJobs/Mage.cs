using System;
using System.Collections.Generic;
using System.Text;

namespace GameJobs
{
    class Mage : Player, IOneHandedWeapons, IStaves, ISpellcasting
    {

        public void IsMystical()
        {
            Console.WriteLine($"{Name} vibrates with mystical power.");
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with arcane energy.");
        }

        public void HasKnowledge()
        {
            Console.WriteLine($"{Name} knows many esoteric and arcane things!");
        }

        public void HasIntelligence()
        {
            Console.WriteLine($"{Name} has a keen mind.");
        }

        public void HasWisdom()
        {
            Console.WriteLine($"{Name} appears poised and aware.");
        }

        public void HasDexterity()
        {
            Console.WriteLine($"{Name} works well with their hands.");
        }

        public void HasOneHandedSkill()
        {
            Console.WriteLine($"{Name} can get by with a knife.");
        }
    }
}
