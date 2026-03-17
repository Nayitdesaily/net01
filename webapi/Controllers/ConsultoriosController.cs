using Microsoft.AspNetCore.Mvc;
using net01.Application.UseCases.Consultorios.Commands.CreateConsultorio;
using net01.Application.UseCases.Consultorios.Querys.GetConsultorioDetails;
using net01.Application.Utils.Mediator;
using net01.WEBAPI.DTOs.Consultorio;

namespace net01.WEBAPI.Controllers
{
    [ApiController]
    [Route("api/consultorios")]
    public class ConsultoriosController: Controller
    {
        private readonly IMediator mediator;

        public ConsultoriosController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConsultorioDetailsDTO>> Get(Guid id)
        {
            var query = new GetConsultorioDetailsQuery { Id = id };
            var result = await mediator.Send(query);
            return result;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateConsultorioDTO creaConsultorioDTO)
        {
            var command = new CreateConsultorioCommand{ Nombre = creaConsultorioDTO.Nombre };
            await mediator.Send(command);
            return Created();
        }
    }
}
