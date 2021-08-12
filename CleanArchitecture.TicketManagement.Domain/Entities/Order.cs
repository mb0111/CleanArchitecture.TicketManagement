using CleanArchitecture.TicketManagement.Domain.Common;
using System;

namespace CleanArchitecture.TicketManagement.Domain.Entities
{
    public class Order : AuditableEntity
    {
        public Guid Id { get; set; }

        //public Guid IdUser { get; set; }

        public Guid IdEvent { get; set; }

        public int IdOrderStatus { get; set; }

        public int IdOrderType { get; set; }

        public int Quantity { get; set; }

        //public decimal Amount { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime OrderPlaced { get; set; }

        //public User User { get; set; }

        public Event Event { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public OrderType OrderType { get; set; }
    }

    //public class User : AuditableEntity
    //{
    //    public Guid Id { get; set; }

    //    public string Name { get; set; }

    //    public string Surname { get; set; }

    //    public string Email { get; set; }

    //    public DateTime Birthdate { get; set; }
    //}
}
