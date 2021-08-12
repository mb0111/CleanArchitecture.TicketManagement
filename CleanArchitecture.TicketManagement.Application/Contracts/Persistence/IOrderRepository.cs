using CleanArchitecture.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrderStatus = CleanArchitecture.TicketManagement.Domain.Enumerations.OrderStatus;
using OrderType = CleanArchitecture.TicketManagement.Domain.Enumerations.OrderType;

namespace CleanArchitecture.TicketManagement.Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
        Task<List<Order>> GetPagedOrdersForStatus(OrderStatus status, int page, int size);

        Task<List<Order>> GetPagedOrdersForType(OrderType type, int page, int size);

        Task<List<Order>> GetPagedOrdersForEvent(Guid idEvent, int page, int size);

        Task<List<Order>> GetPagedOrdersForMonth(DateTime date, int page, int size);

        Task<int> GetTotalCountOfOrdersForMonth(DateTime date);
    }
}
