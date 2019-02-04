using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBank.Models;
using WebApiBank.Repositories;

namespace WebApiBank.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public Account Create(Account account)
        {
            return _accountRepository.Create(account);
        }

        public void Delete(string IBAN)
        {
            throw new NotImplementedException();
        }

        public List<Account> Read()
        {
            return _accountRepository.Read();
        }

        public Account Read(string IBAN)
        {
            return _accountRepository.Read(IBAN);
        }

        public Account Update(string IBAN, Account account)
        {
            var updatedAccount = _accountRepository.Read(IBAN);
            if (updatedAccount == null)
                throw new Exception("Account not found");
            return _accountRepository.Update(account);
        }
    }
}
