using ABCAutomotive.Types;
using System;
using System.Data;

namespace ABCAutomotive.BusinessLayer
{
    public class Student : IStudent
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
        internal string _postalCode;
        internal string _city;
        internal string _phone;
        internal double _balancedue;
        internal ProgramType _programType;
        internal StudentStatus _status;
        internal DateTime _startDate;
        internal DateTime _endDate;
        internal object _timeStamp;

        internal Boolean _trusted = false;

        #endregion

        #region Local Properties

        internal bool IsClean
        {
            get
            {
                if (_studentid == 0 || string.IsNullOrEmpty(_firstName) || string.IsNullOrEmpty(_lastName) || string.IsNullOrEmpty(_address) || string.IsNullOrEmpty(_postalCode) || string.IsNullOrEmpty(_phone) || string.IsNullOrEmpty(_city))
                {
                    return false;
                }

                return true;
            }
        }

        #endregion

        #region Properties

        public int studentid
        {
            get
            {
                return _studentid;
            }
            set
            {
                if (value == _studentid)
                {
                    return;
                }
                if (_trusted)
                {
                    throw new ArgumentException("Cannot Change an Student ID");
                }
                if (!Validation.checkLength(value.ToString(), 8, SizeOperator.MustBeEqualTo)) 
                {
                    throw new ArgumentException("Student ID cannot be empty");
                }
                _studentid = value;
            }
        }

        public string firstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if(value == _firstName)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Required");
                }
                if (Validation.checkLength(value, 20, SizeOperator.CanBeLessThan))
                {
                    throw new ConstraintException("Student first must be less than 20 charaters");
                }
                _firstName = value;
            }
        }

        public string lastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value == _lastName)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Required");
                }
                if (Validation.checkLength(value, 3, SizeOperator.CanBeLessThan))
                {
                    throw new ConstraintException("Student last name must be less than 20 charaters");
                }
                _lastName = value;
            }
        }

        public string address
        {
            get
            {
                return _address;
            }
            set
            {
                if (value == _address)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Required");
                }
                if (Validation.checkLength(value, 50, SizeOperator.CanBeLessThan))
                {
                    throw new ConstraintException("Student address must be less than 50 charaters");
                }
                _address = value;
            }
        }

        public string postalCode
        {
            get
            {
                return _postalCode;
            }
            set
            {
                if (value == _postalCode)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Required");
                }
                if (Validation.checkLength(value, 20, SizeOperator.MustBeEqualTo))
                {
                    throw new ConstraintException("Student postal code must be 7 charaters");
                }
                if (!Validation.checkPostalCode(value))
                {
                    throw new ArgumentException("Invalid postal code");
                }
                _postalCode = value;
            }
        }

        public string city
        {
            get
            {
                return _city;
            }
            set
            {
                if (value == _city)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Required");
                }
                if (Validation.checkLength(value, 50, SizeOperator.CanBeLessThan))
                {
                    throw new ConstraintException("Student city must be less than 50 charaters");
                }
                _city = value;
            }
        }

        public string phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (value == _phone)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Required");
                }
                if (Validation.checkLength(value, 12, SizeOperator.MustBeEqualTo))
                {
                    throw new ConstraintException("Student phone number must be less than 12 charaters");
                }
                if (!Validation.checkPhoneNumber(value))
                {
                    throw new ArgumentException("Invalid phone number");
                }
                _phone = value;
            }
        }

        public double balanceDue
        {
            get
            {
                return _balancedue;
            }
            set
            {
                if(value == _balancedue)
                {
                    return;
                }
                _balancedue = value;
            }
        }

        public ProgramType programType
        {
            get
            {
                return _programType;
            }
            set
            {
                if (value == _programType)
                {
                    return;
                }
                _programType = value;
            }
        }

        public StudentStatus status
        {
            get
            {
                return _status;
            }
            set
            {
                if (value == _status)
                {
                    return;
                }
                _status = value;
            }
        }

        public DateTime startDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                if (value == _startDate)
                {
                    return;
                }
                if (value > endDate)
                {
                    throw new ConstraintException("Start date must be before end date");
                }
                _startDate = value;
            }
        }

        public DateTime endDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                if (value == _endDate)
                {
                    return;
                }
                if (value < startDate)
                {
                    throw new ConstraintException("End date must after start date");
                }
                _endDate = value;
            }
        }

        object IStudent.TimeStamp
        {
            get
            {
                return _timeStamp;
            }
            set
            {
                value = _timeStamp;
            }
        }

        #endregion

    }
}
