namespace Pokemon.Simulation.Pokemons;

internal abstract class WaterPokemon : Pokemon
{
    public WaterPokemon(string name, List<Attack> attacks) : base(name, attacks)
    {
        Type = ElementType.Water;
    }
}
