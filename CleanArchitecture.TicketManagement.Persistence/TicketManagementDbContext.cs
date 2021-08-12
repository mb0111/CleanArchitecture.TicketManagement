using CleanArchitecture.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.TicketManagement.Persistence
{
    public class TicketManagementDbContext : DbContext
    {
        public TicketManagementDbContext(DbContextOptions<TicketManagementDbContext> options)
           : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<OrderType> OrderTypes { get; set; }
    }
}
