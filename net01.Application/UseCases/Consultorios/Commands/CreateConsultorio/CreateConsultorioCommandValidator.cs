using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net01.Application.UseCases.Consultorios.Commands.CreateConsultorio
{
    public class CreateConsultorioCommandValidator: AbstractValidator<CreateConsultorioCommand>
    {
        public CreateConsultorioCommandValidator()
        {
            RuleFor(p => p.Nombre).NotEmpty().WithMessage("El campo {PropertyName} es requerido");
        }
    }
}
