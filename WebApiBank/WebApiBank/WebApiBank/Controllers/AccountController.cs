﻿using System;
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
    public class AccountController
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService, IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
            _accountService = accountService;
        }

        [HttpGet]
        public ActionResult<List<Account>> ListAllAccounts()
        {
            var accounts = _accountService.Read();
            return new JsonResult(accounts);
        }

        [HttpGet("{IBAN}")]
        public ActionResult<Account> Get(int id)
        {
            var accounts = _accountService.Read(id);
            return new JsonResult(accounts);
        }

        [HttpPost]
        public ActionResult<Account> Post(Account account)
        {
            var newAccount = _accountService.Create(account);
            return new JsonResult(newAccount);
        }

        [HttpPut("{IBAN}")]
        public ActionResult<Account> Put(int id, Account account)
        {
            var updatedAccount = _accountService.Update(id, account);
            return updatedAccount;
        }
    }
}
