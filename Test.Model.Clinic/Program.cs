using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoduriNomenclatoare;

namespace Test.Model.Clinic
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ClinicContext())
            {
                Console.WriteLine("Enter a name for Country name:");
                var name = Console.ReadLine();

                Console.WriteLine("Enter a value for Country code:");
                var code = Console.ReadLine();

                var country = new NomCountries
                {
                    Code = code,
                    Name = name
                };

                db.Countries.Add(country);
                db.SaveChanges();

                var query = from c in db.Countries
                            orderby c.Name
                            select c;

                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
