using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace WindowsFormsApp1
{
    static class SavingAccountCalculator
    {

        public static Decimal CalculateTotalSaved(DateTime lowIntervalDate, DateTime highIntervalDate)
        {
            decimal interestAmount = 0;
            DateTime calculatingDate = lowIntervalDate;
            TimeSpan timespanMonth = TimeSpan.FromDays(30);
            TimeSpan timespanYear = TimeSpan.FromDays(365);

            List<SavingAccount> savingAccounts;
            using (var context = new PersonContext())
            {
                savingAccounts = context.SavingAccounts.ToList();
            }

            foreach(SavingAccount savingAccount in savingAccounts)
            {
                if (savingAccount.InterestMonthInterval == 1)
                {
                    while (calculatingDate >= lowIntervalDate && calculatingDate <= highIntervalDate)
                    {
                        interestAmount = savingAccount.Amount * savingAccount.InterestRate;
                        calculatingDate = calculatingDate + timespanMonth;
                    }

                }
                else if (savingAccount.InterestMonthInterval == 12)
                {
                    while (calculatingDate >= lowIntervalDate && calculatingDate <= highIntervalDate)
                    {
                        interestAmount = savingAccount.Amount * savingAccount.InterestRate;
                        calculatingDate = calculatingDate + timespanYear;
                    }
                }
                Console.WriteLine("coucou");
            }

            

            return interestAmount;
        }
    }
}
