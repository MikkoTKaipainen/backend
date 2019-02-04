using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBank.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiBank.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankdbContext _context;

        public AccountRepository(BankdbContext _context)
        {
            this._context = _context;
        }

        public Account Create(Account account)
        {
            _context.Add(account);
            _context.SaveChanges();
            return account;
        }

        public void Delete(string IBAN)
        {
            var deletedAccount = Read(IBAN);
            _context.Account.Remove(deletedAccount);
            _context.SaveChanges();
            return;
        }

        public List<Account> Read()
        {
            return _context.Account.FromSql("Select * From Account").ToList();
        }

        public Account Read(string IBAN)
        {
            return _context.Account
                .AsNoTracking()
                .FirstOrDefault(p => p.IBAN == IBAN);
        }

        public Account Update(Account account)
        {
            _context.Update(account);
            _context.SaveChanges();
            return account;
        }
    }
}
