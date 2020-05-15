using MediatR;

namespace labpsi.gerenciadora.financeira.application.Commands
{
    public class CriarNovoVeiculoCommand : VeiculoCommand, IRequest<bool>
    {
        public string KmAtual { get; set; }
    }
}
