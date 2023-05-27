
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Noyan.Customers.Application.DomainServices;
using Noyan.Customers.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Noyan.Customers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService customerService;

        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        public async Task<ActionResult<List<CustomerListDto>>> Get()
        {
            var Customers = await customerService.GetAllCustomers();
            return Ok(Customers);
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDto>> Get(int id)
        {
            var Customer = await customerService.Get(id);
            return Ok(Customer);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public async Task<ActionResult<long>> Post([FromBody] CreateCustomerDto input)
        {
            var repsonse = await customerService.CreateCustomr(input);
            return Ok(repsonse);
        }

        // PUT api/<CustomersController>/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateCustomerDto input)
        {
            await customerService.UpdateCustomer(input);
            return NoContent();
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await customerService.DeleteCustomer(id);
            return NoContent();
        }
    }
}
