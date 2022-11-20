using Visitor.Visitors;

namespace Visitor.Expressions;

public class IntExpression : IExpression
{
    public readonly int Value;

    public IntExpression(int value)
    {
        Value = value;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}