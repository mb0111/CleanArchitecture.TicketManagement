﻿using CleanArchitecture.TicketManagement.Domain.Common;
using System;
using System.Collections.Generic;

namespace CleanArchitecture.TicketManagement.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}