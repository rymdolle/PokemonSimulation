namespace Pokemon.Simulation;

internal abstract class Pokemon(string name, List<Attack> attacks)
{
    private string _name = name;
    private int _level = 1;
    private static readonly Random _random = new();

    public string Name {
        get => _name;
        protected set
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
        protected set
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(value, 1);
            _level = value;
        }
    }

    public ElementType Type { get; protected set; }
    public List<Attack> Attacks { get; } = attacks;

    public void RandomAttack()
    {
        int index = _random.Next(Attacks.Count);
        Attack? attack = Attacks.ElementAtOrDefault(index);
        attack?.Use(Level);
    }

    public void Attack()
    {
        while (true)
        {
            Console.WriteLine("Select an attack:");
            for (int i = 0; i < Attacks.Count; ++i)
            {
                Attack attack = Attacks[i];
                Console.WriteLine($"{i + 1}. {attack.Name} (Type: {attack.Type}, Power: {attack.BasePower})");
            }
            int randomAttackIndex = Attacks.Count + 1;
            Console.WriteLine($"{randomAttackIndex}. Random attack");
            Console.WriteLine("0. Abort");

            string input = Console.ReadLine() ?? string.Empty;
            if (int.TryParse(input, out int choice))
            {
                if (choice == 0)
                {
                    Console.WriteLine("Attack aborted.");
                    return;
                }
                if (choice == randomAttackIndex)
                {
                    RandomAttack();
                    return;
                }
                if (choice >= 1 && choice <= Attacks.Count)
                {
                    Attack selectedAttack = Attacks[choice - 1];
                    selectedAttack.Use(Level);
                    return;
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Try again.");
            Console.ResetColor();
        }
    }

    public void RaiseLevel()
    {
        Level++;
        Console.WriteLine($"{Name} leveled up to {Level}!");
    }
}
