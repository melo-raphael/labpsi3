using labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate;
using labpsi.gerenciadora.frota.infra.data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace labpsi.gerenciadora.frota.infra.data.Repositories
{
    public class VeiculoRepository : Repository<Veiculo>, IVeiculoRepository
    {
        public VeiculoRepository(ApplicationDbContext appDbContext) : base(appDbContext)
        {
        }


        public async Task<List<Veiculo>> GetAllVeiculos ()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<Veiculo> GetVeiculoPorId(string id)
        {
            return await _dbSet.AsNoTracking().FirstOrDefaultAsync(veiculo => id == veiculo.Id.ToString());
        }

        public async Task<bool> DeletarVeiculoPorId(string id)
        {
            var veiculo = await GetVeiculoPorId(id);
            _dbSet.Remove(veiculo);
            return true;
        }

        public Veiculo AtualizarVeiculo(Veiculo veiculo)
        {
            var result =  _dbSet.Update(veiculo);
            return result.Entity;
        }
    }
}
