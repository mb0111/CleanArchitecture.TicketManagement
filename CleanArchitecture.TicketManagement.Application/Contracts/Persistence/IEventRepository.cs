using CleanArchitecture.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.TicketManagement.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);

        Task<List<Event>> GetEventsByCategory(Guid idCategory);

        Task<List<Event>> GetEventsByDate(DateTime startDate, DateTime? endDate = null);

        Task<List<Event>> GetEventsByPrice(decimal minPrice, decimal? maxPrice = null);
    }
}
