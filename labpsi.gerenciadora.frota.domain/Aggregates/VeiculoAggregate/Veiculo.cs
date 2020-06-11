using labpsi.gerenciadora.frota.domain.SeedWork;
using Newtonsoft.Json;
using System;

namespace labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate
{
    public class Veiculo : Entity, IAggregateRoot
    {
        public string Placa { get; private set; }
        public string Modelo { get; private set; }
        public int Ano { get; private set; }
        public string Chassi { get; private set; }
        public string Renavam { get; private set; }
        public string Marca { get; private set; }
        public string Cor { get; private set; }
        public decimal ValorPago { get; private set; }
        public int MesIpva { get; private set; }
        public decimal KmAtual { get; private set; }

        //private int _combustivelId;
        //public Combustivel Combustivel { get; private set; }
        public Km _km { get; private set; }

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
                       decimal kmAtual
                       )
        {
            Placa = placa;
            Modelo = modelo;
            Ano = ano;
            Chassi = chassi;
            Renavam = renavam;
            Marca = marca;
            Cor = cor;
            //_combustivelId = Combustivel.FromName(combustivel).Id;
            ValorPago = valorPago;
            MesIpva = mesIpva;
            KmAtual = kmAtual;
        }


        public void AtualizaKm(decimal kmAtual, DateTime dateSaida, DateTime dataEntrada, string destino)
        {
            _km = new Km(kmAtual, dateSaida, dataEntrada, destino);

            this.KmAtual += kmAtual;
        }
    }
}
