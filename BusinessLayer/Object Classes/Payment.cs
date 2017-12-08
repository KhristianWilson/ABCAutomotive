using ABCAutomotive.Types;
using System;

namespace ABCAutomotive.BusinessLayer
{
    public class Payment : IPayment
    {

        #region Constructor

        internal Payment()
        {

        }

        #endregion

        #region Local fields

        internal DateTime _paymentDate;
        internal decimal _paymentAmount;
        internal int _studentId;

        #endregion

        #region Local Properties

        internal bool IsClean
        {
            get
            {
                if (_studentId == 0 || _paymentAmount <= 0)
                {
                    return false;
                }

                return true;
            }
        }

        #endregion

        #region Properties

        public DateTime paymentDate
        {
            get
            {
                return _paymentDate;
            }
            set
            {
                _paymentDate = value;
            }
        }

        public decimal paymentAmount
        {
            get
            {
                return _paymentAmount;
            }
            set
            {
                if (value == _paymentAmount)
                {
                    return;
                }
                if(value <= 0)
                {
                    throw new ArgumentException("Payment Amount Must Be greater than 0.00");
                }
                _paymentAmount = value;
            }
        }

        public int studentId
        {
            get
            {
                return _studentId;
            }
            set
            {
                if (value == _studentId)
                {
                    return;
                }
                _studentId = value;
            }
        }

        #endregion

    }
}
