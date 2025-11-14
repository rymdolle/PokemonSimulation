namespace Pokemon.Simulation.Pokemons;

internal class Wartortle(List<Attack> attacks, int level)
    : WaterPokemon("Wartortle", attacks, level), IEvolvable
{
    public int EvolveAtLevel => 17;

    public Pokemon Evolve()
    {
        Pokemon evolved = new Blastoise(Attacks, Level + 10);
        Console.WriteLine($"{Name} is evolving into {evolved.Name} and is now level {evolved.Level}!");
        return evolved;
    }
}
