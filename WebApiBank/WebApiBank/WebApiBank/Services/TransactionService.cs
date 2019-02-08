using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBank.Models;
using WebApiBank.Repositories;

namespace WebApiBank.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public Transaction Create(Transaction transaction)
        {
            return _transactionRepository.Create(transaction);
        }

        public List<Transaction> Read()
        {
            return _transactionRepository.Read();
        }

        public Transaction Read(int id)
        {
            return _transactionRepository.Read(id);
        }

        public Transaction Update(int id, Transaction transaction)
        {
            var updatedTransaction = _transactionRepository.Read(id);
            if (updatedTransaction == null)
                throw new Exception("Transaction not found")
            return updatedTransaction.Update(transaction);

        }
    }
}
