namespace Composite.FinancialProducts;

public class Stock : IFinancialProduct
{
    public string Name { get; }

    public int NumberOfShares { get; }

    public decimal ShareAmount { get; }

    public Stock(string name, int numberOfShares, decimal shareAmount)
    {
        Name = name;
        NumberOfShares = Math.Abs(numberOfShares);
        ShareAmount = Math.Abs(shareAmount);
    }

    public decimal CalculateValue()
    {
        return NumberOfShares * ShareAmount;
    }
}