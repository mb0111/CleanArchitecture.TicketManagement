using CleanArchitecture.TicketManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.TicketManagement.Domain.Entities
{
    public class User : AuditableEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public DateTime Birthdate { get; set; }
    }
}
