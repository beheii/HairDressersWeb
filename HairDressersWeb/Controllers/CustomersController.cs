using HairDressersWeb.Interfaces;
using HairDressersWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressersWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomer _customerRepository;

        public CustomersController(ICustomer customerRepository)
        {
            _customerRepository = customerRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _customerRepository.Get(); 
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomers(int id)
        {
            return await _customerRepository.Get(id); 
        }
        [HttpPost]
        public async Task<ActionResult<Customer>> PostGoods([FromBody] Customer item)
        {
            var newItem = await _customerRepository.Create(item);
            return CreatedAtAction(nameof(GetCustomers), new { id = newItem.Id }, newItem);
        }
        [HttpPut]
        public async Task<ActionResult> PutCustomers(int id, [FromBody] Customer item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            await _customerRepository.Update(item);

            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var itemToDelete = await _customerRepository.Get(id);
            if (itemToDelete == null)
            {
                return NotFound();
            }
            await _customerRepository.Delete(itemToDelete.Id);
            return Ok();
        }
    }
}
  