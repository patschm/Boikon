using Boikon.Entities;
using Boikon.Interfaces;
using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Boikon.Repository.InMemory
{
    public class PersonRepository : IPersonRepository
    {
        private static List<Person> people;

        static PersonRepository()
        {
            people = Builder<Person>
                .CreateListOfSize(100)
                .All()
                //.With(p => p.FirstName = Faker.Name.First())
                //.With(p => p.LastName = Faker.Name.Last())
                //.With(p => p.Age = Faker.RandomNumber.Next(0, 123))
                .Build()
                .ToList();
        }

        public bool Delete(int id)
        {
            Person tmp = people.FirstOrDefault(px => px.ID == id);
            if (tmp == null) return false;
            people.Remove(tmp);
            return true;
        }

        public IQueryable<Person> Get()
        {
            return people.AsQueryable();
        }

        public bool Insert(Person p)
        {
            int hoogste = people.Max(px => px.ID);
            p.ID = hoogste + 1;
            people.Add(p);
            return true;
        }

        public bool Update(int id, Person p)
        {
            Person tmp = people.FirstOrDefault(px => px.ID == id);
            if (tmp == null) return false;
            tmp.FirstName = p.FirstName;
            tmp.LastName = p.LastName;
            tmp.Age = p.Age;
            return true;
        }
    }
}
