using System;
using System.Threading.Tasks;

namespace labpsi.gerenciadora.frota.domain.SeedWork
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}
