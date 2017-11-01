using ABCAutomotive.Types;
using System;
using System.Data;

namespace ABCAutomotive.BusinessLayer
{
    public class Loan
    {

        #region Constructor

        internal Loan()
        {

        }

        #endregion

        #region Local fields

        internal int _loanId;
        internal int _studentId;
        internal int _resourceId;
        internal DateTime _checkOutDate;
        internal DateTime _dueDate;
        internal DateTime _returnDate;
        internal LoanStatus _loanStatus;

        #endregion

        #region Properties

        public int loanid
        {
            get
            {
                return _resourceId;
            }
        }

        public int resourceid
        {
            get
            {
                return _resourceId;
            }
        }

        public int studentid
        {
            get
            {
                return _studentId;
            }         
        }

        public LoanStatus status
        {
            get
            {
                return _loanStatus;
            }
        }

        public DateTime checkOutDate
        {
            get
            {
                return _checkOutDate;
            }
        }

        public DateTime returnDate
        {
            get
            {
                return _returnDate;
            }
        }

        public DateTime dueDdate
        {
            get
            {
                return _dueDate;
            }
        }

        #endregion

    }
}
