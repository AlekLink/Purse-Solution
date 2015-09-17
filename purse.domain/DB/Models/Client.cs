using System;

namespace purse.domain.DB.Models
{
    public class Client
    {
        public Guid id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
