using System.Collections.Generic;

namespace InvoicingSys.App.Models
{
    public class Company
    {
        public Company(string name, IEnumerable<Customer> customers)
        {
            Name = name;
            Customers = customers;
        }

        public string Name { get; init; }
        public IEnumerable<Customer> Customers { get; init; }
    }
}
