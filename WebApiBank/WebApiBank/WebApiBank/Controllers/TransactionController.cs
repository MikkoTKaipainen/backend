using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiBank.Repositories;
using WebApiBank.Services;
using WebApiBank.Models;

namespace WebApiBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionRepository transactionRepository, ITransactionService transactionService)
        {
            _transactionRepository = transactionRepository;
            _transactionService = transactionService;
        }

        [HttpGet]
        public ActionResult<List<Transaction>> ListAllTransactions()
        {
            var transactions = _transactionService.Read();
            return new JsonResult(transactions);
        }

        [HttpGet("{Id}")]
        public ActionResult<Account> Get(int id)
        {
            var transactions = _transactionService.Read(id);
            return new JsonResult(transactions);
        }

        [HttpPost]
        public ActionResult<Account> Post(Transaction transaction)
        {
            var newTransaction = _transactionService.Create(transaction);
            return new JsonResult(newTransaction);
        }
    }
}
