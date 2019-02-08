using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBank.Models;

namespace WebApiBank.Services
{
    public interface ITransactionService
    {
        Transaction Create(Transaction transaction);
        List<Transaction> Read();
        Transaction Read(int id);
        Transaction Update(int id, Transaction transaction);
    }
}
