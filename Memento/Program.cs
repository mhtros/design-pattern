using Memento.Originator;

var account = new BankAccount();

account.Deposit(100);
Console.WriteLine(account);

account.Deposit(200);
Console.WriteLine(account);

account.Withdraw(50);
Console.WriteLine(account);

account.Undo();
Console.WriteLine(account);

account.Undo();
Console.WriteLine(account);

account.Undo();
Console.WriteLine(account);

account.Redo();
Console.WriteLine(account);

account.Redo();
Console.WriteLine(account);

account.Redo();
Console.WriteLine(account);