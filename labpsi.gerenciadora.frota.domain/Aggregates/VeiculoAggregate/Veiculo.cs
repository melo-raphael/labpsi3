using labpsi.gerenciadora.frota.domain.SeedWork;
using System;

namespace labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate
{
    public class Veiculo : Entity, IAggregateRoot
    {

        private string _placa;
        private string _modelo;
        private int _ano;
        private string _chassi;
        private string _renavam;
        private string _marca;
        private string _cor;
        private decimal _valorPago;
        private int _mesIpva;
        private string _kmAtual;
        //private int _combustivelId;
        //public Combustivel Combustivel { get; private set; }
        private Km _km;

        public Veiculo(string placa,
                       string modelo,
                       int ano,
                       string chassi,
                       string renavam,
                       string marca,
                       string cor,
                       //string combustivel,
                       decimal valorPago,
                       int mesIpva,
                       string kmAtual
                       )
        {
            _placa = placa;
            _modelo = modelo;
            _ano = ano;
            _chassi = chassi;
            _renavam = renavam;
            _marca = marca;
            _cor = cor;
            //_combustivelId = Combustivel.FromName(combustivel).Id;
            _valorPago = valorPago;
            _mesIpva = mesIpva;
            _kmAtual = kmAtual;
        }


        public void AtualizaKm(string kmAtual, DateTime dateSaida, DateTime dataEntrada, string destino)
        {
            _km =  new Km(kmAtual, dateSaida, dataEntrada, destino);

            this._kmAtual += kmAtual;
        }
    }
}
