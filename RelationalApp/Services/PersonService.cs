using RelationalApp.Data;
using RelationalApp.Models;
using System;

namespace RelationalApp.Services
{
    public class PersonService : IPersoneService
    {

  
        private readonly RelationalDbContext _db;

        public PersonService(RelationalDbContext db)
        {
            _db = db;
        }

        public Person CreatePerson(Person person)
        {
            _db.Persons.Add(person);
            _db.SaveChanges();
            return person;
        }

        public bool DeletePerson(int personId)
        {
            throw new NotImplementedException();
        }

        public Person? ReadPerson(int personId)
        {
            return _db
                .Persons
                .Where(person => person.Id == personId).FirstOrDefault();
        }

        public IEnumerable<Person> ReadPerson()
        {
             return _db.Persons.ToList();
        }

        public bool UpdatePerson(int personId, PersonCategory newCategory)
        {
            Person? person = ReadPerson(personId);
            if (person == null) { return false; }
            person.Category = newCategory;
            _db.SaveChanges();
            return true;

        }
    }
}
