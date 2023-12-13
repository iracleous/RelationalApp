using RelationalApp.Models;

namespace RelationalApp.Services
{
    public interface IPersoneService
    {

        public Person CreatePerson(Person person);
        public Person? ReadPerson(int personId);
        public IEnumerable<Person> ReadPerson();
        public bool UpdatePerson(int personId, PersonCategory newCategory);
        public bool DeletePerson(int personId);
    }
}
