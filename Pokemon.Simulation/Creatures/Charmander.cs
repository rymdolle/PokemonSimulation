using Pokemon.Simulation.Creatures.Types;

namespace Pokemon.Simulation.Creatures;

internal class Charmander(List<Attack> attacks, int level)
    : FirePokemon("Charmander", attacks, level), IEvolvable
{
    public int EvolveAtLevel => 8;
    public Pokemon Evolve()
    {
        Pokemon evolved = new Charmeleon(Attacks, Level + 10);
        Console.WriteLine($"{Name} has evolved into {evolved.Name}!");
        return evolved;
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Rrr-char!");
    }
}
