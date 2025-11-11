namespace Pokemon.Game;

internal abstract class Pokemon(string name, List<Attack> attacks)
{
    private string _name = name;
    private int _level = 1;

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
        throw new NotImplementedException();
    }

    public void Attack()
    {
        throw new NotImplementedException();
    }

    public void RaiseLevel()
    {
        throw new NotImplementedException();
    }
}
