using ABCAutomotive.SQLLayer;

namespace ABCAutomotive.BusinessLayer
{
    public static class PaymentMethods
    {
        public static bool MakePayment(Payment payment)
        {
            return PaymentSQL.MakePayment(payment);
        }
    }
}
