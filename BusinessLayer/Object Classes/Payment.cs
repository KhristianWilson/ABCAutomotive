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

        internal int _paymentId;
        internal DateTime _paymentDate;
        internal decimal _paymentAmount;
        internal int _studentId;

        #endregion

        #region Properties

        public int paymentId
        {
            get
            {
                return _paymentId;
            }
            set
            {
                _paymentId = value;
            }
        }

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
                _studentId = value;
            }
        }

        #endregion

    }
}
