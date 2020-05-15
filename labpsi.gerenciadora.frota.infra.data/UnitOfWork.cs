using labpsi.gerenciadora.frota.domain.SeedWork;
using labpsi.gerenciadora.frota.infra.data.Context;
using System.Threading.Tasks;

namespace labpsi.gerenciadora.frota.infra.data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Commit()
        {
            return await _context.SaveEntitiesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
