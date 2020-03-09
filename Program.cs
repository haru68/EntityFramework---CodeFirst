using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/


            using (var context = new PersonContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var person = new Person();
                {
                    person.Name = "Richard";
                }

                person.SavingAccounts = new List<SavingAccount>()
                {
                    new SavingAccount { Amount = 2000000, InterestRate = 0.05m, InterestMonthInterval = 1 },
                    new SavingAccount { Amount = 250000, InterestRate = 0.15m, InterestMonthInterval = 12 },
                    new SavingAccount { Amount = 10000000, InterestRate = 0.02m, InterestMonthInterval = 12 },
                };

                context.Add(person);
                context.SaveChanges();

                DateTime startDate = DateTime.Now;
                DateTime endDate = startDate + TimeSpan.FromDays(365 * 2);

                decimal amount = SavingAccountCalculator.CalculateTotalSaved(startDate, endDate);


                MessageBox.Show("Gained interest: " + amount, "Useless message box", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

           

        }


    }
}
