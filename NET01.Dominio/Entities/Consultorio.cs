using net01.Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net01.Dominio.Entities
{
    public class Consultorio
    {
        public Guid Id { get; private set; }
        public string Nombre { get; private set; }

        public Consultorio(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new DomainRulesException($"el {nameof(nombre)} es obligatorio");
            }

            Nombre = nombre;
            Id = Guid.CreateVersion7();
        }
    }
}
