using CleanArchitecture.TicketManagement.Application.Contracts.Persistence;
using CleanArchitecture.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.TicketManagement.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(TicketManagementDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents)
        {
            List<Category> allCategories = await _dbContext.Categories.Include(x => x.Events).ToListAsync();
            if (!includePassedEvents)
            {
                allCategories.ForEach(c =>
                {
                    c.Events.ToList().RemoveAll(c => c.StartDate < DateTime.Today);
                });
            }
            return allCategories;
        }
    }
}
