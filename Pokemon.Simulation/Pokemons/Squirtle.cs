namespace Pokemon.Simulation.Pokemons;

internal class Squirtle(List<Attack> attacks, int level)
    : WaterPokemon("Squirtle", attacks, level), IEvolvable
{
    public int EvolveAtLevel => 8;

    public Pokemon Evolve()
    {
        Pokemon evolved = new Wartortle(Attacks, Level + 10);
        Console.WriteLine($"{Name} is evolving into {evolved.Name} and is now level {evolved.Level}!");
        return evolved;
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Squirt! Squirtle!");
    }
}
