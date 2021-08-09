using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.TicketManagement.Domain.Entities
{
    public class OrderType
    {
        public int Id { get; set; }

        public string Type { get; set; } // Standard, Premium, Vip
    }
}
