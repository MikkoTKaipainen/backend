using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBank.Models;

namespace WebApiBank.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        public Transaction Create(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> Read()
        {
            throw new NotImplementedException();
        }

        public Transaction Read(int id)
        {
            throw new NotImplementedException();
        }

        public Transaction Update(int id, Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
