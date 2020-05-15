using labpsi.gerenciadora.frota.application.Commands;
using labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate;
using labpsi.gerenciadora.frota.domain.SeedWork;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace labpsi.gerenciadora.frota.application.CommandHandlers
{
    public class CriarNovoVeiculoCommandHandler : IRequestHandler<CriarNovoVeiculoCommand, Veiculo>
    {
        private readonly IVeiculoRepository _veiculoRepository;
        private readonly IUnitOfWork _uow;
        public CriarNovoVeiculoCommandHandler(IVeiculoRepository veiculoRepository, IUnitOfWork uow)
        {
            _veiculoRepository = veiculoRepository;
            _uow = uow;
        }

        public async Task<Veiculo> Handle(CriarNovoVeiculoCommand request, CancellationToken cancellationToken)
        {
            var veiculo = new Veiculo(request.Placa, request.Modelo, request.Ano, request.Chassi, request.Renavam,
                                       request.Marca, request.Cor, request.ValorPago,
                                       request.MesIpva, request.KmAtual);

            _veiculoRepository.Add(veiculo);

            await _uow.Commit();


            return veiculo;

        }
    }
}
