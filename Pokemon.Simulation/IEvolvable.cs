namespace Pokemon.Simulation;

internal interface IEvolvable
{
    public int EvolveAtLevel { get; }
    Pokemon Evolve();
}
