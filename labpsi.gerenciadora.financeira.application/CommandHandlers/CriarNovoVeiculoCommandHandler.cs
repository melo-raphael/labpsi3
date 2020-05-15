using labpsi.gerenciadora.financeira.application.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace labpsi.gerenciadora.financeira.application.CommandHandlers
{
    public class CriarNovoVeiculoCommandHandler : IRequestHandler<CriarNovoVeiculoCommand, bool>
    {

        public Task<bool> Handle(CriarNovoVeiculoCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
