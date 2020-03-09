using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class SavingAccount
    {
        public Guid SavingAccountId { get; set; }
        public decimal Amount { get; set; }
        public decimal InterestRate { get; set; }
        public int InterestMonthInterval { get; set; }
    }
}
