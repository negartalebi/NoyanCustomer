
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noyan.Customers.Application.Contracts.Repositories
{
    public class GenericRepository<T>: IGenericRepository<T> where T : class
    {
        private readonly CustomerDbContext _dbContext;

        public GenericRepository(CustomerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> Add(T entity)
        {
            await _dbContext.AddAsync(entity);
            return entity;
        }



        public async Task Delete(T tEntity)
        {
            _dbContext.Set<T>().Remove(tEntity);
        }



        public async Task<T> Get(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> Update(T tEntity)
        {
            _dbContext.Entry(tEntity).State = EntityState.Modified;
            return tEntity;
        }
    }
}
