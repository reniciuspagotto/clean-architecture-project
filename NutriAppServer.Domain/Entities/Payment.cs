using NutriAppServer.Shared.Enum;

namespace NutriAppServer.Domain.Entities
{
    public class Payment
    {
        public EPaymentType PaymentType { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string Observation { get; private set; }
    }
}