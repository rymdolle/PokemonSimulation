namespace Pokemon.Simulation.Pokemons;

internal abstract class GrassPokemon : Pokemon
{
    public GrassPokemon(string name, List<Attack> attacks) : base(name, attacks)
    {
        Type = ElementType.Grass;
    }
}
