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
        private readonly PersondbContext _context;

        public PersonRepository(PersondbContext _context)
        {
            this._context = _context;
        }

        public Person Create(Person person)
        {
            _context.Add(person);
            _context.SaveChanges();
            return person;
        }

        public void Delete(int id)
        {
            var deletedPerson = Read(id);
            _context.Person.Remove(deletedPerson);
            _context.SaveChanges();
            return;
        }

        //Select * from person
        public List<Person> Read()
        {
            //return context.Person
            //  .Include(p => p.Phone)
            //  .FirstOrDefault(p => p.Id == id);
            return _context.Person.FromSql("Select * From Person").ToList();
        }

        //Select * from person where ID = id
        public Person Read(int id)
        {
            return _context.Person
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
                _context.Update(person);
                _context.SaveChanges();
            }
            return person;
        }
    }
}
