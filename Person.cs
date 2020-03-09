using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class Person
    {
        public Guid PersonId { get; set; }
        public string Name { get; set; }
        public ICollection<SavingAccount> SavingAccounts { get; set; }
    }
}
