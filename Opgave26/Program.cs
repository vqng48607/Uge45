using System;
namespace Opgave26
{

    class Program
    {
        static void Main()
        {
            var firstName = new FirstName("Mikkel");
            var lastName = new LastName("Jensen");
            var age = new Age(25);
            var cpr = new CprNumber("0102031214");

            var person = new Person(firstName, lastName, age, cpr);

            Console.WriteLine($"First Name: {person.GetFirstName()}");
            Console.WriteLine($"Last Name: {person.GetLastName()}");
            Console.WriteLine($"Age: {person.GetAge()}");
            Console.WriteLine($"CPR Number: {person.GetCprNumber()}");
        }
    }
}