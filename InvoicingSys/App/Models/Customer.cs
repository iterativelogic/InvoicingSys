using System.Collections.Generic;

namespace InvoicingSys.App.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public IEnumerable<Project> Projects { get; set; }
    }
}
