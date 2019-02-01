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
            throw new NotImplementedException();
        }

        public void delete(int id)
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

        public Bank Update(int id, Bank name)
        {
            throw new NotImplementedException();
        }
    }
}
