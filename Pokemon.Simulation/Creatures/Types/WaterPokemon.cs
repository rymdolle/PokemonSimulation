namespace Pokemon.Simulation.Creatures.Types;

internal abstract class WaterPokemon : Pokemon
{
    public WaterPokemon(string name, List<Attack> attacks, int level)
        : base(name, attacks, level)
    {
        Type = ElementType.Water;
    }
}
