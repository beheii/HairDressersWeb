using HairDressersWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressersWeb.Interfaces
{
    public interface IAppointment
    {
        Task<IEnumerable<Appointment>> Get();
        Task<Appointment> Get(int id);
        Task<Appointment> Create(Appointment appointment); 
        Task Update(Appointment appointment);
        Task Delete(int id);
    }
}
