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
    public class BankController
    {
        private readonly IBankRepository _bankRepository;
        private readonly IBankService _bankService;

        public BankController(IBankRepository bankRepository, IBankService bankService)
        {
            _bankRepository = bankRepository;
            _bankService = bankService;
        }
    }
}
