namespace Command;

public class BankAccountCommand : ICommand
{
    public enum BankAction
    {
        Deposit,
        Withdraw
    }

    private readonly BankAction _action;
    private readonly decimal _amount;

    private readonly BankAccount _bankAccount;

    public BankAccountCommand(BankAccount bankAccount, BankAction action, decimal amount)
    {
        _bankAccount = bankAccount;
        _action = action;
        _amount = amount;
    }

    public void Execute()
    {
        switch (_action)
        {
            case BankAction.Deposit:
                _bankAccount.Deposit(_amount);
                break;
            case BankAction.Withdraw:
                _bankAccount.Withdraw(_amount);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}