using Boikon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Boikon.Interfaces
{
    public interface IPersonRepository
    {
        IQueryable<Person> Get();
        bool Insert(Person p);
        bool Update(int id, Person p);
        bool Delete(int id);
    }
}
