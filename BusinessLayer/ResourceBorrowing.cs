using ABCAutomotive.SQLLayer;
using ABCAutomotive.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace ABCAutomotive.BusinessLayer
{
    #region CheckIn

    public static class ResourceMethods
    {
        public static void CheckOutResource(int studentID, int resourceID)
        {
            if(!Validation.checkLength(studentID.ToString(), 8, SizeOperator.MustBeEqualTo))
            {
                throw new ArgumentNullException("Invalid StudentID");
            }
            if (!Validation.checkLength(resourceID.ToString(), 8, SizeOperator.MustBeEqualTo))
            {
                throw new ArgumentNullException("Resource StudentID");
            }
            ResourceActionsSQL.checkOutResource(studentID, resourceID);

        }

        public static void CheckInResource(int returnStatus, int resourceID)
        {
            if (!Validation.checkLength(resourceID.ToString(), 8, SizeOperator.MustBeEqualTo))
            {
                throw new ArgumentNullException("Resource StudentID");
            }

        }
    }

    #endregion
}
