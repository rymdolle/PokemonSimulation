namespace Pokemon.Simulation.Creatures.Types;

internal abstract class FirePokemon : Pokemon
{
    public FirePokemon(string name, List<Attack> attacks, int level)
        : base(name, attacks, level)
    {
        Type = ElementType.Fire;
    }
}
