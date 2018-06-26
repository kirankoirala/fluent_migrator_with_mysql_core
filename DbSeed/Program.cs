using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MySqlEf.Data.DbContext;
using MySqlEf.Data.Entity;

namespace DbSeed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (var db = new NewShopContext())
            {
                db.Database.Migrate();

                var user = new User
                {
                    Id = 1,
                    FirstName = "Naveen",
                    LastName = "Kanikaram"
                };
                db.Users.Add(user);

                var location = new Location
                {
                    Id = 1,
                    Address = "3100 Solena Blvd, Westlake TX",
                    PhoneNumber = "12345543"
                };
                db.Locations.Add(location);
                db.SaveChanges();

                Console.WriteLine($"in db user is {db.Users.First().FirstName} and location is {db.Locations.First().Address}");

               Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }


            //newDept.Deptno = 60;
            //newDept.Dname = "Development";
            //newDept.Loc = "Houston";
            //db.Dept.Add(newDept);
            //var count = db.SaveChanges();
            //Console.WriteLine("{0} records saved to database", count);

            //// Retrieving and displaying data
            //Console.WriteLine();
            //Console.WriteLine("All departments in the database:");
            //foreach (var dept in db.Dept)
            //{
            //    Console.WriteLine("{0} | {1}", dept.Dname, dept.Loc);
            //}
        }
    }
}
