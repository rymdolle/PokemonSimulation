namespace Pokemon.Simulation.Pokemons;

internal class Bulbasaur(List<Attack> attacks, int level)
    : GrassPokemon("Bulbasaur", attacks, level), IEvolvable
{
    public int EvolveAtLevel => 7;
    public Pokemon Evolve()
    {
        Pokemon evolved = new Ivysaur(Attacks, Level + 10);
        Console.WriteLine($"{Name} is evolving...");
        evolved.Speak();
        Console.WriteLine($"Now it's a {evolved.Name} at level {evolved.Level}!");
        return evolved;
    }

    public override void Speak()
    {
        Console.WriteLine($"{Name} says: Bulba-sa-ur!");
    }
}
