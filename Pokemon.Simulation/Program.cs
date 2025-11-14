using Pokemon.Simulation.Pokemons;

namespace Pokemon.Simulation;

internal class Program
{
    static void Main(string[] args)
    {
        Attack scratch = new("Scratch", ElementType.Normal, 16);
        Attack ember = new("Ember", ElementType.Fire, 14);
        Attack tackle = new("Tackle", ElementType.Normal, 12);
        Attack vineWhip = new("Vine Whip", ElementType.Grass, 16);
        Attack waterGun = new("Water Gun", ElementType.Water, 16);

        List<Pokemon> pokemons = [
            new Charmander([scratch, ember], 1),
            new Bulbasaur([tackle, vineWhip], 4),
            new Squirtle([tackle, waterGun], 1),
            new Snorlax([tackle], 1),
        ];

        for (int i = 0; i < pokemons.Count; i++)
        {
            Pokemon pokemon = pokemons[i];
            Console.WriteLine($"A wild {pokemon.Name} appeared!");
            pokemon.Attack();
            pokemons[i] = pokemon.RaiseLevel();
            Console.WriteLine();
        }
    }
}
