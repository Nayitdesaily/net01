using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using net01.Application.Contracts;
using net01.Persistence.Repositories;
using net01.Persistence.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace net01.Persistence
{
    public static class PersistenciaServiceRegister
    {
        public static IServiceCollection AddPeristenceServiceRegister(this IServiceCollection services)
        {
            services.AddDbContext<net01DbContext>(options => 
                options.UseSqlServer("name=net01ConnectionString"));
            services.AddScoped<IRepositoryConsultorio, ConsultorioRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWorkEFCore>();
            return services;
        }
    }
}
