using labpsi.gerenciadora.frota.domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate
{
    public interface IVeiculoRepository : IRepository<Veiculo>
    {
        Task<IEnumerable<Veiculo>> GetAllVeiculos();
        Task<Veiculo> GetVeiculoPorId(Guid id);
        Task<bool> DeletarVeiculoPorId(Guid id);
        Veiculo AtualizarVeiculo(Veiculo veiculo);
    }
}
