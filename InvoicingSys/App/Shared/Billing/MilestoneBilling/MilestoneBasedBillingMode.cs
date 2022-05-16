namespace InvoicingSys.App.Shared.Billing.MilestoneBilling
{
    public class MilestoneBasedBillingMode : IBillingMode
    {
        public decimal TotalAmount { get; init; }
        public Milestone MilestoneCompleted { get; init; }

        public decimal Calculate()
        {
            return (TotalAmount / (int)MilestoneCompleted) * 100;
        }
    }
}
