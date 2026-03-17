using net01.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net01.Persistence.UnitOfWork
{
    public class UnitOfWorkEFCore : IUnitOfWork
    {
        private readonly net01DbContext context;

        public UnitOfWorkEFCore(net01DbContext context)
        {
            this.context = context;
        }
        public async Task Persist()
        {
            await context.SaveChangesAsync();
        }

        public Task Rollback()
        {
            return Task.CompletedTask;
        }
    }
}
