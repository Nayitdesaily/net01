using net01.Application.Utils.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net01.Application.UseCases.Consultorios.Querys.GetConsultorioDetails
{
    public class GetConsultorioDetailsQuery: IRequest<ConsultorioDetailsDTO>
    {
        public Guid Id { get; set; }
    }
}
