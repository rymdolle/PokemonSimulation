using Pokemon.Simulation.Pokemons;

namespace Pokemon.Simulation;

internal class Program
{
    static void Main(string[] args)
    {
        Attack scratch = new("Scratch", ElementType.Normal, power: 16);
        Attack ember = new("Ember", ElementType.Fire, power: 14);
        Attack tackle = new("Tackle", ElementType.Normal, power: 12);
        Attack vineWhip = new("Vine Whip", ElementType.Grass, power: 16);
        Attack waterGun = new("Water Gun", ElementType.Water, power: 16);

        List<Pokemon> pokemons = [
            new Charmander(attacks: [scratch, ember], level: 1),
            new Bulbasaur(attacks: [tackle, vineWhip], level: 4),
            new Squirtle(attacks: [tackle, waterGun], level: 1),
            new Snorlax(attacks: [tackle], level: 1),
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
