using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBank.Models;
using WebApiBank.Repositories;

namespace WebApiBank.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer Create(Customer customer)
        {
            return _customerRepository.Create(customer);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> Read()
        {
            return _customerRepository.Read();
        }

        public Customer Read(int id)
        {
            return _customerRepository.Read(id);
        }

        public Customer Update(int id, Customer customer)
        {
            var updatedCustomer = _customerRepository.Read(id);
            if (updatedCustomer == null)
                throw new Exception("Customer not found");
            return _customerRepository.Update(customer);
        }
    }
}
