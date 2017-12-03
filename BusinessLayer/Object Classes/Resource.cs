using ABCAutomotive.Types;
using System;
using System.Data;
using System.Drawing;

namespace ABCAutomotive.BusinessLayer
{
    public class Resource : IResource
    {

        #region Constructor

        internal Resource()
        {

        }

        #endregion

        #region Local fields and Flags

        internal int _resourceId;
        internal string _description;
        internal string _title;
        internal string _publisher;

        internal ResourceType _type;
        internal ReserveStatus _reserveStatus;
        internal ResourceStatus _status;

        internal DateTime _dateOfPurchase;
        internal byte[] _image;
        internal double _price;

        internal int _reserveingStudent;
        internal DateTime _removealDate;
        internal string _referenceNumber;

        internal Boolean _trusted = false;

        #endregion

        #region Local Properties

        internal bool IsClean
        {
            get
            {
                if (string.IsNullOrEmpty(_description) || string.IsNullOrEmpty(_title) || string.IsNullOrEmpty(_publisher) || _price == 0 || _dateOfPurchase == default(DateTime) || _image == null)
                {
                    return false;
                }

                return true;
            }
        }

        #endregion

        #region Properties

        public int resourceid
        {
            get
            {
                return _resourceId;
            }
            set
            {
                if (value == _resourceId)
                {
                    return;
                }
                if (_trusted)
                {
                    throw new ArgumentException("Cannot Change an Resource ID");
                }
                if (value == 0)
                {
                    throw new ArgumentException("Resource ID cannot be empty");
                }
                _resourceId = value;
            }
        }

        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value == _description)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Required");
                }
                if (!Validation.checkLength(value, 50, SizeOperator.CanBeLessThan))
                {
                    throw new ConstraintException("Description must be less than 50 charaters");
                }
                _description = value;
            }
        }

        public string title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value == _title)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Required");
                }
                if (!Validation.checkLength(value, 30, SizeOperator.CanBeLessThan))
                {
                    throw new ConstraintException("Title must be less than 30 charaters");
                }
                _title = value;
            }
        }

        public string publisher
        {
            get
            {
                return _publisher;
            }
            set
            {
                if (value == _publisher)
                {
                    return;
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Required");
                }
                if (!Validation.checkLength(value, 30, SizeOperator.CanBeLessThan))
                {
                    throw new ConstraintException("Publisher must be less than 30 charaters");
                }
                _publisher = value;
            }
        }

        public string referenceNumber
        {
            get
            {
                return _referenceNumber;
            }
            set
            {
                if (value == _referenceNumber)
                {
                    return;
                }
                if (!Validation.checkLength(value, 30, SizeOperator.CanBeLessThan))
                {
                    throw new ConstraintException("Reference Number must be less than 50 charaters");
                }
                _referenceNumber = value;
            }
        }

        public byte[] image
        {
            get
            {
                return _image;
            }
            set
            {
                if(value == _image)
                {
                    return;
                }
                if(value == null)
                {
                    throw new ArgumentException("Image cannot be set to null");
                }
                _image = value;
            }
        }

        public ReserveStatus reserveStatus
        {
            get
            {
                return _reserveStatus;
            }
            set
            {
                if (value == _reserveStatus)
                {
                    return;
                }
                _reserveStatus = value;
            }
        }

        public ResourceStatus resourceStatus
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

        public ResourceType resourceType
        {
            get
            {
                return _type;
            }
            set
            {
                if (value == _type)
                {
                    return;
                }
                _type = value;
            }
        }

        public DateTime purchaseDate
        {
            get
            {
                return _dateOfPurchase;
            }
            set
            {
                if (value == _dateOfPurchase)
                {
                    return;
                }
                if(value == default(DateTime))
                {
                    throw new ConstraintException("Purchase Date must be a valid date");
                }
                _dateOfPurchase = value;
            }
        }

        public double price
        {
            get
            {
                return _price;
            }
            set
            {
                if(value == _price)
                {
                    return;
                }
                if(value == 0)
                {
                    throw new ArgumentException("Price Must be greater than $0.00");
                }
                _price = value;
            }
        }

        public int reserveingStudent
        {
            get
            {
                return _reserveingStudent;
            }
        }

        public DateTime removealDate
        {
            get
            {
                return _removealDate;
            }
        }

        #endregion

        #region Getters For Student

        public Student Student
        {
            get
            {
                if (_reserveingStudent == 0)
                {
                    throw new ArgumentException("Student ID cannot be empty");
                }
                return StudentFactory.Create(_reserveingStudent);
            }
        }

        #endregion

    }
}
