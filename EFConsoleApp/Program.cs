using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EFConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    BirthDate = new DateTime(2000, 1, 1)
                };

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added to the database.");
            }
        }
    }
}
