namespace labpsi.gerenciadora.frota.application.Commands
{
    public class VeiculoCommand
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Chassi { get; set; }
        public string Renavam { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        //public string Combustivel { get; set; }
        public decimal ValorPago { get; set; }
        public int MesIpva { get; set; }

    }
}
