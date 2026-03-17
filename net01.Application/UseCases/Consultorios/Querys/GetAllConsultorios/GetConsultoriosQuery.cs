using net01.Application.UseCases.Consultorios.Querys.GetConsultorioDetails;
using net01.Application.Utils.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net01.Application.UseCases.Consultorios.Querys.GetAllConsultorios
{
    internal class GetConsultoriosQuery: IRequest<IEnumerable<ConsultorioDetailsDTO>>
    {
    }
}
