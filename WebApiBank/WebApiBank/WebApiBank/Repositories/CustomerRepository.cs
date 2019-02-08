using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBank.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiBank.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly BankdbContext _context;

        public CustomerRepository(BankdbContext context)
        {
            _context = context;
        }

        public Customer Create(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public void Delete(int id)
        {
            var deletedCustomer = Read(id);
            _context.Customer.Remove(deletedCustomer);
            _context.SaveChanges();
            return;
        }

        public List<Customer> Read()
        {
            return _context.Customer.FromSql("Select * From Customer").ToList();
        }

        public Customer Read(int id)
        {
            return _context.Customer
                .AsNoTracking()
                .Include(p => p.Account)
                .FirstOrDefault(p => p.Id == id);
        }

        public Customer Update(Customer customer)
        {
            _context.Update(customer);
            _context.SaveChanges();
            return customer;
        }
    }
}
