using System;

namespace GameJobs
{
    class Program
    {
        static void Main(string[] args)
        {
            Mage john = new Mage("John", 6, 5);
            Paladin enya = new Paladin("Enya", 9, 10);
            Priest bob = new Priest("Bob", 7, 6);
            Warrior christina = new Warrior("Christina", 12, 12);

            Riposte(enya);
            Riposte(christina);
            Fireball(john);
        }

        static void Riposte(IOneHandedWeapons duelist)
        {
            Console.WriteLine("Only a skilled combatant can pull off a riposte!");
        }

        static void Fireball(ISpellcasting caster)
        {
            Console.WriteLine("Try creating a ball of fire from nothing without learning to cast spells. I dare you.");
        }
    }
}
