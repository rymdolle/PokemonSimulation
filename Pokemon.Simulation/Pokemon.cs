namespace Pokemon.Simulation;

internal abstract class Pokemon(string name, List<Attack> attacks)
{
    private string _name = name;
    private int _level = 1;
    private static readonly Random _random = new();

    public string Name {
        get => _name;
        set
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(value, "Pokemon name cannot be null or empty.");
            if (value.Length < 2 || value.Length > 15)
                throw new ArgumentOutOfRangeException("Pokemon name must be between 2 and 15 characters long.");
            _name = value;
        }
    }
    public int Level
    {
        get => _level;
        set
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(value, 1);
            _level = value;
        }
    }

    public ElementType Type { get; set; }
    public List<Attack> Attacks { get; } = attacks;

    public void RandomAttack()
    {
        int index = _random.Next(Attacks.Count);
        Attack? attack = Attacks.ElementAtOrDefault(index);
        attack?.Use(_level);
    }

    public void Attack()
    {
        throw new NotImplementedException();
    }

    public void RaiseLevel()
    {
        _level++;
        Console.WriteLine($"{Name} leveled up to {Level}!");
    }
}
