using labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate;
using MediatR;
using System;

namespace labpsi.gerenciadora.frota.application.Commands
{
    public class AlterarKmCommand : IRequest<Veiculo>
    {
        public Guid VeiculoId { get; set; }
        public decimal KmAtual { get;  set; }
        public DateTime DateSaida { get;  set; }
        public DateTime DataChegada { get;  set; }
        public string Destino { get;  set; }
    }
}
