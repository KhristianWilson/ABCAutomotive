using ABCAutomotive.SQLLayer;
using System;

namespace ABCAutomotive.BusinessLayer
{
    public static class PaymentMethods
    {
        public static bool MakePayment(Payment payment)
        {
            if (payment.IsClean)
            {
                return PaymentSQL.MakePayment(payment);
            }
            else
            {
                throw new ArgumentException("Payment Missing infomation");
            }           
        }
    }
}
