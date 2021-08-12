using CleanArchitecture.TicketManagement.Application.Contracts.Persistence;
using CleanArchitecture.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.TicketManagement.Persistence.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(TicketManagementDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
        {
            bool matches = _dbContext.Events.Any(e => e.Name.Equals(name) && e.StartDate.Date.Equals(eventDate.Date));
            return await Task.FromResult(matches);
        }

        public async Task<List<Event>> GetEventsByCategory(Guid idCategory)
        {
            return await _dbContext.Events.AsNoTracking().Where(e => e.IdCategory == idCategory).ToListAsync();
        }

        public async Task<List<Event>> GetEventsByDate(DateTime startDate, DateTime? endDate = null)
        {
            return await _dbContext.Events.AsNoTracking().Where(e => e.StartDate.Date >= startDate.Date && (!endDate.HasValue || e.EndDate.Date <= endDate.Value.Date)).ToListAsync();
        }

        public async Task<List<Event>> GetEventsByPrice(decimal minPrice, decimal? maxPrice = null)
        {
            return await _dbContext.Events.AsNoTracking().Where(e => e.Price >= minPrice && (!maxPrice.HasValue || e.Price <= maxPrice.Value)).ToListAsync();
        }

    }
}
