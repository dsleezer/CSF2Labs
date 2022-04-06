using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace Labs1
{
    internal class LabTest1
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Luke", "Skywalker", "Bravo Leader", 4.0f);
            Student s2 = new Student();

            s2.FirstName = "Bob";
            s2.LastName = "Smith";
            s2.Id = "9875421";
            s2.Gpa = 2.6f;

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Vehicle v1 = new Vehicle("X-Wing", "Rebel", 3565, 5382.3f);
            Vehicle v2 = new Vehicle();

            v2.Weight = 4200;
            v2.Year = 1972;
            v2.Make = "Camaro";
            v2.Model = "Chevrolet";


            Console.WriteLine(v1);
            Console.WriteLine(v2);

            Login l1 = new Login("Force", "UseIt");
            Login l2 = new Login();

            l2.UserName = "Username";
            l2.Password = "12345";


            Console.WriteLine(l1);
            Console.WriteLine(l2);

            ContactInfo c1 = new ContactInfo("123 Desert Street", "Lars Farm", "Tatooine", "12345", "555-555-5555", "Luke.Skywalker@TheForce.com");
            ContactInfo c2 = new ContactInfo();

            c2.StreetAddress = "123 street";
            c2.City = "Centerville";
            c2.State = "Kansas";
            c2.ZipCode = "12345";
            c2.PhoneNumber = "555-555-5555";
            c2.Email = "email@emailserver.com";


            Console.WriteLine(c1);
            Console.WriteLine(c2);
        }
    }
}
