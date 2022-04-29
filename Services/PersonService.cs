using projectwork.Repositories;
using projectwork.Models;

namespace projectwork.Services;


public class PersonService
{

    private PersonRepository personRepository = new PersonRepository();

    public IEnumerable<Person> GetPeople()
    {
        return personRepository.GetPeople();
    }

    public Person GetPerson(int id)
    {
        return personRepository.GetPerson(id);
    }

    public bool Create(Person person)
    {
        if (personRepository.GetPerson(person.id) == null)
        {
            
            {
                return personRepository.Create(person);
            }
        }
        else
        {
            return false;
        }

    }

    public bool Update(Person person)
    {
        return personRepository.Update(person);
    }

    public bool Delete(int id)
    {
        return personRepository.Delete(id);
    }


}