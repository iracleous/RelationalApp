using RelationalApp.Models;
using System;

namespace RelationalApp.Services
{
    public class PersonService : IPersoneService
    {

        private static readonly List<Person> _people =  [
               new Person()
               {
                   Id = 20,
                   Name = "Test",
                   Category = PersonCategory.PHYSICAL,
                   IsAdmin = false,
                   RegistrationDate = DateOnly.FromDateTime(DateTime.Now),
                   Balance = 0,
               } ,
            new Person()
            {
                Id = 22,
                Name = "George",
                Category = PersonCategory.INTERNET,
                IsAdmin = false,
                RegistrationDate = DateOnly.FromDateTime(DateTime.Now),
                Balance = 0,
            }
            ];


        public Person CreatePerson(Person person)
        {
           _people.Add(person);
            return person;
        }

        public bool DeletePerson(int personId)
        {
            Person? person = ReadPerson(personId);
            if (person == null) { return false; }
            _people.Remove(person);
            return true;
        }

        public Person? ReadPerson(int personId)
        {
            return  _people.Where(person => person.Id == personId).FirstOrDefault();
             
            
        }

        public IEnumerable<Person> ReadPerson()
        {
            return _people;
        }

        public bool UpdatePerson(int personId, PersonCategory newCategory)
        {
            Person? person = ReadPerson(personId);
            if (person == null) { return false; }
            person.Category = newCategory;
            return true;

        }
    }
}
