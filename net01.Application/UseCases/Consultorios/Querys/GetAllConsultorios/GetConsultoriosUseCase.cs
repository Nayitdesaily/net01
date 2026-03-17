using net01.Application.Contracts;
using net01.Application.Exceptions;
using net01.Application.UseCases.Consultorios.Querys.GetAllConsultorios;
using net01.Application.UseCases.Consultorios.Querys.GetConsultorioDetails;
using net01.Application.Utils.Mediator;
using net01.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net01.Application.UseCases.Consultorios.Querys.GetAllConsultoriosDetails
{
    public class GetConsultoriosUseCase : IRequestHandler<GetConsultoriosQuery, IEnumerable<ConsultorioDetailsDTO>
    {

        private readonly IRepositoryConsultorio repository;

        public GetConsultoriosUseCase(IRepositoryConsultorio repository)
        {
            this.repository = repository;
        }

        async Task<IEnumerable<ConsultorioDetailsDTO>> Handle(GetConsultoriosQuery request)
        {
            var consultorios = await repository.GetAll();
            if (consultorios is null)
            {
                throw new NotFoundException();
            }
            return consultorios.Select(c => c.ToDTO());
        }
    }
}
