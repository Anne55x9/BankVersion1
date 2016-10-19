using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            BankAccount BankAccount1 = new BankAccount();



            Console.WriteLine($"Account holders name is: {BankAccount1.Getname()}. The balance on the account is: {BankAccount1.GetBalance()} kr");

            BankAccount1.AddDeposit(25);

            Console.WriteLine($"Account holder name is: {BankAccount1.Getname()}. The balance on the account is: {BankAccount1.GetBalance()} kr");

            BankAccount1.AddWithdrawel(200);

            Console.WriteLine($"Account holder name is: {BankAccount1.Getname()}. The balance on the account is: {BankAccount1.GetBalance()} kr");
            // The LAST line of code should be ABOVE this line
        }
    }
}
