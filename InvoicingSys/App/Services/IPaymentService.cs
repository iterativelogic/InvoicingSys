using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoicingSys.App.Models;

namespace InvoicingSys.App.Services
{
    public interface IPaymentService
    {
        Invoice MakePayment(Payment payment);
        IEnumerable<Invoice> MakePayment(IEnumerable<Payment> payment);
    }
}
