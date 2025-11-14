using Pokemon.Simulation.Creatures.Types;

namespace Pokemon.Simulation.Creatures;

internal class Charizard : FirePokemon
{
    public Charizard(List<Attack> attacks, int level)
        : base("Charizard", attacks, level)
    {
        for (int i = 0; i < Attacks.Count; i++)
        {
            Attack attack = Attacks[i];
            if (attack.Type == ElementType.Fire)
                Attacks[i] = new CriticalAttack(attack);
        }
    }
}
