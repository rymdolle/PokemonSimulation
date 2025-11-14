namespace Pokemon.Simulation;

internal class Attack(string name, ElementType type, int power)
{
    public string Name { get; protected set;  } = name;
    public ElementType Type { get; } = type;
    public int BasePower { get; } = power;

    public virtual void Use(int level)
    {
        Console.WriteLine($"{Name} hit with a total power of {BasePower + level}");
    }
}
