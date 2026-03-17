using FluentValidation;
using net01.Application.Contracts;
using net01.Application.Utils.Mediator;
using net01.Dominio.Entities;

namespace net01.Application.UseCases.Consultorios.Commands.CreateConsultorio
{
    public class CreateConsultorioUseCase: IRequestHandler<CreateConsultorioCommand, Guid>
    {
        private readonly IRepositoryConsultorio repository;
        private readonly IUnitOfWork unitOfWork;
        public CreateConsultorioUseCase(IRepositoryConsultorio repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }
        public async Task<Guid> Handle(CreateConsultorioCommand command) 
        {
            var consultorio = new Consultorio(command.Nombre);
            try
            {
                var response = await repository.Add(consultorio);
                await unitOfWork.Persist();
                return response.Id;
            }
            catch (Exception)
            {
                await unitOfWork.Rollback();
                throw;
            }
        }
    }
}
