using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using purse.domain.DB.Models;

namespace purse.domain.DB
{
    public class DataContext  : DbContext
    {
        public DataContext()
            : base("name=PurseDBString")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
