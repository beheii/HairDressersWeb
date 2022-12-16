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
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointment _appointmentRepository; 

        public AppointmentsController(IAppointment appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }
        [HttpGet] 
        public async Task<IEnumerable<Appointment>> GetAppointsments()
        {
            return await _appointmentRepository.Get(); 
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Appointment>> GetAppointsments(int id)
        {
            return await _appointmentRepository.Get(id);
        } 
        [HttpPost] 
        public async Task<ActionResult<Appointment>> PostAppointments([FromBody] Appointment item)
        {
            var newItem = await _appointmentRepository.Create(item);
            return CreatedAtAction(nameof(GetAppointsments), new { id = newItem.Id }, newItem);
        }
        [HttpPut] 
        public async Task<ActionResult> PutAppointsments(int id, [FromBody] Appointment item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            await _appointmentRepository.Update(item);

            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var itemToDelete = await _appointmentRepository.Get(id);
            if (itemToDelete == null)
            {
                return NotFound();
            }
            await _appointmentRepository.Delete(itemToDelete.Id);
            return Ok();
        }
    }
}
 