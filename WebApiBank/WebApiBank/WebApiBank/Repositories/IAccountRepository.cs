using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBank.Models;

namespace WebApiBank.Repositories
{
    public interface IAccountRepository
    {
        Account Create(Account account);
        List<Account> Read();
        Account Read(int id);
        Account Update(Account account);
        void Delete(int id);
    }
}
