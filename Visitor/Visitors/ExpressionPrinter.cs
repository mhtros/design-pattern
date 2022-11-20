using System.Text;
using Visitor.Expressions;

namespace Visitor.Visitors;

public class ExpressionPrinter : IVisitor
{
    private readonly StringBuilder _sb = new();

    public void Visit(IntExpression expression)
    {
        _sb.Append(expression.Value);
    }

    public void Visit(AdditionExpression expression)
    {
        _sb.Append('(');
        expression.LeftValue.Accept(this);
        _sb.Append('+');
        expression.RightValue.Accept(this);
        _sb.Append(')');
    }

    public override string ToString()
    {
        return _sb.ToString();
    }
}