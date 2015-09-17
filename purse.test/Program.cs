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
            try
            {
                using (DataContext context = new DataContext())
                {
                    var client = new Client
                    {
                        id = Guid.NewGuid(),
                        UserName = "a.shepelkin@gmail.com",
                        Sex = "Male",
                        FirstName = "Алексей",
                        MiddleName = "Андреевич",
                        LastName = "Шепелкин",
                        HomePhone = "(499)738-91-01",
                        MobilePhone = "(929)572-66-24",
                        Password = "#^TY0N0d",
                        Birthday = new DateTime(1987, 3, 10),
                        RegistrationDate = DateTime.UtcNow,

                    };
                    context.Clients.Add(client);
                    context.SaveChanges();

                    var query = context.Clients;

                    foreach (var c in query)
                    {
                        Console.WriteLine("{0} {1} {2}", c.LastName, c.FirstName, c.MiddleName);
                    }
                    Console.ReadLine();
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
