using System;
using System.Collections.Generic;
using FizzWare.NBuilder;
using System.Linq;

namespace Mensen
{
    class Program
    {
        static int OrderByAge(Person p)
        {
            return p.Age;
        }
        static string OrderByFirstName(Person p)
        {
            return p.FirstName;
        }
        static string OrderByLastName(Person p)
        {
            return p.LastName;
        }
        static bool LastNameStartingWithA(Person p)
        {
            return p.LastName.StartsWith("A");
        }
        static bool FirstNameStartingWithP(Person p)
        {
            return p.FirstName.StartsWith("P");
        }
        static void Main(string[] args)
        {
            List<Person> people = PopulateList();
            string f = "J";
            // Func<Person, TKey>
            //var resList = people.OrderBy(p=>p.Age);
            var resList = people.Where((p) =>p.FirstName.StartsWith(f));
            
            foreach(Person p in resList)
            {
                Console.WriteLine(p);
            }

            //Console.ReadLine();
        }

        private static List<Person> PopulateList()
        {
            return Builder<Person>.CreateListOfSize(1000)
                .All()
                .With(p=>p.FirstName = Faker.Name.First())
                .With(p => p.LastName = Faker.Name.Last())
                .With(p=>p.Age = Faker.RandomNumber.Next(0, 123))
                .Build()
                .ToList();
        }
    }
}
