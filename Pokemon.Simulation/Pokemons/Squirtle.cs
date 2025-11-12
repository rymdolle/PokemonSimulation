namespace Pokemon.Simulation.Pokemons;

internal class Squirtle(List<Attack> attacks)
    : WaterPokemon("Squirtle", attacks), IEvolvable
{
    public void Evolve()
    {
        string oldName = Name;
        Name = "Wartortle";
        Level += 10;
        Console.WriteLine($"{oldName} is evolving into {Name} and is now level {Level}!");
    }
}
