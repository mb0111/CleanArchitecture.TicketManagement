namespace CleanArchitecture.TicketManagement.Domain.Entities
{
    public class OrderStatus
    {
        public int Id { get; set; }

        public string Status { get; set; } // Pending, Paid, Canceled, Denied
    }
}
