using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTask1.Models;
using WebApiTask1.Repositories;
using WebApiTask1.Utilities;

namespace WebApiTask1.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Person Create(Person person)
        {
            person.Psw = PasswordHash.HashPassword(person.Psw, "QWERTY");
            return _personRepository.Create(person);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> Read()
        {
            return _personRepository.Read();
        }

        public Person Read(int id)
        {
            return _personRepository.Read(id);
        }

        public Person Update(int id, Person person)
        {
            var updatedPerson = _personRepository.Read(id);
            if (updatedPerson == null)
                throw new Exception("Person not found");

            person.Psw = PasswordHash.HashPassword(person.Psw, "QWERTY");
            return _personRepository.Update(person);
        } 
    }
}

