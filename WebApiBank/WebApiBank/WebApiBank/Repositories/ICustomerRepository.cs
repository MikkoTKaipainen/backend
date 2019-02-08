using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBank.Models;

namespace WebApiBank.Repositories
{
    public interface ICustomerRepository
    {
        Customer Create(Customer customer);
        List<Customer> Read();
        Customer Read(int id);
        Customer Update(Customer customer);
        void Delete(int id);
    }
}
