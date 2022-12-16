using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HairDressersWeb.Models;
namespace HairDressersWeb.Models
{
    public class EfContext : DbContext
    {
        public EfContext(DbContextOptions<EfContext> options) : base(options)
        {  }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Customer>().HasData(new List<Customer>
            {
                new Customer
                {
                    Id = 5,
                    Type = Enums.WorkType.Haircut,
                    MasterSurname = "Hanyk"
                },
                new Customer
                {
                    Id = 1,
                    Type = Enums.WorkType.Haircut,
                    MasterSurname = "Vaskiv"
                },
                   new Customer
                {
                   Id = 2,
                    Type = Enums.WorkType.Haircut,
                    MasterSurname = "Rudnyk"
                },
                   new Customer
                {
                    Id = 3,
                    Type = Enums.WorkType.Haircut,
                    MasterSurname = "Dutka"
                },
                   new Customer
                {
                   Id = 4,
                    Type = Enums.WorkType.Haircut,
                    MasterSurname = "Khalus"
                },

            });
        }
    }
}
