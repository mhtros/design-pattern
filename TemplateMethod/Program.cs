using TemplateMethod;
using TemplateMethod.Games;

var c1 = new Creature(1, 1);
var c2 = new Creature(2, 2);

var creatures = new[] {c1, c2};

CardGame game = new TemporaryCardDamageGame(creatures);
PrintWinner(game.Combat(0, 1));

game = new PermanentCardDamage(creatures);
PrintWinner(game.Combat(0, 1));

void PrintWinner(int winnerIndex)
{
    const string tie = "The combat result to tie.";
    var winner = $"Winner is the 'c{++winnerIndex}' creature.";

    Console.WriteLine(winnerIndex == -1 ? tie : winner);
}