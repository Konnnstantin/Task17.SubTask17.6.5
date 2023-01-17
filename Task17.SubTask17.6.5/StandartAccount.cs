using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.SubTask17._6._5
{
    public class StandartAccount : IAccount
    {
        Account account;

        public void CalculateInterest(Account account)
        {
            Random random = new Random();

            account.Type = "Обычный";
            account.Balance = random.Next(100, 500);
            account.Interest = random.Next(0, 10);

            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance < 50000)
                account.Interest -= account.Balance * 0.4;

            Console.WriteLine($"Ваша процентная ставка равна {account.Interest}");
        }
    }
}
