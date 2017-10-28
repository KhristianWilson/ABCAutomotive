using ABCAutomotive.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCAutomotive.BusinessLayer
{
    public class Student
    {

        #region Constructor

        internal Student()
        {

        }

        #endregion

        #region Local fields and Flags

        internal int _studentid;
        internal string _firstName;
        internal string _lastName;
        internal string _address;
        internal string _postalcode;
        internal string _city;
        internal string _phone;
        internal double _balancedue;
        internal ProgramType _programType;
        internal StudentStatus _status;
        internal DateTime _startDate;
        internal DateTime _endDate;

        internal Boolean _trusted = false;

        #endregion

        #region Local Properties

        internal bool IsClean
        {
            get
            {
                if (_studentid == 0 || string.IsNullOrEmpty(_firstName) || string.IsNullOrEmpty(_lastName) || string.IsNullOrEmpty(_address) || string.IsNullOrEmpty(_postalcode) || string.IsNullOrEmpty(_phone) || string.IsNullOrEmpty(_city))
                {
                    return false;
                }

                return true;
            }
        }

        #endregion

        #region Properties

        #endregion

    }
}
