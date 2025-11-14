namespace Pokemon.Simulation.Pokemons;

internal class Ivysaur(List<Attack> attacks, int level)
    : GrassPokemon("Ivysaur", attacks, level), IEvolvable
{
    public int EvolveAtLevel => 18;

    public Pokemon Evolve()
    {
        Pokemon evolved = new Venusaur(Attacks, Level + 10);
        Console.WriteLine($"{Name} is evolving into {evolved.Name} and is now level {evolved.Level}!");
        return evolved;
    }
}
