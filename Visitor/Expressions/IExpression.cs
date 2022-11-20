using Visitor.Visitors;

namespace Visitor.Expressions;

public interface IExpression
{
    public void Accept(IVisitor visitor);
}