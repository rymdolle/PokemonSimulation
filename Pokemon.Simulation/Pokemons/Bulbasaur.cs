namespace Pokemon.Simulation.Pokemons;

internal class Bulbasaur(List<Attack> attacks)
    : GrassPokemon("Bulbasaur", attacks), IEvolvable
{
    public void Evolve()
    {
        string oldName = Name;
        Name = "Ivysaur";
        Level += 10;
        Console.WriteLine($"{oldName} is evolving into {Name} and is now level {Level}!");
    }
}
