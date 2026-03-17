using net01.Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net01.Dominio.ObjectValue
{
    public record Email
    {
        public string Value { get; } = null!;
        public Email(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new DomainRulesException($"El {nameof(email)} es obligatorio");
            }

            if (!email.Contains('@'))
            {
                throw new DomainRulesException($"El {nameof(email)} no es valido");
            }

            Value = email;
        }
    }
}
