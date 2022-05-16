using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoicingSys.App.Models;

namespace InvoicingSys.App.Services
{
    public class PaymentService : IPaymentService
    {
        public Invoice MakePayment(Payment payment)
        {
            var amount = payment.Project.BillingMode.Calculate();

            return new Invoice
            { 
                ProjectId = payment.Project.ProjectId,
                Amount = amount,
            };
        }

        public IEnumerable<Invoice> MakePayment(IEnumerable<Payment> payment)
        {
            return payment.Select(payment => MakePayment(payment));
        }
    }
}
