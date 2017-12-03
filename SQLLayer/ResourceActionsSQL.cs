using ABCAutomotive.DAL;
using ABCAutomotive.Types;
using System;
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
            return DataAccess.SendData("spcheckOutResource", parmlist);
        }

        public static bool checkInResource(int returnStatus, int resourceID, bool lateflag)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@resourceid", resourceID, ParameterDirection.Input, SqlDbType.Int));
            parmlist.Add(new ParmStruct("@lateFlag", lateflag, ParameterDirection.Input, SqlDbType.Bit));
            if (returnStatus != 0)
            {
                parmlist.Add(new ParmStruct("@returnedstatus", returnStatus, ParameterDirection.Input, SqlDbType.Int));
            }
            return DataAccess.SendData("spcheckInResource", parmlist);
        }

        public static bool reserveResource(int studentID, int resourceID)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@studentId", studentID, ParameterDirection.Input, SqlDbType.Int));
            parmlist.Add(new ParmStruct("@resourceId", resourceID, ParameterDirection.Input, SqlDbType.Int));
            return DataAccess.SendData("spreserveResource", parmlist);
        }

        public static bool updateStatus(int resourceID, ResourceStatus status)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@status", status, ParameterDirection.Input, SqlDbType.Int));
            parmlist.Add(new ParmStruct("@resourceId", resourceID, ParameterDirection.Input, SqlDbType.Int));
            return DataAccess.SendData("spupdateResourceStatus", parmlist);
        }

        public static bool insertResource(IResource resource)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@resourceId", resource.resourceid, ParameterDirection.InputOutput, SqlDbType.Int));
            parmlist.Add(new ParmStruct("@desc", resource.description, ParameterDirection.Input, SqlDbType.VarChar, 50));
            parmlist.Add(new ParmStruct("@title", resource.title, ParameterDirection.Input, SqlDbType.VarChar, 30));
            parmlist.Add(new ParmStruct("@type", resource.resourceType, ParameterDirection.Input, SqlDbType.TinyInt));
            parmlist.Add(new ParmStruct("@publisher", resource.publisher, ParameterDirection.Input, SqlDbType.VarChar, 30));
            parmlist.Add(new ParmStruct("@dateOfPurchase", resource.purchaseDate, ParameterDirection.Input, SqlDbType.DateTime));
            parmlist.Add(new ParmStruct("@price", resource.price, ParameterDirection.Input, SqlDbType.Decimal));
            if(resource.referenceNumber != string.Empty)
            {
                parmlist.Add(new ParmStruct("@referenceNum", resource.referenceNumber, ParameterDirection.Input, SqlDbType.VarChar, 50));
            }
            else
            {
                parmlist.Add(new ParmStruct("@referenceNum", DBNull.Value, ParameterDirection.Input, SqlDbType.VarChar, 50));
            }
            parmlist.Add(new ParmStruct("@image", resource.image, ParameterDirection.Input, SqlDbType.Image));
            parmlist.Add(new ParmStruct("@status", resource.resourceStatus, ParameterDirection.Input, SqlDbType.TinyInt));
            DataAccess.SendData("spinsertResource", parmlist);
            resource.resourceid = Convert.ToInt32(parmlist[0].parmValue);
            return true;
        }
    }
}
