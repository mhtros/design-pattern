namespace TemplateMethod.Games;

public abstract class CardGame
{
    private readonly Creature[] _creatures;

    protected CardGame(Creature[] creatures)
    {
        _creatures = creatures;
    }

    // returns -1 if no clear winner (both alive or both dead)
    public int Combat(int creature1, int creature2)
    {
        var first = _creatures[creature1];
        var second = _creatures[creature2];

        Hit(first, second);
        Hit(second, first);

        var firstAlive = first.Health > 0;
        var secondAlive = second.Health > 0;

        if (firstAlive == secondAlive) return -1;
        return firstAlive ? creature1 : creature2;
    }

    // attacker hits other creature
    protected abstract void Hit(Creature attacker, Creature other);
}