using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBank.Models;

namespace WebApiBank.Services
{
    public interface IAccountService
    {
        Account Create(Account account);
        List<Account> Read();
        Account Read(int id);
        Account Update(int id, Account account);
        void Delete(int id);
    }
}
