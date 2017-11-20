using ABCAutomotive.SQLLayer;
using ABCAutomotive.Types;
using System;

namespace ABCAutomotive.BusinessLayer
{
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

        public static bool UpdateStatus(Resource resource)
        {
            if (!Validation.checkLength(resource.resourceid.ToString(), 8, SizeOperator.MustBeEqualTo))
            {
                throw new ArgumentNullException("Invalid ResourceID");
            }
            return ResourceActionsSQL.updateStatus(resource.resourceid, resource.resourceStatus);
        }
    }
}
