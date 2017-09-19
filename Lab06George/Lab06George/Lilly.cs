using System;

namespace Lab06George
{
    // inherits person and implements the IBake interface
    class Lilly : Person, IBake
    {
        // name field
        internal override string Name { get { return "Lilly"; } }
        // message to show IBake is inherited
        public void Bake() => Console.WriteLine($"{Name} can bake well.");
    }
}
