using Microsoft.EntityFrameworkCore;
using net01.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net01.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly net01DbContext context;

        public Repository(net01DbContext context)
        {
            this.context = context;
        }

        public Task<T?> Add(T entity)
        {
            context.Add(entity);
            return Task.FromResult(entity);
        }

        public Task Delete(T entity)
        {
            context.Remove(entity);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();

        }

        public async Task<T?> GetByID(Guid id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public Task Update(T entity)
        {
            context.Update(entity);
            return Task.CompletedTask;
        }
    }
}
