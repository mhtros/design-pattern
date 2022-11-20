using Visitor.Expressions;
using Visitor.Visitors;

var printer = new ExpressionPrinter();
var calculator = new ExpressionCalculator();

var expression = new AdditionExpression(
    new AdditionExpression(
        new IntExpression(1),
        new IntExpression(2)),
    new IntExpression(3));

printer.Visit(expression);
calculator.Visit(expression);

Console.WriteLine($"{printer} = {calculator.Result}");