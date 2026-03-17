using net01.Application.Utils.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net01.Application.UseCases.Consultorios.Commands.CreateConsultorio
{
    public class CreateConsultorioCommand: IRequest<Guid>
    {
        public required string Nombre { get; set; }
    }
}
