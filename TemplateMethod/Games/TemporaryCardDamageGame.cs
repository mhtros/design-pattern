namespace TemplateMethod.Games;

public class TemporaryCardDamageGame : CardGame
{
    public TemporaryCardDamageGame(Creature[] creatures) : base(creatures)
    {
    }

    protected override void Hit(Creature attacker, Creature other)
    {
        var oldHealth = other.Health;
        other.Health -= attacker.Attack;
        if (other.Health > 0) other.Health = oldHealth;
    }
}