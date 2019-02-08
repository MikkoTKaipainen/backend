using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBank.Models;
using WebApiBank.Repositories;

namespace WebApiBank.Services
{
    public class BankService : IBankService
    {
        private readonly IBankRepository _bankRepository;

        public BankService(IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }

        public Bank Create(Bank bank)
        {
            return _bankRepository.Create(bank);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bank> Read()
        {
            return _bankRepository.Read();
        }

        public Bank Read(int id)
        {
            return _bankRepository.Read(id);
        }

        public Bank Update(int id, Bank bank)
        {
            var updatedBank = _bankRepository.Read(id);
            if (updatedBank == null)
                throw new Exception("Bank not found");
            return _bankRepository.Update(bank);
        }
    }
}
