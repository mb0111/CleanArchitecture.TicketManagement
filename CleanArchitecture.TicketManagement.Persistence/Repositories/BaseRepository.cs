using CleanArchitecture.TicketManagement.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.TicketManagement.Persistence.Repositories
{
    public class BaseRepository<TEntity> : IAsyncRepository<TEntity> where TEntity : class
    {
        public readonly TicketManagementDbContext _dbContext;

        public BaseRepository(TicketManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public async virtual Task<IReadOnlyList<TEntity>> GetPagedReponseAsync(int page, int size)
        {
            return await _dbContext.Set<TEntity>().Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }

        public async Task<IReadOnlyList<TEntity>> ListAllAsync()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
        }

        public void UpdateAsync(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void DeleteAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
