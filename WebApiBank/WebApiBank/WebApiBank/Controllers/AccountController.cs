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
    public class AccountController
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService, IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
            _accountService = accountService;
        }
    }
}
