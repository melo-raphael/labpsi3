using System;
using System.Threading.Tasks;
using labpsi.gerenciadora.frota.application.Commands;
using labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace labpsi.gerenciadora.frota.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculosController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IVeiculoRepository _veiculoRepository;
        private readonly ILogger<VeiculosController> _logger;

        public VeiculosController(IMediator mediator, IVeiculoRepository veiculoRepository, ILogger<VeiculosController> logger)
        {
            _mediator = mediator;
            _veiculoRepository = veiculoRepository;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> CriarVeiculo([FromBody] CriarNovoVeiculoCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> ObterVeiculos()
        {
            var result = _veiculoRepository.GetAllVeiculos();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterVeiculoPorId(Guid id)
        {
            var result = _veiculoRepository.GetVeiculoPorId(id);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarVeiculoPorId(Guid id)
        {
            await _veiculoRepository.DeletarVeiculoPorId(id);
            return NoContent();
        }

        [HttpPut("{id}/km")]
        public async Task<IActionResult> AlterarKilometroRodadoVeiculo([FromBody]AlterarKmCommand command, Guid id)
        {
            command.VeiculoId = id;
            var result = await _mediator.Send(command);

            return Ok(result);
        }

    }
}
