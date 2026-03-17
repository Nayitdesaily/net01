using net01.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net01.Application.UseCases.Consultorios.Querys.GetConsultorioDetails
{
     public static class MapperExtension
    {
        public static ConsultorioDetailsDTO ToDTO( this Consultorio consultorio)
        {
            var dto = new ConsultorioDetailsDTO { Id = consultorio.Id, Nombre = consultorio.Nombre };
            return dto;
        }
    }
}
