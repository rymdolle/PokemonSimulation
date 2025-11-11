namespace Pokemon.Game;

internal class Attack(string name, ElementType type, int power)
{
    public string Name { get; } = name;
    public ElementType Type { get; } = type;
    public int BasePower { get; } = power;

    public void Use(int level)
    {
        Console.WriteLine($"{Name} hit with a total power of {BasePower + level}");
    }
}
