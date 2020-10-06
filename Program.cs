using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Henric", "111222333");

            SavingsAccount savings = new SavingsAccount(0.03d, "Tom", "665544");

            CreditAccount credAccount = new CreditAccount("Henric", "111222333", 1000d);

            var sum = credAccount.Withdraw(800);

            Console.WriteLine($"Nu har vi ett saldo på {sum} på kreditkontot");
            credAccount.Deposit(100);

            sum = credAccount.Withdraw(200);

            Console.WriteLine($"Nu har vi ett saldo på {sum} på kreditkontot");

            Console.WriteLine($"Vi sätter in pengar och har {account.Deposit(500)} på vårt vanliga konto");
            
            Console.WriteLine($"Vi sätter in pengar och har {savings.Deposit(800)} på vårt sparkonto som kan använda Deposit-metoden från basklassen.");

            Console.ReadLine();

        }
    }
}
