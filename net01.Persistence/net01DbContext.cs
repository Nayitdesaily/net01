using Microsoft.EntityFrameworkCore;
using net01.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net01.Persistence
{
    public class net01DbContext :  DbContext
    {
        public net01DbContext(DbContextOptions<net01DbContext> options) : base(options)
        {
            
        }

        protected net01DbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(net01DbContext).Assembly);
        }

        public DbSet<Consultorio> Consultorios { get; set; }
    }
}
