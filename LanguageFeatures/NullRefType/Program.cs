using System;

namespace Bnaya.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new []{
                new Person { FirstName = "Bnaya", LastName = "Eshet"},
                new Person { FirstName = "Joe", MiddleNames = new []{ "Lee" }, LastName = "Cocker" }
            };

            Exec(people);

            Console.ReadKey();
        }

        private static void Exec(Person[] people)
        {
            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName}, {person.MiddleNames[0]}, {person.LastName} ");
            }
        }
    }
}
