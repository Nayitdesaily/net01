using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net01.Dominio.Exceptions
{
    public class DomainRulesException : Exception
    {
        public DomainRulesException(string message) : base(message)
        {
            
        }
    }
}
