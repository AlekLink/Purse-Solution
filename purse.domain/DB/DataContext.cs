using System.Data.Entity;
using purse.domain.DB.Models;

namespace purse.domain.DB
{
    public class DataContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Purse> Purses { get; set; }
        public DbSet<PurseAccount> PurseAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        
    }
}
