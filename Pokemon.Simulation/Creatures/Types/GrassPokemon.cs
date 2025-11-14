namespace Pokemon.Simulation.Creatures.Types;

internal abstract class GrassPokemon : Pokemon
{
    public GrassPokemon(string name, List<Attack> attacks, int level)
        : base(name, attacks, level)
    {
        Type = ElementType.Grass;
    }
}
