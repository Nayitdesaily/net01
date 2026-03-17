using net01.Application.Contracts;
using net01.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net01.Persistence.Repositories
{
    public class ConsultorioRepository : Repository<Consultorio>, IRepositoryConsultorio
    {
        public ConsultorioRepository(net01DbContext context) : base(context)
        {
        }
    }
}
