using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.TicketManagement.Application.Contracts.Persistence
{
    public interface IAsyncRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(Guid id);

        Task<IReadOnlyList<TEntity>> GetPagedReponseAsync(int page, int size);

        Task<IReadOnlyList<TEntity>> ListAllAsync();

        Task AddAsync(TEntity entity);

        void UpdateAsync(TEntity entity);

        void DeleteAsync(TEntity entity);

        Task<int> SaveChangesAsync();
    }
}
