using ABCAutomotive.SQLLayer;
using ABCAutomotive.Types;
using System;

namespace ABCAutomotive.BusinessLayer
{
    public static class ResourceMethods
    {

        #region Resource Action Methods

        public static void CheckOutResource(int studentID, int resourceID)
        {
            if(!Validation.checkLength(studentID.ToString(), 8, SizeOperator.MustBeEqualTo))
            {
                throw new ArgumentNullException("Invalid StudentID");
            }
            if (!Validation.checkLength(resourceID.ToString(), 8, SizeOperator.MustBeEqualTo))
            {
                throw new ArgumentNullException("Invalid ResourceID");
            }
            ResourceActionsSQL.checkOutResource(studentID, resourceID);

        }

        public static void CheckInResource(int returnStatus, int resourceID, bool lateflag)
        {
            if (!Validation.checkLength(resourceID.ToString(), 8, SizeOperator.MustBeEqualTo))
            {
                throw new ArgumentNullException("Invalid ResourceID");
            }
            ResourceActionsSQL.checkInResource(returnStatus, resourceID, lateflag);
        }

        public static bool ReserveResource(int studentID, int resourceID)
        {
            if (!Validation.checkLength(studentID.ToString(), 8, SizeOperator.MustBeEqualTo))
            {
                throw new ArgumentNullException("Invalid StudentID");
            }
            if (!Validation.checkLength(resourceID.ToString(), 8, SizeOperator.MustBeEqualTo))
            {
                throw new ArgumentNullException("Invalid ResourceID");
            }
            return ResourceActionsSQL.reserveResource(studentID, resourceID);
        }

        #endregion

        #region CU 

        public static bool UpdateStatus(Resource resource)
        {
            return ResourceActionsSQL.updateStatus(resource.resourceid, resource.resourceStatus);
        }

        public static bool InsertResource(Resource resource)
        {
            if (resource.IsClean)
            {
                return ResourceActionsSQL.insertResource(resource);
            }
            else
            {
                throw new ArgumentException("Resource must have all infomation");
            }
        }

        #endregion

    }
}
