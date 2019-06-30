using Northwind.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Interfaces
{
    public interface ICustomerRepository
    {
        void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();

        Task<IList<Customers>> GetAllCustomersAsync();

        Task<Customers> GetCustomerAsync(string customerId);
    }
}
