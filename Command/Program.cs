using Command;

var bankAccount = new BankAccount();

var commands = new List<BankAccountCommand>
{
    new(bankAccount, BankAccountCommand.BankAction.Deposit, 100m),
    new(bankAccount, BankAccountCommand.BankAction.Withdraw, 100m),
    new(bankAccount, BankAccountCommand.BankAction.Deposit, 50m)
};

foreach (var cmd in commands) cmd.Execute();