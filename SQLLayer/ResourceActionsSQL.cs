using ABCAutomotive.DAL;
using ABCAutomotive.Types;
using System.Collections.Generic;
using System.Data;

namespace ABCAutomotive.SQLLayer
{
    public static class ResourceActionsSQL
    {
        public static bool checkOutResource(int resourceID, int studentID)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@studentId", resourceID, ParameterDirection.Input, SqlDbType.Int));
            parmlist.Add(new ParmStruct("@resourceId", studentID, ParameterDirection.Input, SqlDbType.Int));
            DataAccess.SendData("spcheckOutResource", parmlist);
            return true;
        }

        public static bool checkInResource(int returnStatus, int resourceID, bool lateflag)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@resourceid", resourceID, ParameterDirection.Input, SqlDbType.Int));
            parmlist.Add(new ParmStruct("@lateFlag", lateflag, ParameterDirection.Input, SqlDbType.Bit));
            if(returnStatus != 0)
            {
                parmlist.Add(new ParmStruct("@returnedstatus", returnStatus, ParameterDirection.Input, SqlDbType.Int));
            }
            DataAccess.SendData("spcheckInResource", parmlist);
            return true;
        }

        public static bool reserveResource(int studentID, int resourceID)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@studentId", studentID, ParameterDirection.Input, SqlDbType.Int));
            parmlist.Add(new ParmStruct("@resourceId", resourceID, ParameterDirection.Input, SqlDbType.Int));
            DataAccess.SendData("spreserveResource", parmlist);
            return true;
        }

        public static bool updateStatus(int resourceID, ResourceStatus status)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@status", status, ParameterDirection.Input, SqlDbType.Int));
            parmlist.Add(new ParmStruct("@resourceId", resourceID, ParameterDirection.Input, SqlDbType.Int));
            DataAccess.SendData("spupdateResourceStatus", parmlist);
            return true;
        }
    }
}
