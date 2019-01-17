using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTask1.Models;
using WebApiTask1.Repositories;

namespace WebApiTask1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonsController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        //Get api/persons
        [HttpGet]
        public ActionResult<List<Person>> GetAllPersons()
        {
            //var persons = new List<Person>
            //{                                                                                          
            //    new Person("Aku Ankka", 30),
            //    new Person("Roope Setä", 60)
            //};

            var persons = _personRepository.Read();
            return new JsonResult(persons);
        }

        //Get api/values/5
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            var persons = _personRepository.Read(id);
            return new JsonResult(persons);
        }

        //POST: api/persons
        [HttpPost("{id}")]
        public ActionResult<Person> Post(Person person)
        {
            var newPerson = _personRepository.Create(person);
            return new JsonResult(newPerson);
        }

        //PUT: api/persons/5
        [HttpPut("{Id}")]
        public ActionResult<Person> Put(int id, Person person)
        {
            var updatedPerson = _personRepository.Update(id, person);
            return new JsonResult(updatedPerson);
        }

        //DELETE/api/person/{id}
        [HttpDelete("{id}")]
        public ActionResult<Person> Delete(int id)
        {
            _personRepository.Delete(id);
            return new OkResult();
        }
    }
}