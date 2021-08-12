using CleanArchitecture.TicketManagement.Application.Contracts.Persistence;
using CleanArchitecture.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderStatus = CleanArchitecture.TicketManagement.Domain.Enumerations.OrderStatus;
using OrderType = CleanArchitecture.TicketManagement.Domain.Enumerations.OrderType;

namespace CleanArchitecture.TicketManagement.Persistence.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(TicketManagementDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Order>> GetPagedOrdersForStatus(OrderStatus status, int page, int size)
        {
            return await _dbContext.Orders.Where(x => x.IdOrderStatus == (int)status).Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }

        public async Task<List<Order>> GetPagedOrdersForType(OrderType type, int page, int size)
        {
            return await _dbContext.Orders.Where(x => x.IdOrderType == (int)type).Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }

        public async Task<List<Order>> GetPagedOrdersForEvent(Guid idEvent, int page, int size)
        {
            return await _dbContext.Orders.Where(x => x.IdEvent == idEvent).Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }

        public async Task<List<Order>> GetPagedOrdersForMonth(DateTime date, int page, int size)
        {
            return await _dbContext.Orders.Where(x => x.OrderPlaced.Month == date.Month && x.OrderPlaced.Year == date.Year).Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }

        public async Task<int> GetTotalCountOfOrdersForMonth(DateTime date)
        {
            return await _dbContext.Orders.CountAsync(x => x.OrderPlaced.Month == date.Month && x.OrderPlaced.Year == date.Year);
        }
    }
}
