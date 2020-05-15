using labpsi.gerenciadora.frota.domain.SeedWork;
using labpsi.gerenciadora.frota.infra.data.Context;
using Microsoft.EntityFrameworkCore;

namespace labpsi.gerenciadora.frota.infra.data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IAggregateRoot
    {
        protected readonly ApplicationDbContext _appDbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = appDbContext.Set<TEntity>();

        }

        public void Add(TEntity obj)
        {
            _appDbContext.Add(obj);
        }
    }
}
