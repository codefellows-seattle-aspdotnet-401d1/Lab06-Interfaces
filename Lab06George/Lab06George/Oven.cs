namespace Lab06George
{
    class Oven : Stove
    {
        internal void Bake(IBake baker) => baker.Bake();
    }
}
