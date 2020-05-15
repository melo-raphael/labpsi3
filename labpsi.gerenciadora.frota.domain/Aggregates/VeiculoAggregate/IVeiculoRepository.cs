using labpsi.gerenciadora.frota.domain.SeedWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate
{
    public interface IVeiculoRepository : IRepository<Veiculo>
    {
        Task<List<Veiculo>> GetAllVeiculos();
        Task<Veiculo> GetVeiculoPorId(string id);
        Task<bool> DeletarVeiculoPorId(string id);
        Veiculo AtualizarVeiculo(Veiculo veiculo);
    }
}
