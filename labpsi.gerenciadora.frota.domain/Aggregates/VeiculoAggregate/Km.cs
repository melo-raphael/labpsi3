using labpsi.gerenciadora.frota.domain.SeedWork;
using System;
namespace labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate
{
    public class Km : Entity
    {

        public string KmAtual { get; private set; }
        public DateTime DateSaida { get; private set; }
        public DateTime DataChegada { get; private set; }
        public string Destino { get; private set; }
        public Km(string kmAtual, DateTime dateSaida, DateTime dataChegada, string destino)
        {
            KmAtual = kmAtual;
            DateSaida = dateSaida;
            DataChegada = dataChegada;
            Destino = destino;
        }

    }
}
