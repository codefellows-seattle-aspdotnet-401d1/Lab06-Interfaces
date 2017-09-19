using System;

namespace Lab06George
{
    // inherits person and implements the ICook interface
    class Gabby : Person, ICook
    {
        // name field
        internal override string Name { get { return "Gabby"; } }
        // message to show ICook is inherited
        public void Cook() => Console.WriteLine($"{Name} can cook well.");
    }
}
