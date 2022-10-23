namespace Command;

public class BankAccount
{
    private decimal _balance;

    public BankAccount(decimal balance = default)
    {
        _balance = balance;
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
        Console.WriteLine($"Balance: {_balance:N}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > _balance)
        {
            Console.WriteLine($"Balance: {_balance:N}");
            return;
        }

        _balance -= amount;
        Console.WriteLine($"Balance: {_balance:N}");
    }
}