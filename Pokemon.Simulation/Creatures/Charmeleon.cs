using Pokemon.Simulation.Creatures.Types;

namespace Pokemon.Simulation.Creatures;

internal class Charmeleon(List<Attack> attacks, int level)
    : FirePokemon("Charmeleon", attacks, level), IEvolvable
{
    public int EvolveAtLevel => 18;

    public Pokemon Evolve()
    {
        Pokemon evolved = new Charizard(Attacks, Level + 10);
        Console.WriteLine($"{Name} is evolving into {evolved.Name} and is now level {evolved.Level}!");
        return evolved;
    }
}
