using labpsi.gerenciadora.frota.domain.SeedWork;
using Newtonsoft.Json;
using System;

namespace labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate
{
    public class Veiculo : Entity, IAggregateRoot
    {
        [JsonProperty("placa")]
        private string _placa;
        [JsonProperty("modelo")]
        private string _modelo;
        [JsonProperty("ano")]
        private int _ano;
        [JsonProperty("chassi")]
        private string _chassi;
        [JsonProperty("renavam")]
        private string _renavam;
        [JsonProperty("marca")]
        private string _marca;
        [JsonProperty("cor")]
        private string _cor;
        [JsonProperty("valorPago")]
        private decimal _valorPago;
        [JsonProperty("mesIpva")]
        private int _mesIpva;
        [JsonProperty("kmAtual")]
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
