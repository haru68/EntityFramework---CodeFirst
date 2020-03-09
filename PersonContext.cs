using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace WindowsFormsApp1
{
    class PersonContext : DbContext
    {
        public virtual DbSet<SavingAccount> SavingAccounts { get; set; }
        public virtual DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=PC-HARU\SQLEXPRESS;Initial Catalog=Code_first;Integrated Security=True");
        }
    }
}
