using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net01.Application.Contracts
{
    public interface IUnitOfWork
    {
        Task Persist();
        Task Rollback();
    }
}
