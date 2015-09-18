using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using purse.domain.DB;
using purse.domain.DB.Models;

namespace purse.test
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cl = new Client
            {
                id = Guid.NewGuid(),
                FirstName = "Алексей",
                MiddleName = "Андреевич",
                LastName = "Шепелкин",
                Login = "a.shepelkin@gmail.com",
                Password = "TEST"
            };
            try
            {
                using (DataContext context = new DataContext())
                {
                    context.Clients.Add(cl);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
        }
    }
}
