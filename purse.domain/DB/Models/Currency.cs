﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace purse.domain.DB.Models
{
    public class Currency
    {
        public Guid id { get; set;  }
        public string Title { get; set; }
        public string Value { get; set; }

        public virtual ICollection<CheckingAccount> CheckingAccounts{ get; set; }
    }
}
