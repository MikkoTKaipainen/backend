using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBank.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiBank.Repositories
{
    public class BankRepository : IBankRepository
    {
        private readonly BankdbContext _context;

        public BankRepository(BankdbContext _context)
        {
            this._context = _context;
        }

        public Bank Create(Bank bank)
        {
            _context.Add(bank);
            _context.SaveChanges();
            return bank;
        }

        public void Delete(int id)
        {
            var deletedBank = Read(id);
            _context.Bank.Remove(deletedBank);
            _context.SaveChanges();
            return;
        }

        public List<Bank> Read()
        {
            return _context.Bank.FromSql("Select * From Bank").ToList();
        }

        public Bank Read(int id)
        {
            return _context.Bank
                .AsNoTracking()
                .Include(p => p.Account)
                .Include(p => p.Customer)
                .FirstOrDefault(p => p.Id == id);
        }

        public Bank Update(Bank bank)
        {
            _context.Update(bank);
            _context.SaveChanges();

            return bank;
        }
    }
}
