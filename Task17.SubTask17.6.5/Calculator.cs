using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17.SubTask17._6._5
{
    public static class Calculator
    {
        public static void CalculateInterest(Account account)
        {
            if (account.Type == "Обычный" || account.Type == "обычный")
            {
                var standardAccount = new StandartAccount();
                standardAccount.CalculateInterest(account);
            }
            else if (account.Type == "Зарплатный" || account.Type == "зарплатный")
            {
                var salaryAccount = new SalaryAccount();
                salaryAccount.CalculateInterest(account);
            }

        }
    }
}
