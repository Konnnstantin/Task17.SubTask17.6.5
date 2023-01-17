using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.SubTask17._6._5
{
    public class SalaryAccount : IAccount
    {
        public void CalculateInterest(Account account)
        {
            Random rand = new Random();
            account.Type = "Зарплатный";
            account.Balance = rand.Next(20, 100);
            account.Interest = rand.Next(20, 6000);

            account.Interest = account.Balance * 0.5;

            Console.WriteLine($"Ваша процентная ставка равна {account.Interest}");
        }
    }
}
