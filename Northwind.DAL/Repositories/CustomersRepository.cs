using Northwind.DAL.Interfaces;
using Northwind.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Northwind.DAL.Repositories
{
    public class CustomersRepository : ICustomerRepository
    {
        private readonly NorthwindContext _northwindContext;

        public CustomersRepository(NorthwindContext northwindContext)
        {
            this._northwindContext = northwindContext;
        }

        public void Add<T>(T entity) where T : class
        {
            _northwindContext.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _northwindContext.Remove(entity);
        }

        public async Task<IList<Customers>> GetAllCustomersAsync()
        {
            return await _northwindContext.Customers.ToListAsync();
        }

        public async Task<Customers> GetCustomerAsync(string customerId)
        {
            var customer = await _northwindContext.Customers.FirstOrDefaultAsync(s => s.CustomerId == customerId);
            return customer;
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _northwindContext.SaveChangesAsync() > 0;
        }
    }
}
