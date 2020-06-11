using labpsi.gerenciadora.frota.domain.Aggregates.VeiculoAggregate;
using labpsi.gerenciadora.frota.infra.data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace labpsi.gerenciadora.frota.infra.data.Repositories
{
    public class VeiculoRepository : Repository<Veiculo>, IVeiculoRepository
    {
        public VeiculoRepository(ApplicationDbContext appDbContext) : base(appDbContext)
        {
        }


        public async Task<IEnumerable<Veiculo>> GetAllVeiculos()
        {
            return _dbSet;
        }

        public async Task<Veiculo> GetVeiculoPorId(Guid id)
        {
            return  _dbSet.AsNoTracking().First(veiculo => id == veiculo.Id);
        }

        public async Task<bool> DeletarVeiculoPorId(Guid id)
        {
            var veiculoPega = await _dbSet.AsNoTracking().FirstOrDefaultAsync(veiculo => id == veiculo.Id);
            _dbSet.Remove(veiculoPega);
            return true;
        }

        public Veiculo AtualizarVeiculo(Veiculo veiculo)
        {
            var result =  _dbSet.Update(veiculo);
            return result.Entity;
        }
    }
}
