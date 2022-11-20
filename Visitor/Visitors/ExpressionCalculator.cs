using Visitor.Expressions;

namespace Visitor.Visitors;

public class ExpressionCalculator : IVisitor
{
    public int Result;

    public void Visit(IntExpression expression)
    {
        Result += expression.Value;
    }

    public void Visit(AdditionExpression expression)
    {
        expression.LeftValue.Accept(this);
        expression.RightValue.Accept(this);
    }

    public override string ToString()
    {
        return Result.ToString();
    }
}