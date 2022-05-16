using System;
using System.Collections.Generic;
using InvoicingSys.App.Models;
using InvoicingSys.App.Services;
using InvoicingSys.App.Shared;
using InvoicingSys.App.Shared.Billing.MilestoneBilling;
using InvoicingSys.App.Shared.HourlyBilling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InvoicingSys
{
    [TestClass]
    public class PaymentServiceTests
    {
        public HourlyBillingMode HourlyBillingMode => new HourlyBillingMode();
        public MilestoneBasedBillingMode MilestoneBasedBillingMode => new MilestoneBasedBillingMode();

        [TestMethod]
        public void TestMethod1()
        {
            var dellAccountingProject = new Project
            {
                ProjectId = 1,
                BillingMode = new HourlyBillingMode
                {
                    HoursWorked = 4
                }
            };

            var dellBillingProject = new Project
            {
                ProjectId = 2,
                BillingMode = new MilestoneBasedBillingMode
                {
                    TotalAmount = 100
                }
            };

            var customers = new List<Customer>
            {
                 new Customer
                 {
                    Name = "Dell",
                    Projects = new List<Project>
                    {
                        dellAccountingProject,
                        dellBillingProject
                    }
                 },
                 new Customer
                 {
                     Name="Apple",
                    Projects = new List<Project>
                    {
                        new Project
                        {
                            ProjectId = 10,
                            BillingMode = new HourlyBillingMode
                            {
                                HoursWorked = 8
                            }
                        },
                        new Project
                        {
                            ProjectId = 20,
                            BillingMode = new MilestoneBasedBillingMode
                            {
                                TotalAmount = 100
                            }
                        }
                    }
                 }
            };

            var company = new Company("Microsoft", customers);
            
            IPaymentService paymentService = new PaymentService();

            var invoice = paymentService.MakePayment(new Payment
            { 
                Amount = 100,
                Date = DateTime.Now,
                Mode = PaymentType.DebitCard,
                Project = dellAccountingProject
            });
        }
    }
}