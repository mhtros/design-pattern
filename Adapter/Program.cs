using Adapter;
using Adapter.Pegs;

var roundHole = new RoundHole(100);
Console.WriteLine($"[HOLE RADIUS: {roundHole.Radius}]");

var roundPeg = new RoundPeg(110);
Console.WriteLine("\nQ: Does ROUND peg fits into the round hole?");
Console.WriteLine($"A: {(roundHole.Fits(roundPeg) ? "YES" : "NO")} [RoundPeg Radius={roundPeg.Radius}]");

var squarePeg = new SquarePeg(120);
var adapter = new SquarePegAdapter(squarePeg);
Console.WriteLine("\nQ: Does SQUARE peg fits into the round hole?");
Console.WriteLine($"A: {(roundHole.Fits(adapter) ? "YES" : "NO")} [SquarePeg Radius={adapter.Radius}]");