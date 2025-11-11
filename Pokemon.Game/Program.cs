namespace Pokemon.Game;

internal class Program
{
    static void Main(string[] args)
    {
        Attack flamethrower = new("Flamethrower", ElementType.Fire, 12);
        Attack ember = new("Ember", ElementType.Fire, 6);
    }
}
