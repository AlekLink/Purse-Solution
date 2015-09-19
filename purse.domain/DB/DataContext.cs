using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using purse.domain.DB.Models;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace purse.domain.DB
{
    public class DataContext  : DbContext
    {
        public DataContext()
            : base("name=PurseDBString")
        {

        }

        public DbSet<Client> Clients { get; set;    }
        public DbSet<Purse> Purses { get; set; }
        public DbSet<CheckingAccount> CheckingAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Currency> Currencys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }

    }
}
