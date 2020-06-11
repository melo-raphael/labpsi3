using labpsi.gerenciadora.frota.application.Commands;
using labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate;
using labpsi.gerenciadora.frota.domain.SeedWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace labpsi.gerenciadora.frota.application.CommandHandlers
{
    public class AlterarKmCommandHandler : IRequestHandler<AlterarKmCommand, Veiculo>
    {
        private readonly IVeiculoRepository _veiculoRepository;
        private readonly IUnitOfWork _uow;

        public AlterarKmCommandHandler(IVeiculoRepository veiculoRepository, IUnitOfWork uow)
        {
            _veiculoRepository = veiculoRepository;
            _uow = uow;
        }

        public async Task<Veiculo> Handle(AlterarKmCommand request, CancellationToken cancellationToken)
        {
           var veiculoAlterar = await _veiculoRepository.GetVeiculoPorId(request.VeiculoId);

            veiculoAlterar.AtualizaKm(request.KmAtual, request.DateSaida, request.DataChegada, request.Destino);

            await _uow.Commit();

            return veiculoAlterar;
        }
    }
}
