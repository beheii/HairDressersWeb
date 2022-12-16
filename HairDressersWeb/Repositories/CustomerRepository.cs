using HairDressersWeb.Interfaces;
using HairDressersWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairDressersWeb.Repositories
{
    public class CustomerRepository : ICustomer
    {

        private readonly EfContext _context;
        public CustomerRepository(EfContext context)
        {
            _context = context;
        }
        public async Task<Customer> Create(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }


        public async Task Delete(int id)
        {
            var customersToDelete = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customersToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> Get() 
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> Get(int id)
        {
            return await _context.Customers.FindAsync(id);
        }


        public async Task Update(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }


    }
}
