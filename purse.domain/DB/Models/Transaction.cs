using System;

namespace purse.domain.DB.Models
{
    public class Transaction
    {
        public Guid id { get; set; }
        public string Title { get; set; }        
    }
}