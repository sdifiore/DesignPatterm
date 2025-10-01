using DesignPatterm;

//// Encapsulation
//BadBankAccount badBankAccoount = new BadBankAccount();
//badBankAccoount.Balance = -50;

//Console.WriteLine(badBankAccoount.Balance);

BankAccount bankAccount = new BankAccount(100);
Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);
Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(30);
Console.WriteLine(bankAccount.GetBalance());
