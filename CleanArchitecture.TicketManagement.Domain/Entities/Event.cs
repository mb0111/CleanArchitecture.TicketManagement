using CleanArchitecture.TicketManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.TicketManagement.Domain.Entities
{
    public class Event : AuditableEntity
    {
        public Guid Id { get; set; }

        public Guid IdCategory { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Category Category { get; set; }
    }
}
