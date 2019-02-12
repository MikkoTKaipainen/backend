using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiBank.Repositories;
using WebApiBank.Services;
using WebApiBank.Models;

namespace WebApiBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService, ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            _customerService = customerService;
        }

        [HttpGet]
        public ActionResult<List<Customer>> ListAllCustomers()
        {
            var customers = _customerService.Read();
            return new JsonResult(customers);
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            var customers = _customerService.Read(id);
            return new JsonResult(customers);
        }

        [HttpPost]
        public ActionResult<Customer> Post(Customer customer)
        {
            var newCustomer = _customerService.Create(customer);
            return new JsonResult(newCustomer);
        }

        [HttpPut("{id}")]
        public ActionResult<Customer> Put(int id, Customer customer)
        {
            var updatedCustomer = _customerService.Update(id, customer);
            return updatedCustomer;
        }

        [HttpDelete("{id}")]
        public ActionResult<Customer> Delete(int id)
        {
            _customerRepository.Delete(id);
            return new NoContentResult();
        }

    }
}
