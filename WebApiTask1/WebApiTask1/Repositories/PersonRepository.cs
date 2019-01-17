using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTask1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiTask1.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PersondbContext context;

        public PersonRepository(PersondbContext context)
        {
            this.context = context;
        }

        public Person Create(Person person)
        {
            context.Add(person);
            context.SaveChanges();
            return person;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        //Select * from person
        public List<Person> Read()
        {
            //return context.Person
            //  .Include(p => p.Phone)
            //  .FirstOrDefault(p => p.Id == id);
            return context.Person.FromSql("Select * From Person").ToList();
        }

        //Select * from person where ID = id
        public Person Read(int id)
        {
            return context.Person
                .Include(p=>p.Phone)
                .FirstOrDefault(p => p.Id == id);
        }

        public Person Update(int id, Person person)
        {
            var updatedPerson = Read(id);
            if (updatedPerson == null)
                throw new Exception("Person not found");
            else
            {
                context.Update(person);
                context.SaveChanges();
            }
            return person;
        }
    }
}
