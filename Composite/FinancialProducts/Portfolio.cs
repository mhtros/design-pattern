namespace Composite.FinancialProducts;

public class Portfolio : IFinancialProduct
{
    private readonly List<IFinancialProduct> _products = new();

    public void AddProduct(IFinancialProduct product) => _products.Add(product);

    public void RemoveProduct(IFinancialProduct product) => _products.Remove(product);

    public decimal CalculateValue()
    {
        return _products.Sum(product => product.CalculateValue());
    }
}