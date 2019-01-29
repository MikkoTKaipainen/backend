using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBank.Models;

namespace WebApiBank.Repositories
{
    public interface ITransactionRepository
    {
        Transaction Create(Transaction transaction);
        List<Transaction> Read();
        Transaction Read(int id);
        Transaction Update(int id, Transaction transaction);
        void Delete(int id);
    }
}
