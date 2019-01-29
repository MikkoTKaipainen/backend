using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBank.Models;

namespace WebApiBank.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public Account Create(Account account)
        {
            throw new NotImplementedException();
        }

        public void Delete(string IBAN)
        {
            throw new NotImplementedException();
        }

        public List<Account> Read()
        {
            throw new NotImplementedException();
        }

        public Account Read(string IBAN)
        {
            throw new NotImplementedException();
        }

        public Account Update(string IBAN, Account account)
        {
            throw new NotImplementedException();
        }
    }
}
