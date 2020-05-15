using labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate;
using MediatR;

namespace labpsi.gerenciadora.frota.application.Commands
{
    public class CriarNovoVeiculoCommand : VeiculoCommand, IRequest<Veiculo>
    {
        public string KmAtual { get; set; }
    }
}
