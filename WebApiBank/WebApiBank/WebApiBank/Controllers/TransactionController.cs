using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiBank.Repositories;
using WebApiBank.Services;

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
    }
}
