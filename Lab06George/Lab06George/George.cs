using System;

namespace Lab06George
{
    // inherits person and implements the IBake and Icook interfaces
    class George : Person, IBake, ICook
    {
        // name field
        internal override string Name { get { return "George"; } }
        // message to show ICook is inherited
        public void Cook() => Console.Write($"{Name} can cook well, ");
        // message to show IBake is inherited
        public void Bake() => Console.WriteLine("and also bake well.");
    }
}
