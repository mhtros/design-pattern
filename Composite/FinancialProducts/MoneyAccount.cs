namespace Composite.FinancialProducts;

public class MoneyAccount : IFinancialProduct
{
    private decimal _balance;

    public MoneyAccount()
    {
        _balance = 0;
    }

    public MoneyAccount(decimal startingBalance)
    {
        _balance = Math.Abs(startingBalance);
    }

    public void Deposit(decimal amount) => _balance += amount;

    public void Withdraw(decimal amount)
    {
        var newBalance = _balance - amount;

        if (newBalance < 0) throw new Exception("Insufficient Balance.");

        _balance = newBalance;
    }

    public decimal CalculateValue()
    {
        return _balance;
    }
}