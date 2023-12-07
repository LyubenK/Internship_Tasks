using Bank_Task;

var savingAccount = new SavingBankAccount(590);

savingAccount.Deposit(100);
savingAccount.Deposit(300);

savingAccount.Wndraw(100);

Console.WriteLine(savingAccount.GetBalance()); 

savingAccount.Wndraw(1000);

Console.ReadLine();