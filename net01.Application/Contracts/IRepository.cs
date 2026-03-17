using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net01.Application.Contracts
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetByID(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task<T?> Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
