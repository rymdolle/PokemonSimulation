namespace Pokemon.Simulation.Pokemons;

internal class Charmander(List<Attack> attacks)
    : FirePokemon("Charmander", attacks), IEvolvable
{
    public void Evolve()
    {
        string oldName = Name;
        Name = "Charmeleon";
        Level += 10;
        Console.WriteLine($"{oldName} is evolving into {Name} and is now level {Level}!");
    }
}
