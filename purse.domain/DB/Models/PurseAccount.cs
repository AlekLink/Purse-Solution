using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace purse.domain.DB.Models
{
    public class PurseAccount
    {
        public Guid id { get; set; }
        public string Title { get; set;}
        public int Money { get; set; }
        
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
