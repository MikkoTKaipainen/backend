using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTask1.Models;

namespace WebApiTask1.Services
{
    public interface IPersonService
    {
        Person Create(Person person); //Creates a person to database
        List<Person> Read(); //Search all persons to a list
        Person Read(int id); //Search person by id
        Person Update(int id, Person person); //Updates person by getting id and returns whole person 
        void Delete(int id); //deletes person by id and removes whole person
    }
}
