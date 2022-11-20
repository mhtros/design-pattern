using Visitor.Expressions;

namespace Visitor.Visitors;

public interface IVisitor
{
    public void Visit(IntExpression expression);

    public void Visit(AdditionExpression expression);
}