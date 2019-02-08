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

        public void Delete(int id)
        {
            var deletedAccount = Read(id);
            _context.Account.Remove(deletedAccount);
            _context.SaveChanges();
            return;
        }

        public List<Account> Read()
        {
            return _context.Account.FromSql("Select * From Account").ToList();
        }

        public Account Read(int id)
        {
            return _context.Account
                .AsNoTracking()
                .Include(p => p.Transaction)
                .FirstOrDefault(p => p.Id == id);
        }

        public Account Update(Account account)
        {
            _context.Update(account);
            _context.SaveChanges();
            return account;
        }
    }
}
