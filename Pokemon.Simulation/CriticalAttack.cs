namespace Pokemon.Simulation;

internal class CriticalAttack : Attack
{
    public int Multiplier { get; } = 2;

    public CriticalAttack(Attack attack) : base(attack.Name, attack.Type, attack.BasePower)
    {
        Name += " [Critical]";
    }

    public override void Use(int level)
    {
        int totalPower = (BasePower + level) * Multiplier;
        Console.WriteLine($"{Name} landed a CRITICAL HIT! Total power is {totalPower}");
    }
}
