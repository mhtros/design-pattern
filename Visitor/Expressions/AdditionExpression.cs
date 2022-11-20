using Visitor.Visitors;

namespace Visitor.Expressions;

public class AdditionExpression : IExpression
{
    public readonly IExpression LeftValue;
    public readonly IExpression RightValue;

    public AdditionExpression(IExpression leftValue, IExpression rightValue)
    {
        LeftValue = leftValue;
        RightValue = rightValue;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}