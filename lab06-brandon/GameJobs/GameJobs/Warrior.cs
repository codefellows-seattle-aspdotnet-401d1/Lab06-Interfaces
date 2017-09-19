using System;
using System.Collections.Generic;
using System.Text;

namespace GameJobs
{
    class Warrior : Player, IOneHandedWeapons, ITwoHandedWeapons
    {
        public Warrior(string name, int maxHp, int defense)
        {
            Name = name;
            MaxHP = maxHp;
            CurrentHP = maxHp;
            Defense = defense;
        }

        public void IsStrong()
        {
            Console.WriteLine($"{Name} is strong and tough.");
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with strength and skill.");
        }

        public void HasStrength()
        {
            Console.WriteLine($"{Name} can lift a horse.");
        }

        public void HasTwoHandedSkill()
        {
            Console.WriteLine($"{Name} swings two-handed weapons like a boss.");
        }

        public void HasDexterity()
        {
            Console.WriteLine($"{Name} can delicately handle small things.");
        }

        public void HasOneHandedSkill()
        {
            Console.WriteLine($"{Name} is a master of the single blade.");
        }
    }
}
