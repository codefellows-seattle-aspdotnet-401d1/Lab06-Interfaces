namespace Lab06George
{
    class Cooktop : Stove
    {
        internal void Fry(ICook chef) => chef.Cook();
    }
}
