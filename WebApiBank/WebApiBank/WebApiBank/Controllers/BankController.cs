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
    public class BankController : ControllerBase
    {
        private readonly IBankRepository _bankRepository;
        private readonly IBankService _bankService;

        public BankController(IBankRepository bankRepository, IBankService bankService)
        {
            _bankRepository = bankRepository;
            _bankService = bankService;
        }

        [HttpGet]
        public ActionResult<List<Bank>> ListAllBanks()
        {
            var banks = _bankService.Read();
            return new JsonResult(banks);
        }

        [HttpGet("{id}")]
        public ActionResult<Bank> Get(int id)
        {
            var banks = _bankService.Read(id);
            return new JsonResult(banks);
        }

        [HttpPost]
        public ActionResult<Bank> Post(Bank bank)
        {
            var newBank = _bankService.Create(bank);
            return new JsonResult(newBank);
        }

        [HttpPut("{id}")]
        public ActionResult<Bank> Put(int id, Bank bank)
        {
            var updatedBank = _bankService.Update(id, bank);
            return updatedBank;
        }

        [HttpDelete("{id}")]
        public ActionResult<Bank> Delete(int id)
        {
            _bankRepository.Delete(id);
            return new NoContentResult();
        }
    }
}
