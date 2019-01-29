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
    public class CustomerController
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService, ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            _customerService = customerService;
        }

    }
}
