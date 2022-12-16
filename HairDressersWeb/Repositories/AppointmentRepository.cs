using HairDressersWeb.Interfaces;
using HairDressersWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressersWeb.Repositories
{
    public class AppointmentRepository : IAppointment
    {
        private readonly EfContext _context;
        public AppointmentRepository(EfContext context)
        {
            _context = context;
        }
        public  async Task<Appointment> Create(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();
            return appointment;
        }

        public async Task Delete(int id)
        {
            var appointsmentsToDelete = await _context.Appointments.FindAsync(id);
            _context.Appointments.Remove(appointsmentsToDelete); 
            await _context.SaveChangesAsync();
        } 

        public async Task<IEnumerable<Appointment>> Get()
        {
            return await _context.Appointments.ToListAsync();
        }

        public async Task<Appointment> Get(int id)
        {
            return await _context.Appointments.FindAsync(id);
        }

        public async Task Update(Appointment appointment)
        {
            _context.Entry(appointment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
