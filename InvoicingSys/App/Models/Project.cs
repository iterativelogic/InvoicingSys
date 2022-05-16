using InvoicingSys.App.Shared;

namespace InvoicingSys.App.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public IBillingMode BillingMode { get; set; }
    }
}
