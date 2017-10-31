using ABCAutomotive.Types;
using System;
using System.Data;

namespace ABCAutomotive.BusinessLayer
{
    public class Resource
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
        internal string _referenceNumber;
        internal string _publisher;

        internal ResourceType _type;
        internal ResourceStatus _resourceStatus;
        internal ResourceStatus _status;

        internal int _reserveingStudent;
        internal DateTime _dateOfPurchase;
        //internal image
        internal DateTime _removealDate;
        internal double _price;
 
        internal Boolean _trusted = false;

        #endregion

        #region Local Properties

        internal bool IsClean
        {
            get
            {
                if (_resourceId == 0 || string.IsNullOrEmpty(_description) || string.IsNullOrEmpty(_title) || string.IsNullOrEmpty(_publisher) || _price == 0 || _dateOfPurchase == default(DateTime))
                {
                    return false;
                }

                return true;
            }
        }

        #endregion

    }
}
