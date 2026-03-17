using Microsoft.Extensions.DependencyInjection;
using net01.Application.UseCases.Consultorios.Commands.CreateConsultorio;
using net01.Application.UseCases.Consultorios.Querys.GetAllConsultorios;
using net01.Application.UseCases.Consultorios.Querys.GetAllConsultoriosDetails;
using net01.Application.UseCases.Consultorios.Querys.GetConsultorioDetails;
using net01.Application.Utils.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net01.Application
{
    public static class ApplicationServiceRegister
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddTransient<IMediator, Mediator>();
            services.AddScoped<IRequestHandler<CreateConsultorioCommand, Guid>, CreateConsultorioUseCase>();
            services.AddScoped<IRequestHandler<GetConsultorioDetailsQuery, ConsultorioDetailsDTO>, GetConsultorioDetailsUseCase>();
            services.AddScoped<IRequestHandler<GetConsultoriosQuery, IEnumerable<ConsultorioDetailsDTO>>, GetConsultoriosUseCase>();
            return services;
        }
    }
}
