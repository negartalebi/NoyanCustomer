using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Noyan.Customers.Application.Contracts;
using Noyan.Customers.Application.Contracts.Repositories;
using Noyan.Customers.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noyan.Customers.Application.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly CustomerDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ICustomerRepository _customerRepository;
       
        public UnitOfWork(CustomerDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            this._httpContextAccessor = httpContextAccessor;
        }

     

        public ICustomerRepository CustomerRepository =>
            _customerRepository ??= new CustomerRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task SaveAsync()
        {

            //foreach(var entry in _context.ChangeTracker.Entries<BaseEntity>()
            //    .Where(q => q.State == EntityState.Added ))
            //{
                 
            //    if (entry.State == EntityState.Added)
            //    {
            //        entry.Entity.CreatedAt = DateTime.Now;
                    
            //    }
            //}

            await _context.SaveChangesAsync();
        }
    }
}
