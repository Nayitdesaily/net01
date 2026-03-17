using net01.Dominio.Exceptions;
using net01.Dominio.ObjectValue;

namespace net01.Dominio.Entities
{
    public class Paciente
    {
        public Guid Id { get; private set; }
        public string Nombre { get; private set; }
        public Email Email{ get; private set; }

        public Paciente(string nombre, Email email)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new DomainRulesException($"El {nameof(nombre)} es obligatorio");
            }
            if (email is null)
            {
                throw new DomainRulesException($"El {nameof(email)} es obligatorio");
            }


            Id = Guid.CreateVersion7();
            Nombre = nombre;
            Email = email;
        }
    }
}
