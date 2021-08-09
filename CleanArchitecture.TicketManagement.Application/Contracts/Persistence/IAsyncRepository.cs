using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TicketManagement.Application.Contracts.Persistence
{
    public interface IAsyncRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(Guid id);

        Task<IReadOnlyList<TEntity>> GetPagedReponseAsync(int page, int size, string orderBy);

        Task<IReadOnlyList<TEntity>> ListAllAsync();

        Task AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);

        Task<bool> SaveChangesAsync();
    }
}
