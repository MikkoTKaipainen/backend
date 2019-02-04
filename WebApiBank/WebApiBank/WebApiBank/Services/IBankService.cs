using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBank.Models;

namespace WebApiBank.Services
{
    public interface IBankService
    {
        Bank Create(Bank bank);
        List<Bank> Read();
        Bank Read(int id);
        Bank Update(int id, Bank bank);
        void Delete(int id);
    }
}
