using Pokemon.Simulation.Creatures;

namespace Pokemon.Simulation.Test;

public class PokemonTest
{
    [Fact]
    public void RaiseLevel_IncrementAndEvolve()
    {
        // Arrange
        Pokemon bulbasaur = new Bulbasaur([], level: 1);
        int evolveAt = (bulbasaur as IEvolvable)!.EvolveAtLevel;

        // Act
        for (int i = bulbasaur.Level; i < evolveAt; i++)
            bulbasaur = bulbasaur.RaiseLevel();

        // Assert
        Assert.Equal("Ivysaur", bulbasaur.Name);
    }
}
