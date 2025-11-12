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
            new Charmander([scratch, ember]),
            new Bulbasaur([tackle, vineWhip]),
            new Squirtle([tackle, waterGun]),
            new Snorlax([tackle]),
        ];

        foreach (Pokemon pokemon in pokemons)
        {
            Console.WriteLine($"A wild {pokemon.Name} appeared!");
            pokemon.Attack();
            pokemon.RaiseLevel();
            if (pokemon is IEvolvable evolvable)
            {
                evolvable.Evolve();
            }
            Console.WriteLine();
        }
    }
}
