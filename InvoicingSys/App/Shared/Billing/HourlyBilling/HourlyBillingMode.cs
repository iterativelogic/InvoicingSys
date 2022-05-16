namespace InvoicingSys.App.Shared.HourlyBilling
{
    public class HourlyBillingMode : IBillingMode
    {
        private const decimal Rate = 15;
        private const decimal MaxHours = 8;

        public int HoursWorked { get; set; }

        public decimal Calculate()
        {
            return Rate * (HoursWorked / MaxHours);
        }
    }
}
