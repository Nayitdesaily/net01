using net01.Application.Contracts;
using net01.Application.Exceptions;
using net01.Application.Utils.Mediator;

namespace net01.Application.UseCases.Consultorios.Querys.GetConsultorioDetails
{
    public class GetConsultorioDetailsUseCase : IRequestHandler<GetConsultorioDetailsQuery, ConsultorioDetailsDTO>
    {
        private readonly IRepositoryConsultorio repository;
        public GetConsultorioDetailsUseCase(IRepositoryConsultorio repository)
        {
            this.repository = repository;
        }

        public async Task<ConsultorioDetailsDTO> Handle(GetConsultorioDetailsQuery request)
        {
            var consultorio = await repository.GetByID(request.Id);
            if(consultorio is null)
            {
                throw new NotFoundException();
            }
            return consultorio.ToDTO();
        }
    }
}
