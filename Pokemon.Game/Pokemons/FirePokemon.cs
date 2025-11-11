
namespace Pokemon.Game.Pokemons;

internal abstract class FirePokemon : Pokemon
{
    public FirePokemon(string name, List<Attack> attacks) : base(name, attacks)
    {
        Type = ElementType.Fire;
    }
}
