using System;
using InvoicingSys.App.Shared;

namespace InvoicingSys.App.Models
{
    public class Payment
    {
        public Project Project { get; set; }
        public DateTime Date { get; set; }
        public PaymentType Mode { get; set; }
        public decimal Amount { get; set; }
    }
}
